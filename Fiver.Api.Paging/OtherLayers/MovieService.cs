using System.Collections.Generic;
using System.Linq;

namespace Fiver.Api.Paging.OtherLayers
{
    public class MovieService : IMovieService
    {
        private readonly List<Movie> movies;

        public MovieService()
        {
            this.movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "Never Say Never Again", ReleaseYear = 1983, Summary = "A SPECTRE agent has stolen two American nuclear warheads, and James Bond must find their targets before they are detonated." },
                new Movie { Id = 2, Title = "Diamonds Are Forever ", ReleaseYear = 1971, Summary = "A diamond smuggling investigation leads James Bond to Las Vegas, where he uncovers an evil plot involving a rich business tycoon." },
                new Movie { Id = 3, Title = "You Only Live Twice ", ReleaseYear = 1967, Summary = "Agent 007 and the Japanese secret service ninja force must find and stop the true culprit of a series of spacejackings before nuclear war is provoked." }
            };
        }

        public List<Movie> GetMovies()
        {
            return this.movies.ToList();
        }
    }
}
