using ProductsCatalogue.Models;

namespace ProductsCatalogue.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync(CancellationToken cancellationToken);
    }
}
