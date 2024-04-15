using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topstyle.Domain.Entites;

namespace Topsstyle.Core.Services.Interfaces
{
    public interface IProductService
    {
        Task CreateProduct(Product product);
        Task<Product> GetProductById(int productId);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int productId);
    }
}
