using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApi.project.Models;

namespace UserApi.project.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();
        Task<List<State>> GetAllStates();
        List<City> GetAllCities(int StateID);

        Task<User> GetUserById(int id );

        Task<int> AddUserAsync(User user);

        Task DeleteUser(int id);

        Task UpdateUser(User user);
    }
}
