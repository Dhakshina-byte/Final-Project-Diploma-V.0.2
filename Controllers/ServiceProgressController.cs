using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class ServiceProgressController
    {
        private readonly ServiceProgressService serviceProgressService;
        public ServiceProgressController()
        {
            serviceProgressService = new ServiceProgressService();
        }

        public void AddServiceProgress(ServiceProgress progress)
        {
            serviceProgressService.InsertServiceProgress(progress);
        }

        public void UpdateServiceProgress(ServiceProgress progress)
        {
            serviceProgressService.UpdateServiceProgress(progress);
        }

        public void RemoveServiceProgress(int progressId)
        {
            serviceProgressService.DeleteServiceProgress(progressId);
        }
    }
}
