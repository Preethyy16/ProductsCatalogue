using ProductsCatalogue.Models;

namespace ProductsCatalogue.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        public Task<List<Product>> GetAllAsync(CancellationToken ct)
        {
            return Task.FromResult(
                new List<Product>()
                    { 
                             new Product()
                             {
                                Id = 1,
                                Name = "Books",
                                category = "Stationary",
                                price = 55.55M
                             }
                     }
               );
        }
    }
}
