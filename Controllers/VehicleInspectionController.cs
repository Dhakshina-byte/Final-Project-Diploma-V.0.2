using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class VehicleInspectionController
    {
        private VehicleInspectionService vehicleInspection = new VehicleInspectionService();

        public void AddVehicleInspection(VehicleInspection inspection)
        {
            vehicleInspection.InsertVehicleInspection(inspection);
        }

        public void UpdateVehicleInspection(VehicleInspection inspection)
        {
            vehicleInspection.UpdateVehicleInspection(inspection);
        }

        public void RemoveVehicleInspection(int inspectionId)
        {
            vehicleInspection.DeleteVehicleInspection(inspectionId);
        }
    }
}
