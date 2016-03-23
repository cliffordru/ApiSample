using ApiSample.Services.DomainModel;

namespace ApiSample.Services.Repositories.Interfaces
{
    public interface IFavoriteRepository
    {
        Favorite Get(string userid, string instagramId, string tagname);
        Post Get(string instagramId);
        void Add(Favorite favorite);
    }
}
