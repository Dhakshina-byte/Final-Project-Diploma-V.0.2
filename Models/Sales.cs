using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    
    public class SalesBudget
    {
        public int Year { get; set; }
        public decimal BudgetAmount { get; set; }
        public int DepartmentID { get; set; }
        public int reminder { get; set; }
}

 
    public class BudgetExpense
    {
        public int ExpenseID { get; set; }
        public string ExpenseDescription { get; set; }
        public decimal ExpenseAmount { get; set; }
        public DateTime ExpenseDate { get; set; }
    }

}
