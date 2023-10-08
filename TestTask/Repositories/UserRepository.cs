using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Repositories.Interfaces;

namespace TestTask.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly ApplicationDbContext dbContext;

        public UserRepository(DbContextOptions<ApplicationDbContext> context)
        {
            dbContext = new ApplicationDbContext(context);
        }

        public async Task<User> GetUserAsync()
        {
            int userID = dbContext.Orders.GroupBy(order => order.UserId).OrderByDescending(group => group.Count()).Select(user => user.Key).First();
            return await Task.FromResult(dbContext.Users.Where(user => user.Id == userID).First());
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await Task.FromResult(dbContext.Users.Where(user => user.Status == Enums.UserStatus.Inactive).ToList());
        }

    }
}