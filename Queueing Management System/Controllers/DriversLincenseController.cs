using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Queueing_Management_System.Entities;

namespace Queueing_Management_System.Controllers;

[Route("[controller]/[action]")]
public class DriversLincenseController : Controller
{
    private readonly ILogger<DriversLincenseController> _logger;

    public DriversLincenseController(ILogger<DriversLincenseController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult LicenseRenewal()
    {
        return View();
    }

    public IActionResult StudentPermit()
    {
        return View();
    }

    public IActionResult ProfessionalLicense()
    {
        return View();
    }

    public IActionResult LicenseUpgrade()
    {
        return View();
    }
        
         public IActionResult NonProfessionalLicense()
    {
        return View();
    }





}
