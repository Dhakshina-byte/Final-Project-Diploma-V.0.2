using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class RequestStatusController
    {
        private readonly RequestStatusService requestStatusService;

        public RequestStatusController()
        {
            requestStatusService = new RequestStatusService();
        }
        public void InsertRequestStatus(RequesStatus requestStatus)
        {
            requestStatusService.InsertRequestStatus(requestStatus);
        }
        public void UpdateRequestStatus(RequesStatus requestStatus)
        {
            requestStatusService.UpdateRequestStatus(requestStatus);
        }
        public void DeleteRequestStatus(int requestId)
        {
            requestStatusService.DeleteRequestStatus(requestId);
        }
    }
}
