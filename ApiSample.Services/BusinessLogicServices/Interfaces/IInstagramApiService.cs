using ApiSample.Services.DomainModel.Instragram;

namespace ApiSample.Services.BusinessLogicServices.Interfaces
{
    public interface IInstagramApiService
    {
        InstaPostsRoot GetPostsByTag(string tag);

        InstaPostRoot GetPost(string instagramId);

    }
}
