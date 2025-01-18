
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproject.Views
{
    public partial class AnnualRpt : Form
    {
        public AnnualRpt()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport2 rpt = new CrystalReport2();
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
