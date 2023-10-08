using TestTask.Models;

namespace TestTask.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        public Task<Order> GetOrderAsync();

        public Task<List<Order>> GetOrdersAsync();
    }
}