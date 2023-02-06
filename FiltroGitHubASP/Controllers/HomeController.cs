﻿using FiltroGitHubASP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FiltroGitHubASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }




        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MeusRepos()
        {
            return View();
        }

        public ActionResult PesquisaRepos()
        {
            return View();
        }

    }
}