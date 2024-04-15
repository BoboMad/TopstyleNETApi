using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Topsstyle.Core.Services.Interfaces;
using Topstyle.Domain.Entites;

namespace Topsstyle.Core.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderService _orderService;
        public OrderService(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task CreateOrder(Order order)
        {
            await _orderService.CreateOrder(order);
        }

        public async Task DeleteOrder(int orderId)
        {
            await _orderService.DeleteOrder(orderId);
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            return await _orderService.GetOrderById(orderId);
        }

        public async Task UpdateOrder(Order order)
        {
            await _orderService.UpdateOrder(order);
        }
    }
}
