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
    public class ValuesController : ControllerBase
    {
        private NotebookContext db;
        public ValuesController(NotebookContext context)
        {
            db = context;
        }


        [HttpGet]
        public ActionResult<List<NotebookItem>> Get()
        {
            return db.NotebookItems.ToList() ;
            //return new List<NotebookItem>();
        }
    }
}
