using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_System.Data;
using ITS_System.Models;
using FlexAppealFitness.Models;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Identity;

namespace FlexAppealFitness.Areas.Customer.Views
{
    [Area("Customer")]
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public BookingController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Customer/Bookings
        public async Task<IActionResult> Index(string searchString)
        {
            var classSchedules = from c in _context.Schedule
                                 select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                searchString = searchString.ToLower();

                classSchedules = classSchedules.Where(s => s.Instructor.Email.ToLower().Contains(searchString) ||
                s.ClassName.ToLower().Contains(searchString) ||
                s.DateTime.ToString().Contains(searchString));
            }
            return View(await classSchedules.Include("Instructor").Include("Room").OrderBy(s => s.ClassName).ToListAsync());
        }

        public async Task<IActionResult> Book(int Id)
        {
            var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (currentUser == null)
            {
                return NotFound();
            }

            Booking book = new Booking();

            book.ClassId = Id;
            book.AttendeeId = currentUser.Id;
            book.TimeStamp = DateTime.Now;
            book.Status = Enums.BookingStatus.Active;
            book.Attendee = currentUser;

            var currentClass = await _context.Schedule.FindAsync(Id);

            if (currentClass == null)
            {
                return NotFound();
            }

            book.Class = currentClass;

            currentClass.Attendees.Add(book);
            currentClass.AvailableSpaces = currentClass.MaxNumbersOfBooking - currentClass.Attendees.Count();
            _context.Schedule.Update(currentClass);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
        