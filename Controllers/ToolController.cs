using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class ToolController
    {
        private readonly ToolsService toolsService;

        public ToolController()
        {
           
            toolsService = new ToolsService();
        }
        public DataTable showTools()
        {
            return toolsService.ShowTools();

        }
        
    }

}
