using Microsoft.EntityFrameworkCore;
using Topstyle.Data.Repos.Contexts;
using Topstyle.Data.Repos.Interfaces;
using Topstyle.Domain.Entites;

namespace Topstyle.Data.Repos.Implementations
{
    public class ProductRepo : IProductRepo
    {
        private readonly TopstyleContext _context;
        public ProductRepo(TopstyleContext contex)
        {
            _context = contex;
        }
        public async Task CreateProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int productId)
        {
            var productToDelete = await _context.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
            if (productToDelete != null)
            {
                _context.Products.Remove(productToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Product> GetProductById(int productId)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.ProductId == productId);
        }

        public async Task UpdateProduct(Product product)
        {
           _context.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
