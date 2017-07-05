using Fiver.Api.Paging.Lib;
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
                new Movie { Id = 1, Title = "Dr. No", ReleaseYear = 1962, Summary = "A resourceful British government agent seeks answers in a case involving the disappearance of a colleague and the disruption of the American space program." },
                new Movie { Id = 2, Title = "From Russia with Love", ReleaseYear = 1963, Summary = "James Bond willingly falls into an assassination ploy involving a naive Russian beauty in order to retrieve a Soviet encryption device that was stolen by SPECTRE." },
                new Movie { Id = 3, Title = "Goldfinger", ReleaseYear = 1964, Summary = "Investigating a gold magnate's smuggling, James Bond uncovers a plot to contaminate the Fort Knox gold reserve." },
                new Movie { Id = 4, Title = "Thunderball", ReleaseYear = 1965, Summary = "James Bond heads to The Bahamas to recover two nuclear warheads stolen by SPECTRE agent Emilio Largo in an international extortion scheme." },
                new Movie { Id = 5, Title = "You Only Live Twice", ReleaseYear = 1967, Summary = "Agent 007 and the Japanese secret service ninja force must find and stop the true culprit of a series of spacejackings before nuclear war is provoked." },
                new Movie { Id = 6, Title = "Diamonds Are Forever", ReleaseYear = 1971, Summary = "A diamond smuggling investigation leads James Bond to Las Vegas, where he uncovers an evil plot involving a rich business tycoon." },
                new Movie { Id = 7, Title = "Never Say Never Again", ReleaseYear = 1983, Summary = "A SPECTRE agent has stolen two American nuclear warheads, and James Bond must find their targets before they are detonated." },

                new Movie { Id = 8, Title = "Live and Let Die", ReleaseYear = 1973, Summary = "007 is sent to stop a diabolically brilliant heroin magnate armed with a complex organization and a reliable psychic tarot card reader." },
                new Movie { Id = 9, Title = "The Man with the Golden Gun", ReleaseYear = 1974, Summary = "James Bond is led to believe that he is targeted by the world's most expensive assassin while he attempts to recover sensitive solar cell technology that is being sold to the highest bidder." },
                new Movie { Id = 10, Title = "The Spy Who Loved Me", ReleaseYear = 1977, Summary = "James Bond investigates the hijacking of British and Russian submarines carrying nuclear warheads with the help of a KGB agent whose lover he killed." },
                new Movie { Id = 11, Title = "Moonraker", ReleaseYear = 1979, Summary = "James Bond investigates the mid-air theft of a space shuttle and discovers a plot to commit global genocide." },
                new Movie { Id = 12, Title = "For Your Eyes Only", ReleaseYear = 1981, Summary = "Agent 007 is assigned to hunt for a lost British encryption device and prevent it from falling into enemy hands." },
                new Movie { Id = 13, Title = "A View to a Kill", ReleaseYear = 1985, Summary = "An investigation of a horse-racing scam leads 007 to a mad industrialist who plans to create a worldwide microchip monopoly by destroying California's Silicon Valley." },

                new Movie { Id = 14, Title = "GoldenEye ", ReleaseYear = 1985, Summary = "James Bond teams up with the lone survivor of a destroyed Russian research center to stop the hijacking of a nuclear space weapon by a fellow agent formerly believed to be dead." },
                new Movie { Id = 15, Title = "Tomorrow Never Dies", ReleaseYear = 1997, Summary = "James Bond heads to stop a media mogul's plan to induce war between China and the UK in order to obtain exclusive global media coverage." },
                new Movie { Id = 16, Title = "The World Is Not Enough", ReleaseYear = 1999, Summary = "James Bond uncovers a nuclear plot when he protects an oil heiress from her former kidnapper, an international terrorist who can't feel pain." },
                new Movie { Id = 17, Title = "Die Another Day", ReleaseYear = 2002, Summary = "James Bond is sent to investigate the connection between a North Korean terrorist and a diamond mogul who is funding the development of an international space weapon." },

                new Movie { Id = 18, Title = "Casino Royale", ReleaseYear = 2006, Summary = "Armed with a licence to kill, Secret Agent James Bond sets out on his first mission as 007 and must defeat a weapons dealer in a high stakes game of poker at Casino Royale, but things are not what they seem." },
                new Movie { Id = 19, Title = "Quantum of Solace", ReleaseYear = 2008, Summary = "James Bond descends into mystery as he tries to stop a mysterious organization from eliminating a country's most valuable resource. All the while, he still tries to seek revenge over the death of his love." },
                new Movie { Id = 20, Title = "Skyfall", ReleaseYear = 2012, Summary = "Bond's loyalty to M is tested when her past comes back to haunt her. Whilst MI6 comes under attack, 007 must track down and destroy the threat, no matter how personal the cost." },
                new Movie { Id = 21, Title = "Spectre", ReleaseYear = 2015, Summary = "A cryptic message from Bond's past sends him on a trail to uncover a sinister organization. While M battles political forces to keep the secret service alive, Bond peels back the layers of deceit to reveal the terrible truth behind SPECTRE." },
            };
        }

        public PagedList<Movie> GetMovies(PagingParams pagingParams)
        {
            var query = this.movies.AsQueryable();
            return new PagedList<Movie>(
                query, pagingParams.PageNumber, pagingParams.PageSize);
        }
    }
}
