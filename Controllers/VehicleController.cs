﻿using Finalproject.Models;
using Finalproject.Services;
using Finalproject.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    
public class VehicleController
    {
        private readonly VehicleService  vehicleService;

        // Constructor to initialize the readonly field
        public VehicleController()
        {
            vehicleService = new VehicleService();
        }

        public DataTable GetVehicles()
        {
            return vehicleService.GetVehicles();
        }

        internal void UpdatePrice(decimal price, string chassis_no)
        {
            vehicleService.UpdatePrice(chassis_no, price);
        }

        public void AddVehicle(Vehicles vehicle)
        {
            vehicleService.InsertVehicle(vehicle);
        }

        public void UpdateVehicle(Vehicles vehicle)
        {
            vehicleService.UpdateVehicle(vehicle);
        }

        public DataTable autosearchvehicle(string search)
        {
            return vehicleService.autosearchvehicle(search);
        }

        public void RemoveVehicle(int vehicleId)
        {
            vehicleService.DeleteVehicle(vehicleId);
        }
    }

}
