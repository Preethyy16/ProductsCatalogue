using ProductsCatalogue.Repositories;

namespace ProductCatalogTest;

public class ProductsRepositoryTests
{


    [Fact]
    public void GetAll_ReturnsAtLeastOneProduct()
    {
        var repository = new ProductsRepository();

        var products = repository.GetAllAsync(CancellationToken.None).Result;

        Assert.NotEmpty(products);
    }

    [Fact]
    public void Product_IdIsFilled()
    {
        var repository = new ProductsRepository();
        var product = repository.GetAllAsync(CancellationToken.None).Result[0];

        Assert.True(product.Id > 0);
    }

    [Fact]
    public void Product_NameIsFilled()
    {
        var repository = new ProductsRepository();
        var product = repository.GetAllAsync(CancellationToken.None).Result[0];

        Assert.False(string.IsNullOrEmpty(product.Name));
    }

    [Fact]
    public void Product_CategoryIsFilled()
    {
        var repository = new ProductsRepository();
        var product = repository.GetAllAsync(CancellationToken.None).Result[0];

        Assert.False(string.IsNullOrEmpty(product.category));
    }

    [Fact]
    public void Product_PriceIsGreaterThanZero()
    {
        var repository = new ProductsRepository();
        var product = repository.GetAllAsync(CancellationToken.None).Result[0];

        Assert.True(product.price > 0);
    }

    [Fact]
    public void Product_HasCorrectValues()
    {
        var repository = new ProductsRepository();
        var product = repository.GetAllAsync(CancellationToken.None).Result[0];

        Assert.Equal(1, product.Id);
        Assert.Equal("Books", product.Name);
        Assert.Equal("Stationary", product.category);
        Assert.Equal(55.55M, product.price);
    }
}