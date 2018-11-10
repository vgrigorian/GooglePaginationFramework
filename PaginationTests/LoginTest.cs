using System;
using GooglePaginationFramework;
using GooglePaginationFramework.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaginationTests
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void GoToTheHomePage()
        {
            //Get to the home page
            Browser.GoToHomePage();

            //Verify the browser is on the gmail home page
            Assert.IsTrue(Browser.IsAt());
        }

        [TestMethod]
        public void GoToTheLoginPage()
        {
            //Get to the login page
            Browser.GoToLoginPage();

            //Verify the browser is on the login page
            Assert.IsTrue(Browser.IsAtLoginPage());
        }

        [TestMethod]
        public void LoginToAccount()
        {
            //Get to the inbox
            Browser.LoginToAccount();

            //Verify the browser is on the inbox page
            Assert.IsTrue(Browser.IsAtInboxPage());
        }

        /*[TestCleanup]
        public void CleanUp()
        {
            //Close browser
            Browser.Close();
        }*/
    }
}