using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topstyle.Domain.Entites;

namespace Topstyle.Data.Repos.Interfaces
{
    public interface IOrderRepo
    {
        Task CreateOrder(Order order);
        Task<Order> GetOrderById(int orderId);
        Task UpdateOrder(Order order);
        Task DeleteOrder(int orderId);
    }
}
