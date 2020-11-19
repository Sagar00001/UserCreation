using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserCreation.project.Models;

namespace UserCreation.project.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<List<State>> GetAllStates();
        Task<List<City>> GetAllCities();

        Task<User> GetUserByEmail(string email );

        Task<int> AddUserAsync(User user);

        Task DeleteUser(string email);

        Task UpdateUser(User user);
    }
}
