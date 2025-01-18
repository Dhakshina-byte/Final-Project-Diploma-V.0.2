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
    public class VehicleOwnerController
    {
        private VehicleOwnerService vehicleOwnerService = new VehicleOwnerService();

        public DataTable GetAllVehicleOwners()
        {
            return vehicleOwnerService.GetAllVehicleOwners();
        }

        public void AddVehicleOwner(VehicleOwner owner)
        {
            vehicleOwnerService.AddVehicleOwner(owner);
        }

        public void UpdateVehicleOwner(VehicleOwner owner)
        {
            vehicleOwnerService.UpdateVehicleOwner(owner);
        }

        public void RemoveVehicleOwner(int id)
        {
            vehicleOwnerService.DeleteVehicleOwner(id);
        }
    }
}
