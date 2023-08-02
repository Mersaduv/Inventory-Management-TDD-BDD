using Inventory.Application.Contract;
using Inventory.Domain;

namespace Inventory.Application
{
    public class InventoryAppService : IInventoryAppService
    {
        private readonly IINventoryRepository _inventoryRepository;

        public InventoryAppService(IINventoryRepository inventoryRepository)
        {
            _inventoryRepository = inventoryRepository;
        }

        public bool Define(DefineInventory command)
        {
            var inventory = new Domain.Inventory(command.Product, command.UnitPrice);

            _inventoryRepository.Create(inventory);

            return true;
        }
    }
}