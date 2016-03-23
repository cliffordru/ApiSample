using ApiSample.Services.CommandModel;

namespace ApiSample.Services.BusinessLogicServices.Interfaces
{
    public interface IFavoriteCreationService
    {
        void CreateFavorite(FavoriteCreationSpec favoriteToCreate);
    }
}
