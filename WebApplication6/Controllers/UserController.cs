using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserRepository repo;
      
        public UserController(IUserRepository repo)
        {
            this.repo = repo;
        }
      
        public IActionResult Index()
        {

            var users = repo.GetAllUsers();
            return View(users);
        }

       public IActionResult InsertUser(User userToInsert)
        {
            repo.InsertUser(userToInsert);

            return RedirectToAction("Index");

        }
    }
}
