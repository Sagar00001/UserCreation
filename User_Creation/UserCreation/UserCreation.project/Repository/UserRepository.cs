using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserCreation.project.Data;
using UserCreation.project.Models;

namespace UserCreation.project.Repository
{
    public class UserRepository : IUserRepository
    {
        UserContext usercontext;
        public UserRepository(UserContext _userContext)
        {
            usercontext = _userContext;
        }
        public async Task<int> AddUserAsync(User user)
        {
            if (usercontext != null)
            {
                await usercontext.User.AddAsync(user);
                await usercontext.SaveChangesAsync();
                return 1;
            }
            return 0;
        }

        public async Task DeleteUser(string email)
        {
            if (usercontext != null)
            {
                
                var user = await usercontext.User.FirstOrDefaultAsync(x => x.Email == email);
                if (user != null)
                {
                    //Delete that User
                    usercontext.User.Remove(user);
                    //Commit the transaction
                    await usercontext.SaveChangesAsync();
                }

            }
        }

        public async Task<List<User>> GetAllUsers()
        {
            if (usercontext != null)
            {
                return await usercontext.User.ToListAsync();
            }
            return null;
        }

        public async Task<List<State>> GetAllStates()
        {
            if (usercontext != null)
            {
                return await usercontext.State.ToListAsync();
            }
            return null;
        }

        public async Task<List<City>> GetAllCities()
        {
            if (usercontext != null)
            {
                return await usercontext.City.ToListAsync();
            }
            return null;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            if (usercontext != null)
            {
                return await usercontext.User.FirstOrDefaultAsync(x => x.Email == email);
            }
            return null;
        }

        public async Task UpdateUser(User user)
        {
            if (usercontext != null)
            {
                //Update that User
                usercontext.User.Update(user);
                //Commit the transaction
                await usercontext.SaveChangesAsync();
            }
        }
    }
}
