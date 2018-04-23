Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_StackedSplineAreaChart
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim stackedSplineAreaChart As New ChartControl()

            ' Create two stacked spline area series.
            Dim series1 As New Series("Series 1", ViewType.StackedSplineArea)
            Dim series2 As New Series("Series 2", ViewType.StackedSplineArea)

            ' Add points to them.
            series1.Points.Add(New SeriesPoint("A", 80))
            series1.Points.Add(New SeriesPoint("B", 20))
            series1.Points.Add(New SeriesPoint("C", 50))
            series1.Points.Add(New SeriesPoint("D", 30))

            series2.Points.Add(New SeriesPoint("A", 40))
            series2.Points.Add(New SeriesPoint("B", 60))
            series2.Points.Add(New SeriesPoint("C", 20))
            series2.Points.Add(New SeriesPoint("D", 80))

            ' Add both series to the chart.
            stackedSplineAreaChart.Series.AddRange(New Series() { series1, series2 })

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, StackedSplineAreaSeriesView).LineTensionPercent = 10
            CType(series2.View, StackedSplineAreaSeriesView).LineTensionPercent = 70

            ' Access the diagram's options.
            CType(stackedSplineAreaChart.Diagram, XYDiagram).Rotated = True

            ' Hide the legend (if necessary).
            stackedSplineAreaChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False

            ' Add a title to the chart (if necessary).
            stackedSplineAreaChart.Titles.Add(New ChartTitle())
            stackedSplineAreaChart.Titles(0).Text = "A Stacked Spline Area Chart"
            stackedSplineAreaChart.Titles(0).WordWrap = True

            ' Add the chart to the form.
            stackedSplineAreaChart.Dock = DockStyle.Fill
            Me.Controls.Add(stackedSplineAreaChart)
        End Sub
    End Class
End Namespace