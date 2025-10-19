using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GrafikoaLib
{
    public partial class GrafikoControl : UserControl
    {
        public GrafikoControl()
        {
            InitializeComponent();
            grafikoaHasieratu();
        }

        private void grafikoaHasieratu()
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.Legends.Clear();

            Legend legend = new Legend();
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;
            legend.LegendStyle = LegendStyle.Table;
            chart1.Legends.Add(legend);
        }

        public void UpdateData<T>(List<T> datos, Func<T, string> etiketa, Func<T, double> kantitatea, SeriesChartType tipo)
        {
            chart1.Series.Clear();

            Series serie = new Series();
            serie.ChartType = tipo;
            serie.IsValueShownAsLabel = true;

            foreach (var item in datos)
            {
                serie.Points.AddXY(etiketa(item), kantitatea(item));
            }

            if (tipo == SeriesChartType.Pie)
            {
                double total = serie.Points.Sum(p => p.YValues[0]);
                foreach (DataPoint punto in serie.Points)
                {
                    double porcentaje = (punto.YValues[0] / total) * 100;

                    punto.Label = $"{porcentaje:F1}%";

                    punto.LegendText = punto.AxisLabel;
                }
            }
            chart1.Series.Add(serie);
        }
    }
}