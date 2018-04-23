Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Strips
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' Create an empty chart.
			Dim chartControl1 As New ChartControl()

			' Create a series and add points to it.
			Dim series1 As New Series("Series 1", ViewType.SplineArea)
			series1.Points.Add(New SeriesPoint("A", New Double() { 10 }))
			series1.Points.Add(New SeriesPoint("B", New Double() { 2 }))
			series1.Points.Add(New SeriesPoint("C", New Double() { 17 }))
			series1.Points.Add(New SeriesPoint("D", New Double() { 4 }))
			series1.Points.Add(New SeriesPoint("E", New Double() { 17 }))
			series1.Points.Add(New SeriesPoint("F", New Double() { 10 }))
			series1.Points.Add(New SeriesPoint("G", New Double() { 15 }))

			' Hide labels of the series1 (if necessary).
			series1.Label.Visible = False

			' Add the series to the chart.
			chartControl1.Series.Add(series1)

			' Cast the chart's diagram to the XYDiagram type, to access its axes.
			Dim diagram As XYDiagram = TryCast(chartControl1.Diagram, XYDiagram)

			' Create a strip.
			diagram.AxisY.Strips.Add(New Strip("Strip 1"))

			' Enable and define its MaxLimit and MinLimit properties.
			diagram.AxisY.Strips(0).MaxLimit.Enabled = True
			diagram.AxisY.Strips(0).MinLimit.Enabled = True

			diagram.AxisY.Strips(0).MaxLimit.AxisValue = 15
			diagram.AxisY.Strips(0).MinLimit.AxisValue = 5

			' Customize the strip's behavior.
			diagram.AxisY.Strips(0).Visible = True
			diagram.AxisY.Strips(0).ShowAxisLabel = True
			diagram.AxisY.Strips(0).AxisLabelText = "My Range"
			diagram.AxisY.Strips(0).ShowInLegend = True
			diagram.AxisY.Strips(0).LegendText = "A Sample Strip"

			'  Customize the strip's appearance.
			diagram.AxisY.Strips(0).Color = Color.CornflowerBlue
			diagram.AxisY.Strips(0).FillStyle.FillMode = FillMode.Empty

			' Add the chart to the form.
			chartControl1.Dock = DockStyle.Fill
			Me.Controls.Add(chartControl1)
		End Sub

	End Class
End Namespace