using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using WebApplication6.Models;

namespace WebApplication6
{
    
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _conn;

        public UserRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _conn.Query<User>("select @ from users.users;");
        }

        public void InsertUser(User userToInsert)
        {
            _conn.Execute("INSERT INTO users.users (USERNAME) VALUES (@username);",
               new { username = userToInsert.Username });

        }
    }
}
