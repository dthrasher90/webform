using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();
        public void InsertUser(User userToInsert);
    }
}
