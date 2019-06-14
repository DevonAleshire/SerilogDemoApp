using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SerilogDemoApp.Models;

namespace SerilogDemoApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var blog = new Blog
            //{
            //    Url = "my url",
            //};

            //var post = new Post
            //{
            //    Title = "Title",
            //    Content = "Content",
            //};

            //blog.Posts.Add(post);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
