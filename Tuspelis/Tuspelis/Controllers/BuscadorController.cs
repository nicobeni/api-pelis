using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tuspelis.Models;
using Tuspelis.Services;

namespace Tuspelis.Controllers
{
    public class BuscadorController : Controller
    {
       
        
        [Route("/Buscador/ver")]
        public async Task<IActionResult> Index(string query)
        {
            PeliculasServices peliculasService = new PeliculasServices();
            Buscador peliculasBuscadas = await peliculasService.buscadorPorQuery(query,1);
            System.Diagnostics.Debug.WriteLine(peliculasBuscadas);
            return View(peliculasBuscadas); 

        }
    }
}
