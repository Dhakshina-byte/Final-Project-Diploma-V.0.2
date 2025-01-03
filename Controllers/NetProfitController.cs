using Finalproject.Models;
using Finalproject.Services;
using Finalproject.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproject.Controllers
{
    public class NetProfitController
    {
        private readonly Services.NetProfitService dataAccess;
        private CEO CEO;
    

    public NetProfitController(CEO view)
        {
            this.CEO = view;
            this.dataAccess = new NetProfitService();
        }

        //public void SaveNetProfit(decimal revenue, decimal expenses)
        //{
        //    decimal netProfit = revenue - expenses;
        //    NetProfitModel model = new NetProfitModel
        //    {
        //        Revenue = revenue,
        //        Expenses = expenses,
        //        NetProfit = netProfit
        //    };

        //    dataAccess.SaveNetProfit(model);
        //    form.UpdateChart(model);
        //}

        public void LoadHistoricalData()
        {
            dataAccess.NetprofitChart(CEO.AddDataPointToChart);
        }
        public DataTable Getprofit()
        {
            return dataAccess.GetNetProfit();
        }
    }
}
