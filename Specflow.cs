using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BbcSignInTests
{
    public class Specflow
    {
        public Specflow()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://account.bbc.com/signin";
        }
    }
}



