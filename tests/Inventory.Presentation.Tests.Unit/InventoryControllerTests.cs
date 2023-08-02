using Inventory.Application.Contract;
using Inventory.Presentation.Controllers;
using NSubstitute;
using Xunit.Categories;

namespace Inventory.Presentation.Tests.Unit;

public class InventoryControllerTests
{
    private readonly InventoryController _controller;
    private readonly IInventoryAppService _inventoryService;

    public InventoryControllerTests()
    {
        _inventoryService = Substitute.For<IInventoryAppService>();
        _controller = new InventoryController(_inventoryService);
    }

    [Fact]
    [UnitTest]
    public void Should_CallDefineInventory()
    {
        var command = new DefineInventory { Product = "IPhone", UnitPrice = 1000 };

        _controller.Define(command);

        _inventoryService.ReceivedWithAnyArgs().Define(default);

    }
}
