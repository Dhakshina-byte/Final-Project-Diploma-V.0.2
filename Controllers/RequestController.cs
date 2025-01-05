using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class RequestController
    {
        private RequestService RequestService = new RequestService();

        public void AddRequest(Request request)
        {
            RequestService.InsertRequest(request);
        }

        public void UpdateRequest(Request request)
        {
            RequestService.UpdateRequest(request);
        }

        public void RemoveRequest(int id)
        {
            RequestService.DeleteRequest(id);
        }
    }
}
