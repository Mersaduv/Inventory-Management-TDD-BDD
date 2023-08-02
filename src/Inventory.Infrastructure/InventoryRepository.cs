using Inventory.Domain;


namespace Inventory.Infrastructure
{
    public class InventoryRepository : IINventoryRepository
    {
        private readonly InventoryItemContext _inventoryContext;

        public InventoryRepository(InventoryItemContext inventoryContext)
        {
            _inventoryContext = inventoryContext;
        }


        public void Create(Domain.Inventory entity)
        {
            _inventoryContext.InventoryItem.Add(entity);
            Save();
        }

        public void Save()
        {
            _inventoryContext.SaveChanges();
        }
    }
}