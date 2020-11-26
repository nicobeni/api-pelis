using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuspelis.Models
{
    public class Buscador
    {
        public int page { get; set; }
        public int total_pages { get; set; }
        public List<Pelicula> results { get; set; }
        public int total_results { get; set; }

    }
}
