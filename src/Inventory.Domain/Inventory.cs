namespace Inventory.Domain;
public class Inventory
{
    public int Id { get; private set; }

    public string Product { get; set; }
    public double UnitPrice { get; set; }
    public bool InStock { get; private set; }

    public Inventory(string product, double unitPrice)
    {
        GuardAgainstInvalidUnitPrice(unitPrice);
        GuardAgaintsInvalidProduct(product);

        Product = product;
        UnitPrice = unitPrice;
    }

    private static void GuardAgaintsInvalidProduct(string product)
    {
        if (string.IsNullOrWhiteSpace(product))
        {
            throw new ProductNullException();
        }
    }


    private static void GuardAgainstInvalidUnitPrice(double unitPrice)
    {
        if (unitPrice <= 0)
        {
            throw new InvalidUnitPriceException();
        }
    }

}
