using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Strips {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl chartControl1 = new ChartControl();

            // Create a series and add points to it.
            Series series1 = new Series("Series 1", ViewType.SplineArea);
            series1.Points.Add(new SeriesPoint("A", new double[] { 10 }));
            series1.Points.Add(new SeriesPoint("B", new double[] { 2 }));
            series1.Points.Add(new SeriesPoint("C", new double[] { 17 }));
            series1.Points.Add(new SeriesPoint("D", new double[] { 4 }));
            series1.Points.Add(new SeriesPoint("E", new double[] { 17 }));
            series1.Points.Add(new SeriesPoint("F", new double[] { 10 }));
            series1.Points.Add(new SeriesPoint("G", new double[] { 15 }));

            // Hide labels of the series1 (if necessary).
            series1.Label.Visible = false;

            // Add the series to the chart.
            chartControl1.Series.Add(series1);

            // Cast the chart's diagram to the XYDiagram type, to access its axes.
            XYDiagram diagram = chartControl1.Diagram as XYDiagram;

            // Create a strip.
            diagram.AxisY.Strips.Add(new Strip("Strip 1"));

            // Enable and define its MaxLimit and MinLimit properties.
            diagram.AxisY.Strips[0].MaxLimit.Enabled = true;
            diagram.AxisY.Strips[0].MinLimit.Enabled = true;

            diagram.AxisY.Strips[0].MaxLimit.AxisValue = 15;
            diagram.AxisY.Strips[0].MinLimit.AxisValue = 5;

            // Customize the strip's behavior.
            diagram.AxisY.Strips[0].Visible = true;
            diagram.AxisY.Strips[0].ShowAxisLabel = true;
            diagram.AxisY.Strips[0].AxisLabelText = "My Range";
            diagram.AxisY.Strips[0].ShowInLegend = true;
            diagram.AxisY.Strips[0].LegendText = "A Sample Strip";

            //  Customize the strip's appearance.
            diagram.AxisY.Strips[0].Color = Color.CornflowerBlue;
            diagram.AxisY.Strips[0].FillStyle.FillMode = FillMode.Empty;

            // Add the chart to the form.
            chartControl1.Dock = DockStyle.Fill;
            this.Controls.Add(chartControl1);
        }

    }
}