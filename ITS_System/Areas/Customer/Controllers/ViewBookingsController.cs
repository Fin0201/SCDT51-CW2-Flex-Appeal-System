﻿using ITS_System.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace ITS_System.Areas.Customer.Controllers
{
    public class ViewBookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ViewBookingsController(ApplicationDbContext context)
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
    }
}