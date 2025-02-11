﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tuspelis.Models;
using System.Net.Http;

using Tuspelis.Services;

namespace Tuspelis.Controllers
{
    public class HomeController : Controller
    {

 
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<ActionResult>  Index()
        {

            PeliculasServices peliculasService = new PeliculasServices();
            PeliculasPopulares peliculasPopulares = await peliculasService.obtenerPeliculasPopulares();
   
            return View(peliculasPopulares);
            

            //return View();
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
