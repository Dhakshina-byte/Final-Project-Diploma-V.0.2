using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    public class MonthlyReport
    {
        public string Month { get; set; }
        public decimal SalesAmount { get; set; }
        public decimal ServiceAmount { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
