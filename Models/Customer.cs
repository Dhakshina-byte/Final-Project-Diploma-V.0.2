using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    public class Customer
    {
    }
    public class CustomerComplaint
    {
        public int ComplaintID { get; set; }
        public string CustomerName { get; set; }
        public DateTime ComplaintDate { get; set; }
        public string ComplaintText { get; set; }
        public string ResponseText { get; set; }
        public string Status { get; set; }
    }
}
