using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SellingCourseWebsite.DAL;
using SellingCourseWebsite.DAL.Entities;
using SellingCourseWebsite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SellingCourseWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
        }

        public IActionResult Index()
        {
            //CourseSellDbContext db = new CourseSellDbContext();
            //BlogType type = db.BlogTypes.Where(c => c.Id == 1).FirstOrDefault();

            //Blog blog = new Blog() {
            //    Title = "tieu de 2",
            //    Active = true,
            //    Author = "ngo toan",
            //    BlogType = type,
            //    Content = "349399493",
            //    CreateDate = DateTime.Now,
            //    ViewCount = 12              
            
            //};
            //db.Blogs.Add(blog);

            
            //db.SaveChanges();
            return View();
        }

        public IActionResult Privacy()
        {
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
