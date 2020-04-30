using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace blazordatagrid.Controllers
{
    public class CultureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}