﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuspelis.Models
{
    public class PeliculaDetalle
    {

       public bool adult { get; set; }

       public string backdrop_path { get; set; }

        public Coleccion belongs_to_collection { get; set; }

        public int budget { get; set; }

        public List<Genero> genres { get; set; }

        public string imdb_id { get; set; }

        public string original_language { get; set; }

        public string original_title { get; set; }

        public string overview { get; set; }

        public double popularity { get; set; }

        public string poster_path { get; set; }

        public List<CompaniaProduccion> production_companies { get; set; }

        public List<PaisProduccion> production_countries { get; set; }

        public string release_date { get; set; }

        public int revenue { get; set; }

        public int runtime { get; set; }

        public List<Lenguaje> spoken_languages { get; set; }

        public string  status { get; set; }
 

        public string tagline { get; set; }
        public string title { get; set; }

        public bool video { get; set; }

        public double vote_average { get; set; }

        public int vote_count { get; set; }


    }
}
