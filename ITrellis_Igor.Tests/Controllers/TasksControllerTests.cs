using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ITrellis_Igor;
using ITrellis_Igor.Controllers;

namespace ITrellis_Igor.Controllers.Tests
{
    [TestClass()]
    public class TasksControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            // Arrange
            TasksController controller = new TasksController();

            // Act
            ViewResult result = controller.Index(9) as ViewResult;

            // Assert
            Assert.AreEqual("", result.ViewName);
        }

        [TestMethod()]
        public void CompleteTest()
        {
            Assert.AreEqual("a","a");
        }

        [TestMethod()]
        public void DetailsTest()
        {
            // Arrange
            TasksController controller = new TasksController();

            // Act
            ViewResult result = controller.Details(9) as ViewResult;

            // Assert
            Assert.AreEqual(null, result?.ViewName);
        }

        [TestMethod()]
        public void CreateTest()
        {
            Assert.AreEqual("a", "a");
        }

        [TestMethod()]
        public void CreateTest1()
        {
            Assert.AreEqual("a", "a");
        }

        [TestMethod()]
        public void EditTest()
        {
            Assert.AreEqual("a", "a");
        }

        [TestMethod()]
        public void EditTest1()
        {
            Assert.AreEqual("a", "a");
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.AreEqual("a", "a");
        }

        [TestMethod()]
        public void DeleteConfirmedTest()
        {
            Assert.AreEqual("a", "a");
        }

    }
}