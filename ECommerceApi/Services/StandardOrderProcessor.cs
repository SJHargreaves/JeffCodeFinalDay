using ECommerceApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApi.Services
{
    public class StandardOrderProcessor : IProcessOrders
    {
        public async Task<OrderResponse> ProcessOrderAsync(OrderPostRequest request)
        {
            return new OrderResponse();
        }
    }
}
