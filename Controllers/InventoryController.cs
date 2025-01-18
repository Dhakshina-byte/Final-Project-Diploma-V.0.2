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
    public class InventoryController
    {
        private readonly InventoryService inventoryService;

        public InventoryController()
        {

            inventoryService = new InventoryService();

        }
        public void AddInventory(Inventory inventory)
        {
            inventoryService.InsertInventory(inventory);
        }
        public void UpdateInventory(Inventory inventory)
        {
            inventoryService.UpdateInventory(inventory);
        }
        public void DeleteInventory(int inventoryId)
        {
            inventoryService.DeleteInventory(inventoryId);
        }

        public DataTable getInventory()
        {
            return inventoryService.ShowInventory();
        }
        public DataTable getTools()
        {
            return inventoryService.showtools();
        }

        public void AddRequest(Request request,Tools tools)
        {
            inventoryService.InsertRequest(request,tools);
        }

        public DataTable showtools()
        {
            return inventoryService.showtools();
        }
        
        public void InsertRequestParts(Request request, SpareParts spareParts)
        {
            inventoryService.insertreqestparts(request, spareParts);
        }
    }
}
