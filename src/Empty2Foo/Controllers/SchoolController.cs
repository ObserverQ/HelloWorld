using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Empty2Foo.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Empty2Foo.Controllers
{
    public class SchoolController : Controller
    {
        private D__DATABASE_DATADEMO_MDFContext _dbContext;
        public SchoolController(D__DATABASE_DATADEMO_MDFContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
