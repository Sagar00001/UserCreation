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

        Task<User> GetUserById(int id );

        Task<int> AddUserAsync(User user);

        Task DeleteUser(int id);

        Task UpdateUser(User user);
    }
}
