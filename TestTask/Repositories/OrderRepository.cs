using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Repositories.Interfaces;

namespace TestTask.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        private readonly ApplicationDbContext dbContext;

        public OrderRepository(DbContextOptions<ApplicationDbContext> context)
        {
            dbContext = new ApplicationDbContext(context);
        }

        public async Task<Order> GetOrderAsync()
        {
            int maxSum = dbContext.Orders.Max(order => order.Price * order.Quantity);
            return await Task.FromResult(dbContext.Orders.Where(Order => Order.Price * Order.Quantity == maxSum).First());
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
           
            return await Task.FromResult(dbContext.Orders.Where(order => order.Quantity > 10).ToList());
        }
    }
}