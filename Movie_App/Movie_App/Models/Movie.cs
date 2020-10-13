using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_App.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gendre { get; set; }
        public int Duration { get; set; }
        public List<string> Artists { get; set; }
    }
}
