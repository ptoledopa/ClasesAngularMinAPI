using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product> GetProductById(int id);
        Task<int> Insert(Product product);
        Task<bool> Update(Product product);
        Task<bool> Delete(int id);
    }
}
