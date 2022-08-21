using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class ProductServices
    {
        protected IProductRepository _productRepository;

        public ProductServices(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetProduct()
        {
            return await _productRepository.GetProducts();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _productRepository.GetProductById(id);
        }

        public async Task<int> InsertProduct(Product product)
        {
            return await _productRepository.Insert(product);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            return await _productRepository.Update(product);
        }

        public async Task<bool> DeleteProduct(int id)
        {
            return await _productRepository.Delete(id);
        }

    }
}
