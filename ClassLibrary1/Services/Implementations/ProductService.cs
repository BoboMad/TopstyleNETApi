using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topsstyle.Core.Services.Interfaces;
using Topstyle.Domain.Entites;

namespace Topsstyle.Core.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductService _productService;
        public ProductService(IProductService productService)
        {
            _productService = productService;
        }

        public async Task CreateProduct(Product product)
        {
            await _productService.CreateProduct(product);
        }

        public async Task DeleteProduct(int productId)
        {
            await _productService.DeleteProduct(productId);
        }

        public async Task<Product> GetProductById(int productId)
        {
            return await _productService.GetProductById(productId);
        }

        public async Task UpdateProduct(Product product)
        {
            await _productService.UpdateProduct(product);
        }
    }
}
