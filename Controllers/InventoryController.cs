using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
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

    }
}
