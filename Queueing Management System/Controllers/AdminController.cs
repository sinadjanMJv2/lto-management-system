using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Queueing_Management_System.Entities;

namespace Queueing_Management_System.Controllers;

 [Route("[controller]/[action]")]
public class AdminController : Controller
{
        private readonly ILogger<AdminController> _logger;

        public AdminController(ILogger<AdminController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult LoginAdmin()
        {
            return View();
        }
        
        public IActionResult LoginStaff()
        {
            return View();
        }

    public IActionResult AdminDashBoard()
    {
        return View();
    }



         public IActionResult AdminSide()
    {
        return View("AdminStaff/AdminIndex");
    }

        public IActionResult AdminTransaction(){
            return View("PartialTransaction/AdminTransactionIndex");
        }

        


}
