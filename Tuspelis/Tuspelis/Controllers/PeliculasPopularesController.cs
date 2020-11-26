using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using Tuspelis.Models;

namespace Tuspelis.Controllers
{
    public class PeliculasPopularesController : Controller
    {
        string baseUrl = "https://api.themoviedb.org/3/";

        public async Task<ActionResult> Index() {

            PeliculasPopulares peliculasPopulares = new PeliculasPopulares();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("movie/popular?api_key=ed7f06493c8acefd521b9e5ea16c12c9");
                if (res.IsSuccessStatusCode)
                {
                    var pelisResponse = res.Content.ReadAsStringAsync().Result;
                    peliculasPopulares = JsonConvert.DeserializeObject<PeliculasPopulares>(pelisResponse);

                }
                Console.WriteLine(peliculasPopulares);
                return View(peliculasPopulares);
            }
        }
    }
}
