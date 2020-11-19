using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserCreation.project.Repository
{
    public interface IUnitOfWork
    {
        IUserRepository userRepository { get; }
        void Commit();
        void Rollback();
    }
}
