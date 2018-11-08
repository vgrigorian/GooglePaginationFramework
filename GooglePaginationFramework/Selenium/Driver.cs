using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace GooglePaginationFramework.Selenium
{
    public static class Driver
    {
        //Initialize the webdriver
        static IWebDriver webDriver = new FirefoxDriver();

        //Ask webdriver to get the title of the login page
        public static string Title
        {
            get { return webDriver.Title; }
        }

        //Ask webdriver to load the gmail login page
        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        //The function is closing the browser
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
