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
    public class RepairController
    {
        private readonly RepairService repairService;

        public RepairController()
        {
            repairService = new RepairService();
        }

        public DataTable showRepair()
        {
            return repairService.showRepair();
        }

        public void AddRepair(Repair repair)
        {
            repairService.InsertRepair(repair);
        }

        public void UpdateRepair(Repair repair)
        {
            repairService.UpdateRepair(repair);
        }

        public void RemoveRepair(int repairId)
        {
            repairService.DeleteRepair(repairId);
        }
    }
}
