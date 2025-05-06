using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// using Queueing_Management_System.ViewModel;
using Queueing_Management_System.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;


namespace Queueing_Management_System.Controllers
{


    [Route("/api/[controller]/[action]")]
    public class AdminAPIController : ControllerBase
    {


        private readonly lto_queueng_management_systemContext _context;

        public AdminAPIController(lto_queueng_management_systemContext context)
        {
            _context = context;
        }



        public ActionResult<List<Staffing>> getStaff()
        {
            return _context.Staffings.ToList();
        }


        public IActionResult addStaff(Staffing addStaff)
        {
            _context.Staffings.Add(addStaff);
            _context.SaveChanges();

            return Ok();
        }

        public IActionResult updateStaff(Staffing upStaff)
        {
            try
            {
                _context.Staffings.Update(upStaff);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }

            return Ok();
        }

        public IActionResult deleteStaff(int id)
        {

            var res = _context.Staffings.Where(element => element.StaffId == id).FirstOrDefault();
            _context.Staffings.Remove(res);
            _context.SaveChanges();
            return Ok();
        }




    }
}