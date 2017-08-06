using Microsoft.VisualStudio.TestTools.UnitTesting;
using continuousDeployWeb.Controllers;

namespace continuousDeployWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {        
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }
}
