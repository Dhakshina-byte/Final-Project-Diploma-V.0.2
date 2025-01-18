using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    public class VehicleOwner
    {
        public int Owner_ID { get; set; }
        public string Owner_Name { get; set; }
        public string Owner_Mobile { get; set; }
        public string Owner_Email { get; set; }
        public string License_plate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public float TotalPrice { get; set; }
    }
}
