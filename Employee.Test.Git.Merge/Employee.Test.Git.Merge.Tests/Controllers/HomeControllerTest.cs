using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Employee.Test.Git.Merge;
using Employee.Test.Git.Merge.Controllers;
using Employee.Test.Git.Merge.Repositories;
using Employee.Test.Git.Merge.Services;
using Moq;

namespace Employee.Test.Git.Merge.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMerge()
        {
            var service = new TestService(new TestRepository());

            var validData = new List<string>()
            {
                "VALID-4",
                "VALID-5",
                "VALID-6",
                "VALID-7",
                "VALID-8"
            };

            var actualData = service.GetData();
            for (int i = 0; i < validData.Count; i++)
            {
                Assert.AreEqual(actualData[i], validData[i]);
            }
        }
    }
}
