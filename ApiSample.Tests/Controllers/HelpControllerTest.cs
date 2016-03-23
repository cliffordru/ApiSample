using ApiSample.Areas.HelpPage.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ApiSample.Tests.Controllers
{
    [TestClass]
    public class HelpControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HelpController();

            // Act
            var result = controller.Response;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
