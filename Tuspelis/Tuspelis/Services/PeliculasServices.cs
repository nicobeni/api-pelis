using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tuspelis.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Tuspelis.Services
{
    public class PeliculasServices
    {
        string baseUrl = "https://api.themoviedb.org/3/";
        string key = "ed7f06493c8acefd521b9e5ea16c12c9";
        public async Task<PeliculaDetalle> obtenerDetallePorIdAsync(int id) {

            PeliculaDetalle peliculaDetalle = new PeliculaDetalle();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("movie/"+ id +"?api_key="+ key);
                if (res.IsSuccessStatusCode)
                {
                    var pelisResponse = res.Content.ReadAsStringAsync().Result;
                    peliculaDetalle = JsonConvert.DeserializeObject<PeliculaDetalle>(pelisResponse);

                }

                return peliculaDetalle;
            }

        }

        public async Task<Proximamente> obtenerProximamente()
        {

            Proximamente peliculaProximas = new Proximamente();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("movie/upcoming?api_key=" + key);
                if (res.IsSuccessStatusCode)
                {
                    var pelisResponse = res.Content.ReadAsStringAsync().Result;
                    peliculaProximas = JsonConvert.DeserializeObject<Proximamente>(pelisResponse);

                }

                return peliculaProximas;
            }

        }

        public async Task<PeliculasPopulares> obtenerPeliculasPopulares() {

            PeliculasPopulares peliculasPopulares = new PeliculasPopulares();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("movie/popular?api_key=" + key );
                if (res.IsSuccessStatusCode)
                {
                    var pelisResponse = res.Content.ReadAsStringAsync().Result;
                    peliculasPopulares = JsonConvert.DeserializeObject<PeliculasPopulares>(pelisResponse);

                }
                
                return peliculasPopulares;
            }
        }

        public async Task<MasVotada> obtenerMasVotada()
        {

            MasVotada votadas = new MasVotada();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = await client.GetAsync("movie/upcoming?api_key=" + key);
                if (res.IsSuccessStatusCode)
                {
                    var pelisResponse = res.Content.ReadAsStringAsync().Result;
                    votadas = JsonConvert.DeserializeObject<MasVotada>(pelisResponse);

                }

                return votadas;
            }
        }

        public async Task<Buscador> buscadorPorQuery(string query,int pagina)
        {

            Buscador buscar = new Buscador();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                HttpResponseMessage res = await client.GetAsync("search/movie?query="+ query +"&api_key=" + key);
                if (res.IsSuccessStatusCode)
                {
                    var pelisResponse = res.Content.ReadAsStringAsync().Result;
                    buscar = JsonConvert.DeserializeObject<Buscador>(pelisResponse);

                }

                return buscar;
            }
        }
    }
}
