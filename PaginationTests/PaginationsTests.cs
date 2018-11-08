using System;
using GooglePaginationFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaginationTests
{
    [TestClass]
    public class PaginationsTests
    {
        [TestMethod]
        public void GoToTheLoginPage()
        {
            //Get to the home page and
            Pages.LoginPage.Goto();
            Assert.IsTrue(Pages.LoginPage.IsAt());
        }

        [TestCleanup]
        public void CleanUp()
        {
            //Close up the browser
            Browser.Close();
        }
    }
}