using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Queueing_Management_System.Entities;

namespace Queueing_Management_System.Controllers;

 [Route("[controller]/[action]")]
public class BookingController : Controller
{
        private readonly ILogger<BookingController> _logger;

        public BookingController(ILogger<BookingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        


}
