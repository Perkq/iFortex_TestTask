using TestTask.Models;
using TestTask.Repositories.Interfaces;
using TestTask.Services.Interfaces;

namespace TestTask.Services
{
    public class OrderService : IOrderService
    {

        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepo)
        {
            orderRepository = orderRepo;
        }

        // Return the order with the highest order amount
        public async Task<Order> GetOrder()
        {
            return await orderRepository.GetOrderAsync();
        }

        // Return orders with a quantity of items greater than 10
        public async Task<List<Order>> GetOrders()
        {
            return await orderRepository.GetOrdersAsync();
        }

    }
}