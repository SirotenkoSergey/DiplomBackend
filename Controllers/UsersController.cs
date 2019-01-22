using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController
    {
        private NotebookContext db;
        public UsersController(NotebookContext context)
        {
            db = context;
        }

        
        [HttpGet]
        public ActionResult<List<User>> GetAllUsers() {
            return db.Users.ToList();
        }
        public ActionResult<User> GetUserByID(int UserID) {
            return db.Users.Find();
        }
    }
}