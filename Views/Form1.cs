using Finalproject.Controllers;
using Finalproject.Models;
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

namespace Finalproject.Views
{
    public partial class Form1 : Form
    {
        private NetProfitController controller;
        public Form1()
        {
            InitializeComponent();
            //controller = new NetProfitController(this);
            ConfigureChart();
        }

        private void ConfigureChart()
        {
            chart1.Series.Clear();
            Series series = new Series("Net Profit")
            {
                ChartType = SeriesChartType.Line
            };
            chart1.Series.Add(series);
            chart1.ChartAreas.Add(new ChartArea("MainArea"));
        }

        public void UpdateChart(NetProfitModel model)
        {
            chart1.Series["Net Profit"].Points.AddXY(DateTime.Now.ToString("g"), model.NetProfit);
        }

        public void AddDataPointToChart(NetProfitModel model)
        {
            chart1.Series["Net Profit"].Points.AddXY(model.CreatedAt.ToString("g"), model.NetProfit);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            controller.LoadHistoricalData();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
