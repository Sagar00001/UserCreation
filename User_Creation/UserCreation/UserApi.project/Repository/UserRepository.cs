using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApi.project.Data;
using UserApi.project.Models;


namespace UserApi.project.Repository
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

        public async Task DeleteUser(int id)
        {
            if (usercontext != null)
            {
                
                var user = await usercontext.User.FirstOrDefaultAsync(x => x.ID == id);
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

        public List<City> GetAllCities(int StateID)
        {
            if (usercontext != null)
            {
                var list = usercontext.City.Where(x => x.StateID == StateID).ToList();
                return list;
                
            }
            return null;
        }

        public async Task<User> GetUserById(int id)
        {
            if (usercontext != null)
            {
                return await usercontext.User.FirstOrDefaultAsync(x => x.ID == id);
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
