﻿using System;
using TheWorld.Services;
using Microsoft.AspNet.Mvc;
using TheWorld.ViewModels;

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
        {
        private IMailService _mailService;

        public AppController(IMailService service)
        {
            _mailService = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var email = Startup.Configuration["AppSettings:SiteEmailAddress"];
                if(string.IsNullOrWhiteSpace(email))
                {
                    ModelState.AddModelError("", "Could not send email configuration problem");
                }
                if(_mailService.SendMail(email, email,
                $"Contact Page Form {model.Name} ({model.Email})",
                model.Message))
                {
                    ModelState.Clear();
                    ViewBag.Message = "Message sent ...Thanks";
                }
            }

                           
            return View();
        }
    }
}