using TestTask.Models;

namespace TestTask.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> GetUserAsync();

        public Task<List<User>> GetUsersAsync();
    }
}