using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Models
{
    public class ServiceBooking
    {
        public int Booking_ID { get; set; }
        public int Vehicle_ID { get; set; }
        public DateTime Booking_Date { get; set; }
        public string Service_Type { get; set; }
        public string Status { get; set; }
    }

    public class VehicleInspection
    {
        public int Inspection_ID { get; set; }
        public int Vehicle_ID { get; set; }
        public DateTime Inspection_Date { get; set; }
        public string Inspector_Name { get; set; }
        public string Inspection_Result { get; set; }
    }

    public class Maintain
    {
        public int Maintain_ID { get; set; }
        public int Vehicle_ID { get; set; }
        public DateTime Maintain_Date { get; set; }
        public string Description { get; set; }
    }

    public class Setup
    {
        public int Setup_ID { get; set; }
        public int Vehicle_ID { get; set; }
        public DateTime Setup_Date { get; set; }
        public string Setup_Details { get; set; }
    }

    public class Repair
    {
        public int Repair_ID { get; set; }
        public int Vehicle_ID { get; set; }
        public DateTime Repair_Date { get; set; }
        public string Repair_Description { get; set; }
        public decimal Cost { get; set; }
    }

    public class ServiceProgress
    {
        public int Progress_ID { get; set; }
        public int Booking_ID { get; set; }
        public DateTime Progress_Date { get; set; }
        public string Progress_Description { get; set; }
    }
}
