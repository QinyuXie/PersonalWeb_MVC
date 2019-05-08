using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWeb.Models;
using PersonalWeb.Models.ViewModels;
using PersonalWeb.Data;

namespace PersonalWeb.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;
        ResumeViewModel model = new ResumeViewModel();

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            model.user = _context.userInfos.Find(1);
            model.eduDetails = _context.edus.ToList();
            model.workDetails = _context.works.ToList();
            return View(model);
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
