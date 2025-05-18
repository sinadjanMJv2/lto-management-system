using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
 using Queueing_Management_System.ViewModel;
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


    /******************** USER LOGIN ****************/
         [HttpPost]
        public async Task<IActionResult> userloginAdmin(string username, string password)
        {
            var user = await _context.Admins.FirstOrDefaultAsync(b => b.Username == username && b.Password == password);
            if (user != null)
            {
                return Ok();
            }
            return new BadRequestObjectResult("Account not found");
        }




        /******************** JOINING DATA ****************/
    
        public ActionResult<List<BookingViewModel>> getBookings()
        {
           var result = (
                from b in _context.Bookings
                join t in _context.Transactions
                on b.TransactionId equals t.TransactionId // naka base siya table if int ba or sting kung int mag tostring ka

                select new BookingViewModel
                {
                   TransactionId = t.TransactionId,
                    TransactionName = t.TransactionName,
                    BookingId = b.BookingId,
                    BookingDate = b.BookingDate,
                    Status = b.Status,
                    Firstname = b.Firstname,
                     Lastname = b.Lastname,
                    Middlename = b.Middlename,
                    Age = b.Age,
                    Gmail = b.Gmail,
                    Prioritynumber = b.Prioritynumber

                }



            ).ToList();
            return Ok(result);

           
        }
    /************* DISPLAY OPERATIONS *****************/
        public ActionResult<List<Staffing>> getStaff()
        {
            return _context.Staffings.ToList();
        }

          public ActionResult<List<Transaction>> getTransaction()
        {
            return _context.Transactions.ToList();
        }

       public ActionResult<List<Admin>> getAdminAccount()
        {
            return _context.Admins.ToList();
        }
        




        /************* CREATE OPERATIONS *****************/
        public IActionResult addStaff(Staffing addStaff)
        {
            _context.Staffings.Add(addStaff);
            _context.SaveChanges();

            return Ok();
        }
          public IActionResult addTransaction(Transaction addTransaction)
        {
            _context.Transactions.Add(addTransaction);
            _context.SaveChanges();

            return Ok();
        }

        public IActionResult addBooking(Booking addBooking)
        {

            try
            {
               _context.Bookings.Add(addBooking);
               _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }

            return Ok();
        }


        




        /************* UPDATE OPERATIONS *****************/
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

            public IActionResult updateTransaction(Transaction upTransac)
        {
            try
            {
                _context.Transactions.Update(upTransac);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }

            return Ok();
        }

 /************* DELETE OPERATIONS *****************/
        public IActionResult deleteStaff(int id)
        {

            var res = _context.Staffings.Where(element => element.StaffId == id).FirstOrDefault();
            _context.Staffings.Remove(res);
            _context.SaveChanges();
            return Ok();
        }

          public IActionResult deleteTransaction(int id)
        {

            var res = _context.Transactions.Where(element => element.TransactionId == id).FirstOrDefault();
            _context.Transactions.Remove(res);
            _context.SaveChanges();
            return Ok();
        }




    }
}