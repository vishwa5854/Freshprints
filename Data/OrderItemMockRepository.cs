using System.Collections;
using System.Collections.Generic;

namespace Freshprints.Data
{
    public class OrderItemMockRepository
    {
        public static IEnumerable GetAllOrders(string userName)
        {
            var orders = new List<OrderItem>
            {
                new OrderItem(OrdersMockRepository.GetOrderId(userName).ToString(),"lol","29-08-2020"), 
            };

            return orders;
        }
        
        public static IEnumerable GetAllOrders(string userName, int orderId)
        {
            var orders = new List<OrderItem>
            {
                new OrderItem(orderId.ToString(),"lol","29-08-2020"), 
            };

            return orders;
        }
    }
}