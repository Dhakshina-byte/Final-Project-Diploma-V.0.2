using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproject.Controllers
{
    public class SalesController
    {
        private readonly SalesService dataAccess;

        public SalesController()
        {
            dataAccess = new SalesService();
        }

        public void AddSalesTarget(SalesBudget budget)
        {
            dataAccess.SetSalesTarget(budget);
        }

        public void AddSalesQuota(BudgetExpense expense)
        {
            dataAccess.SetSalesQuotas(expense);
        }

        public int ReminderMethod()
        {
            decimal remainingAmount = dataAccess.GetRemainingAmount();
            return (int)remainingAmount;
        }
    }
}

