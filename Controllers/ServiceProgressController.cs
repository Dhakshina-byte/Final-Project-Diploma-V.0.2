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
    public class ServiceProgressController
    {
        private readonly ServiceProgressService serviceProgressService;
        public ServiceProgressController()
        {
            serviceProgressService = new ServiceProgressService();
        }

        public DataTable serchbyID(int id)
        {
            return serviceProgressService.SearchServiceProgress(id);
        }

        public DataTable GetAllServiceProgress()
        {
            return serviceProgressService.GetAllServiceProgress();
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
