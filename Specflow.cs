using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BbcSignInTests
{
    public class Specflow
    {
        public static void Main()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://account.bbc.com/signin";
        }
    }
}



