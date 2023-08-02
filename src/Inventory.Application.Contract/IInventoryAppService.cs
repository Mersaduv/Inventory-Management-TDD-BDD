namespace Inventory.Application.Contract
{
    public interface IInventoryAppService
    {
        bool Define(DefineInventory command);
    }
}
