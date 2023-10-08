using TestTask.Models;
using TestTask.Repositories.Interfaces;
using TestTask.Services.Interfaces;

namespace TestTask.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepo)
        {
            userRepository = userRepo;
        }

        // Return the user with the highest number of orders
        public async Task<User> GetUser()
        {
            return await userRepository.GetUserAsync();
        }

        // Return users with the "Inactive" status
        public async Task<List<User>> GetUsers()
        {
            return await userRepository.GetUsersAsync();
        }

    }
}