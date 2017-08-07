using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OdeToFood.Controllers;

namespace OdeToFoodTest
{
    [TestClass]
    public class HomeControllerIndexTests
    {
        [TestMethod]
        public void Puts_Message_In_ViewBag()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsNotNull(result.ViewBag.Message);
        }
    }
}
