using Fiver.Api.Paging.Lib;
using System.Collections.Generic;

namespace Fiver.Api.Paging.OtherLayers
{
    public interface IMovieService
    {
        PagedList<Movie> GetMovies(PagingParams pagingParams);
    }
}
