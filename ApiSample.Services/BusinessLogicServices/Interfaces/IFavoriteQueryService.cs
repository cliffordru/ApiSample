using ApiSample.Services.DomainModel;
using System.Collections.Generic;

namespace ApiSample.Services.BusinessLogicServices.Interfaces
{
    public interface IFavoriteQueryService
    {
        List<Favorite> GetFavorites(string userId);
        List<FavoriteMetric> GetMetrics(string userId);
    }
}
