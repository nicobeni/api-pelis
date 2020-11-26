 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tuspelis.Models;
using Tuspelis.Services;

namespace Tuspelis.Controllers
{
    [Route("/PeliculaDetalle")] 
    public class PeliculasDetalleController : Controller
    {
        [Route("/PeliculaDetalle/ver/{id}")]
        public async Task<IActionResult> IndexAsync(int id)
        {
            PeliculasServices peliculasService = new PeliculasServices();
            PeliculaDetalle peliculaDetalle = await peliculasService.obtenerDetallePorIdAsync(id);
            return View("IndexAsync", peliculaDetalle);
        }
    }
}
