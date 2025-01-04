using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class MaintainController
    {

        private MaintainService maintainService = new MaintainService();

        public void AddMaintain(Maintain maintain)
        {
            maintainService.InsertMaintain(maintain);
        }

        public void UpdateMaintain(Maintain maintain)
        {
            maintainService.UpdateMaintain(maintain);
        }

        public void RemoveMaintain(int maintainId)
        {
            maintainService.DeleteMaintain(maintainId);
        }
    }
}
