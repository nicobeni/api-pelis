using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tuspelis.Models;
using Tuspelis.Services;

namespace Tuspelis.Controllers
{
    public class MasVotadaController : Controller
    {
       

        [Route("/MasVotadas/ver")]
        public async Task<IActionResult> Index()
        {
            PeliculasServices peliculasService = new PeliculasServices();
            MasVotada masVotada = await peliculasService.obtenerMasVotada();
            return View(masVotada);
        }
    }
}
