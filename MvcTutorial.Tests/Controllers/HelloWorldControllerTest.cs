using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcTutorial;
using MvcTutorial.Controllers;

namespace MvcTutorial.Tests.Controllers
{
    [TestClass]
    public class HomeWorldControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HelloWorldController controller = new HelloWorldController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Index", result.ViewBag.Message);
        }
    }
}
