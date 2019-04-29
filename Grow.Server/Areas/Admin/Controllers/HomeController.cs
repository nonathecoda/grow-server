﻿using Grow.Server.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grow.Server.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : BaseAdminController
    {
        public HomeController(GrowDbContext dbContext, IOptions<AppSettings> appSettings) : base(dbContext, appSettings)
        {
        }

        // GET: Admin/Home
        public IActionResult Index()
        {
            var query = DbContext.Contests.Where(c => c.Year == SelectedContestYear);
            query = query
                .Include(c => c.Events)
                .Include(c => c.Mentors)
                    .ThenInclude(m => m.Person)
                .Include(c => c.Prizes)
                .Include(c => c.Teams);
            var contest = query.Single();

            ViewBag.SelectedContestYear = contest.Year;
            ViewBag.LatestContestYear = DbContext.Contests.OrderByDescending(c => c.Year).First().Year;

            return View(contest);
        }

        [HttpPost]
        public IActionResult SetYear(string year)
        {
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddHours(6)
            };
            
            if (DbContext.Contests.Any(c => c.Year.Equals(year)))
            {
                Response.Cookies.Append(Constants.COOKIE_SELECTED_YEAR_KEY, year, options);
                return Ok();
            }

            return NotFound();
        }
    }
}