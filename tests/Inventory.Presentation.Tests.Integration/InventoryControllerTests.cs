using FluentAssertions;
using Inventory.Application.Contract;
using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;
namespace Inventory.Presentation.Tests.Integration;

public class InventoryControllerTests
{
    private readonly RESTFulApiFactoryClient _client;

    public InventoryControllerTests()
    {
        var factory = new WebApplicationFactory<Program>();
        var httpClient = factory.CreateClient();
        _client = new RESTFulApiFactoryClient(httpClient);
    }

    [Fact]
    public async Task Should_DefineNewInventoryAsync()
    {
        var command = new DefineInventory { Product = "IPhone", UnitPrice = 1100 };

        var result = await _client.PostContentAsync<DefineInventory, bool>("/api/inventory", command);

        result.Should().BeTrue();
    }
}