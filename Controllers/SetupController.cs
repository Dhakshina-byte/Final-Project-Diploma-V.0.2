using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class SetupController
    {
        private readonly SetupService setupSer;

        public SetupController()
        {
            setupSer = new SetupService();
        }
        public void AddSetup(Setup setup)
        {
            setupSer.InsertSetup(setup);
        }

        public void UpdateSetup(Setup setup)
        {
            setupSer.UpdateSetup(setup);
        }

        public void RemoveSetup(int setupId)
        {
            setupSer.DeleteSetup(setupId);
        }
    }
}
