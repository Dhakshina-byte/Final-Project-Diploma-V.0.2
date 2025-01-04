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

        public void AddSalesTarget(Decimal BudgetAmount)
        {
            dataAccess.SetSalesTarget(BudgetAmount);
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
        public int Getyear() 
        {
          int year =  dataAccess.GetCurrentYearFromSalesBudget();
            return year;
        }
        public void UpdateBudgetAmount(int year, decimal BudgetAmount)
        {
            dataAccess.UpdateBudgetAmount(year, BudgetAmount);

        }
 

            public decimal CalculateTargetPercentage(decimal actualSales, decimal salesTarget)
            {
                if (salesTarget > 0)
                {
                    return (actualSales / salesTarget) * 100;
                }
                throw new ArgumentException("Sales Target must be greater than zero.");
            }

            public void SaveSalesTarget(SalesTarget salesTarget)
        {
            dataAccess.SaveSalesTarget(salesTarget);
        }
    }
}

