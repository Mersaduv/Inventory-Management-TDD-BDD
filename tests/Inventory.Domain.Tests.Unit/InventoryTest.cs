namespace Inventory.Domain.Tests.Unit;
using FluentAssertions;
public class InventoryTest
{
    private InventoryTestBuilder _builder;

    public InventoryTest()
    {
        _builder = new InventoryTestBuilder();
    }
    [Fact]
    public void Should_ConstructInventoryProperly()
    {
        const string product = "Mac";
        const double unitPrice = 1500;

        var inventory = _builder
        .WithProduct(product)
        .WithUnitPrice(unitPrice)
        .Build();

        inventory.Product.Should().Be(product);
        inventory.UnitPrice.Should().Be(unitPrice);
        inventory.InStock.Should().BeFalse();

    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    public void Should_ThrowProductNullException_WhenProductIs(string nullOrEmpty)
    {
        Action ctor = () => _builder.WithProduct(nullOrEmpty).Build();

        ctor.Should().ThrowExactly<ProductNullException>();
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Should_ThrowInvalidUnitPriceException_WhenUnitPriceIs(double zeroOrless)
    {
        Action ctor = () => _builder.WithUnitPrice(zeroOrless).Build();
        ctor.Should().ThrowExactly<InvalidUnitPriceException>();
    }
}
