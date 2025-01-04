using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class washControllers
    {
        private readonly WashService washService;

        public washControllers()
        {
            washService = new WashService();
        }


        public void AddWash(Wash wash)
        {
            washService.InsertWash(wash);
        }

        public void UpdateWash(Wash wash)
        {
            washService.UpdateWash(wash);
        }

        public void RemoveWash(int washId)
        {
            washService.DeleteWash(washId);
        }
    }
}
