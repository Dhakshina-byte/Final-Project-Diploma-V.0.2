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
        public bool Inspection { get; set; }
        public bool Maintain { get; set; }
        public bool Setup { get; set; }
        public bool Repair { get; set; }
        public bool wash { get; set; }
        public string Status { get; set; }
    }

    public class VehicleInspection
    {
        public int Inspection_ID { get; set; }
        public int Vehicle_ID { get; set; }
        public DateTime Inspection_Date { get; set; }
        public string Inspector_DESC { get; set; }
        public string Status { get; set; }
    }

    public class Maintain
    {
        public int Maintain_ID { get; set; }
        public int Vehicle_ID { get; set; }
        public DateTime Maintain_Date { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }

    public class Setup
    {
        public int Setup_ID { get; set; }
        public int Vehicle_ID { get; set; }
        public DateTime Setup_Date { get; set; }
        public string Setup_Details { get; set; }
        public string Status { get; set; }
    }
}

    public class Repair
    {
    public int Repair_ID { get; set; }
    public int Vehicle_ID { get; set; }
    public DateTime Repair_Date { get; set; }
    public string Repair_Description { get; set; }
    public string Status { get; set; }
    }

public class Wash
{
    public int Wash_ID { get; set; }
    public int Vehicle_ID { get; set; }
    public DateTime Repair_Date { get; set; }
    public string Status { get; set; }

}

    public class ServiceProgress
    {
        public int Progress_ID { get; set; }
        public int Booking_ID { get; set; }
        public DateTime Progress_Date { get; set; }
        public string Progress_Description { get; set; }
    }
