namespace Inventory.Domain;
public interface IINventoryRepository
{
    void Create(Inventory entity);
    void Save();

}