using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tuspelis.Models;
using Tuspelis.Services;

namespace Tuspelis.Controllers
{
    [Route("Proximamente")]
    public class PeliculasProximamenteController : Controller
    {

        [Route("/Proximamente/ver")]
        public async Task<IActionResult> Index()
        {
            PeliculasServices peliculasService = new PeliculasServices();
            Proximamente peliculaProximas = await peliculasService.obtenerProximamente();
            return View(peliculaProximas);
        }
    }
}
