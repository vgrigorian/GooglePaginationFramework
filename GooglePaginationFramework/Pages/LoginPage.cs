using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GooglePaginationFramework.Selenium;

namespace GooglePaginationFramework.Pages
{
    public static class LoginPage
    {
        static string Url = "https://www.google.com/intl/en/gmail/about/";

        //The title of the gmail login page
        private static string PageTitle = "Gmail - Free Storage and Email from Google";

        //Ask webdriver get to the gmail login page
        public static void Goto()
        {
            Driver.Goto(Url);
        }

        //Verify that is the login page is loaded
        public static bool IsAt()
        {
            return Driver.Title == PageTitle;
        }
    }
}
