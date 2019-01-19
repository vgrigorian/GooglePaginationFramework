using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace GooglePaginationFramework.Selenium
{
    public class Browser
    {
        //Initialize the webdriver
        static IWebDriver webDriver = new FirefoxDriver();

        /*//if can't find elements, try to wait 10 seconds for load 
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);*/

        static string Url = "https://www.google.com/intl/en/gmail/about/";

        private static string HomePageTitle = "Gmail - Free Storage and Email from Google";
        private static string LoginPageTitle = "Gmail";
        private static string InboxPageTitle = "Inbox - testcsharp99@gmail.com - Gmail";


        //Ask webdriver to open provided url
        public static void GoToHomePage()
        {
            webDriver.Url = Url;
        }

        //Ask webdriver to get the title of the webpage
        public static string Title
        {
            get { return webDriver.Title; }
        }

        //Ask webdriver to get webpage title and compare it to the home page title
        public static bool IsAt()
        {
            return webDriver.Title == HomePageTitle;
        }


        //Find and click on the SignIn button
        public static void GoToLoginPage()
        {
            var signIn = webDriver.FindElements(By.CssSelector(".gmail-nav__nav-link"))[1];
            signIn.Click();
        }


        //Ask webdriver to get title and compare it to the login page title
        public static bool IsAtLoginPage()
        {
            return webDriver.Title == LoginPageTitle;
        }

        //Login to account
        public static void LoginToAccount()
        {
            //Find the login field and enter the data
            var enterLogin = webDriver.FindElement(By.CssSelector("#identifierId"));
            enterLogin.SendKeys("testmail);

            //Click "Next" button
            var nextButton = webDriver.FindElement(By.CssSelector("#identifierNext > content:nth-child(3)"));
            nextButton.Click();

            System.Threading.Thread.Sleep(1000);

            //Fing password field and enter password
            var enterPassword = webDriver.FindElement(By.XPath("//div[@id='password']//input"));
            enterPassword.SendKeys("testpassword");

            //Click "Next" button
            var nextButton2 = webDriver.FindElement(By.CssSelector(".DL0QTb"));
            nextButton2.Click();
        }


        //Ask webdriver get the title and compare it to the inbox title
        public static bool IsAtInboxPage()
        {
            return webDriver.Title == InboxPageTitle;
        }

        //The function is closing the browser
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
