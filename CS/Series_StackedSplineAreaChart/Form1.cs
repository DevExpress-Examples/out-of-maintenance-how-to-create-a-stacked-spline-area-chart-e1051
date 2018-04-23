using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_StackedSplineAreaChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl stackedSplineAreaChart = new ChartControl();

            // Create two stacked spline area series.
            Series series1 = new Series("Series 1", ViewType.StackedSplineArea);
            Series series2 = new Series("Series 2", ViewType.StackedSplineArea);

            // Add points to them.
            series1.Points.Add(new SeriesPoint("A", 80));
            series1.Points.Add(new SeriesPoint("B", 20));
            series1.Points.Add(new SeriesPoint("C", 50));
            series1.Points.Add(new SeriesPoint("D", 30));

            series2.Points.Add(new SeriesPoint("A", 40));
            series2.Points.Add(new SeriesPoint("B", 60));
            series2.Points.Add(new SeriesPoint("C", 20));
            series2.Points.Add(new SeriesPoint("D", 80));

            // Add both series to the chart.
            stackedSplineAreaChart.Series.AddRange(new Series[] { series1, series2 });

            // Adjust the view-type-specific options of the series.
            ((StackedSplineAreaSeriesView)series1.View).LineTensionPercent = 10;
            ((StackedSplineAreaSeriesView)series2.View).LineTensionPercent = 70;

            // Access the diagram's options.
            ((XYDiagram)stackedSplineAreaChart.Diagram).Rotated = true;

            // Hide the legend (if necessary).
            stackedSplineAreaChart.Legend.Visible = false;

            // Add a title to the chart (if necessary).
            stackedSplineAreaChart.Titles.Add(new ChartTitle());
            stackedSplineAreaChart.Titles[0].Text = "A Stacked Spline Area Chart";
            stackedSplineAreaChart.Titles[0].WordWrap = true;

            // Add the chart to the form.
            stackedSplineAreaChart.Dock = DockStyle.Fill;
            this.Controls.Add(stackedSplineAreaChart);
        }
    }
}