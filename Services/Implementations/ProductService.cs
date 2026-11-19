using ProductsCatalogue.Models;
using ProductsCatalogue.Repositories;
using ProductsCatalogue.Services.Interfaces;

namespace ProductsCatalogue.Services.Implementations
{
    public class ProductService : IProductService
    {

        private readonly IProductsRepository _productsRepository;

        public ProductService(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public async Task<List<Product>> GetAllAsync(CancellationToken cancellationToken)
        {
            var productsResponse = await _productsRepository.GetAllAsync(cancellationToken);

            if (productsResponse == null)
            {
                return new List<Product>();
            }

            return productsResponse;

        }
    }
}
