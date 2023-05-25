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



namespace ITS_System.Areas.Customer.Controllers
{
    public class ViewClassesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ViewClassesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Area("Customer")]
        [Authorize(Roles = "Customer")]
        public IActionResult Index()
        {
            var applicationDbContext = _context.Schedule.ToList();
            return View(applicationDbContext);
        }

        // GET: Customer/Classes
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
    }
}