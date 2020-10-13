using Movie_App.Models;
using Remotion.Linq.Parsing.Structure.IntermediateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_App
{
    public static class StaticDb
    {
        public static List<Movie> GetAllMovies()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Id = 1,
                    Name = "The silence of the lambs",
                    Gendre = "Horror",
                    Duration = 118,
                    Artists = new List<string>()
                    {
                        "Jodie Foster",
                        "Anthony Hopkins",
                        "Scott Glenn",
                        "Ted Levine",
                        "Ted Levine"
                    }
                },

                new Movie()
                {
                    Id = 2,
                    Name = "The Irishman",
                    Gendre = "Crime",
                    Duration = 209,
                    Artists = new List<string>()
                    {
                        "Robert De Niro",
                        "Al Pacino",
                        "Joe Pesci",
                        "Ray Romano",
                        "Bobby Cannavale",
                        "Anna Paquin"
                    }
                },

                new Movie()
                {
                    Id = 3,
                    Name = "Avengers : Endgame",
                    Gendre = "Superhero",
                    Duration = 181,
                    Artists = new List<string>()
                    {
                        "Robert Downey Jr.",
                        "Chris Evans",
                        "Mark Ruffalo",
                        "Chris Hemsworth",
                        "Scarlett Johansson",
                        "Jeremy Renner",
                        "Don Cheadle",
                        "Paul Rudd"
                    }
                }
            };
        }
    }
}
