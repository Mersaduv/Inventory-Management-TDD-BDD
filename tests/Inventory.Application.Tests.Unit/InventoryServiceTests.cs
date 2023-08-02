using FluentAssertions;
using Inventory.Application.Contract;
using Inventory.Domain;
using NSubstitute;

namespace Inventory.Application.Tests.Unit;

public class InventoryServiceTests
{
    private readonly IInventoryAppService _inventoryApplication;
    private readonly IINventoryRepository _inventoryRepository;
    public InventoryServiceTests()
    {
        _inventoryRepository = Substitute.For<IINventoryRepository>();
        _inventoryApplication = new InventoryAppService(_inventoryRepository);
    }

    [Fact]
    public void Should_ReturnTrue_WhenInventoryDefined()
    {
        var command = new DefineInventory { Product = "IPhone", UnitPrice = 1100 };

        var result = _inventoryApplication.Define(command);

        result.Should().BeTrue();

    }

    [Fact]
    public void Should_DefineNewInventory()
    {
        var command = new DefineInventory { Product = "IPhone", UnitPrice = 1100 };

        var result = _inventoryApplication.Define(command);

        _inventoryRepository.ReceivedWithAnyArgs().Create(default);

    }
}
