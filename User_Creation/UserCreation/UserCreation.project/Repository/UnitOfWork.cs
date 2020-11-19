using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserCreation.project.Data;

namespace UserCreation.project.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UserContext _userContext;
        private IUserRepository _userrepository;

        public UnitOfWork(UserContext userContext)
        {
            _userContext = userContext;
        }

        public IUserRepository userRepository
        {
            get { return _userrepository = _userrepository ?? new UserRepository(_userContext); }
        }



        public void Commit()
        {
            _userContext.SaveChanges();
        }

        public void Rollback()
        {
            _userContext.Dispose();
        }
    }
}
