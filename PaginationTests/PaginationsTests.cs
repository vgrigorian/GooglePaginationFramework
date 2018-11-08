using System;
using GooglePaginationFramework;
using GooglePaginationFramework.Pages;
using GooglePaginationFramework.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaginationTests
{
    [TestClass]
    public class PaginationsTests
    {
        [TestMethod]
        public void GoToTheLoginPage()
        {
            //Get to the home page
            LoginPage.Goto();
            //Verify the the browser is on the gmail login page
            Assert.IsTrue(LoginPage.IsAt());
        }

        //Close the browser
        [TestCleanup]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}