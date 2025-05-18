using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Queueing_Management_System.Entities;

namespace Queueing_Management_System.Controllers;

[Route("[controller]/[action]")]
public class VehicleRegistrationController : Controller
{
    private readonly ILogger<VehicleRegistrationController> _logger;

    public VehicleRegistrationController(ILogger<VehicleRegistrationController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult VehicleNewRegistration()
    {
        return View();
    }

    public IActionResult VehicleRenewal()
    {
        return View();
    }

    public IActionResult VehicleTOO()
    {
        return View();
    }

    public IActionResult VehicleSpecialPermit()
    {
        return View();
    }
        
  





}
