using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    public class Vehicles
    {
        public int Vehicle_ID { get; set; }
        public string Vehicle_name { get; set; }
        public string Vehicle_type { get; set; }
        public string Chassis_no { get; set; }
        public string Engine_no { get; set; }
        public decimal Price { get; set; }
        public string Vehicle_color { get; set; }
        public string Vehicle_model { get; set; }
        public byte[] Vehicle_image { get; set; }
        public DateTime Manufacture_date { get; set; }
        public string Status { get; set; }
        public int Owner_ID { get; set; }
        public string Number_Plate { get; set; }
    }

}
