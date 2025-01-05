using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class VehicleInspectionController
    {
        private readonly VehicleInspectionService vehicleInspection;

        public VehicleInspectionController()
        {
            vehicleInspection = new VehicleInspectionService();
        }

        public DataTable GetVehicleInspection()
        {
            return vehicleInspection.GetVehicleInspection();
        }

        public void AddVehicleInspection(VehicleInspection inspection)
        {
            vehicleInspection.InsertVehicleInspection(inspection);
        }

        public void UpdateVehicleInspection(VehicleInspection inspection)
        {
            vehicleInspection.UpdateVehicleInspection(inspection);
        }

        public void RemoveVehicleInspection(int inspectionId,int Vehicle_ID)
        {
            vehicleInspection.DeleteVehicleInspection(inspectionId, Vehicle_ID);
        }
    }
}
