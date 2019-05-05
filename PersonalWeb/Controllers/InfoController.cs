using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWeb.Models.Entities;
using PersonalWeb.Models.ViewModels;
using PersonalWeb.Services;
using PersonalWeb.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalWeb.Controllers
{
    public class InfoController : Controller
    {
        //private ResumeViewModel _resume;

        private readonly AppDbContext context_;
        private UserInfo userInfo_;
        public InfoController(AppDbContext context)
        {
            context_ = context;
            var users_ = context_.userInfos.ToList();
            users_.Add(new UserInfo());
            userInfo_ = users_[0];
        }
        //public InfoController(IResumeData mockResume)
        //{
        //    //_resume = mockResume.GetInstance();
        //}

        // GET: /<controller>/
        public IActionResult Index()
        {
           //userInfo_.UserFirstName = "Qinyu";
            //userInfo_.UserLastName = "Xie";
            //userInfo_.Age = 23;
            //userInfo_.Address = "505";
            //userInfo_.EmailAddress = "qinyu@gmail.com";
            //userInfo_.PhoneNumber = "3514508661";
            return View(userInfo_);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(UserInfo model)
        {
            if (ModelState.IsValid)
            {
                userInfo_.UserFirstName = model.UserFirstName;
                userInfo_.UserLastName = model.UserLastName;
                userInfo_.Age = model.Age;
                userInfo_.Address = model.Address;
                userInfo_.EmailAddress = model.EmailAddress;
                userInfo_.PhoneNumber = model.PhoneNumber;
                context_.userInfos.Update(userInfo_);
                context_.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
