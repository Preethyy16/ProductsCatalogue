using ProductsCatalogue.Models;

namespace ProductsCatalogue.Repositories
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetAllAsync(CancellationToken ct);
    }
}
