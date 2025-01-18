using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    public class Inventory
    {

        public int Inventory_ID { get; set; }
        public string Serial_number { get; set; }
        public string Inventory_item_name { get; set; }
        public string Category { get; set; }
        public decimal Per_price { get; set; }
        public int Qty { get; set; }

    }


    public class Request
    {
        public int Request_ID { get; set; }
        public string Request_type { get; set; }
        public int Request_Qty { get; set; }
        public string Request_Desc { get; set; }
    }

    public class RequesStatus
    {
        public int Request_ID { get; set; }
        public string Request_type { get; set; }
        public int Request_Qty { get; set; }
        public string Request_Desc { get; set; }
        public string Request_Status { get; set; }
        public string Request_Comments { get; set; }
    }

    public class Tools
    {

        public int Tool_ID { get; set; }
        public string User_ID { get; set; }
        public int Request_ID { get; set; }
        public string Tool_name { get; set; }
        public string Tool_desc { get; set; }
        public string Tool_status { get; set; }
    }

    public class SpareParts
    {
        public int Spare_ID { get; set; }
        public int Serial_number { get; set; }
        public string User_ID { get; set; }
        public int Request_ID { get; set; }
        public string Spare_name { get; set; }
        public string Spare_desc { get; set; }
        public string Spare_status { get; set; }
    }
}
