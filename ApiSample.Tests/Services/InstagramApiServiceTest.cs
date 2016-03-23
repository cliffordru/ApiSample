using ApiSample.Services.BusinessLogicServices;
using ApiSample.Services.BusinessLogicServices.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiSample.Tests.Services
{
    [TestClass]
    public class InstagramApiServiceTest
    {
        [TestMethod]
        public void Instagram_api_should_return_tagged_media()
        {
            IInstagramApiService service = new InstagramApiService();
            var media = service.GetPostsByTag("snow");

            Assert.IsNotNull(media);
        }
    }
}
