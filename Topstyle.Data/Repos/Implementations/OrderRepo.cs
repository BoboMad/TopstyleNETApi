using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topstyle.Data.Repos.Contexts;
using Topstyle.Data.Repos.Interfaces;
using Topstyle.Domain.Entites;

namespace Topstyle.Data.Repos.Implementations
{
    public class OrderRepo : IOrderRepo
    {
        private readonly TopstyleContext _context;
        public OrderRepo(TopstyleContext contex)
        {
            _context = contex;
        }
        public async Task CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrder(int orderId)
        {
            var orderToRemove = await _context.Orders.FirstOrDefaultAsync(o => o.OrderId == orderId);
            if(orderToRemove != null)
            {
                _context.Orders.Remove(orderToRemove);
                _context.SaveChanges();
            }
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            return await _context.Orders.FirstOrDefaultAsync(o => o.OrderId == orderId);
        }

        public async Task UpdateOrder(Order order)
        {
            _context.Update(order); 
            await _context.SaveChangesAsync();
        }
    }
}
