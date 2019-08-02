using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace bbc_Login_Tests
{
    public class TestFunctions
    {
        
        public static IWebDriver InitChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://account.bbc.com/signin";

            return driver;
        }

        public void ButtonClickById(string id, IWebDriver driver)
        {
            driver.FindElement(By.Id(id)).Click();
        }

        public void ButtonClickByClass(string classname, IWebDriver driver)
        {
            driver.FindElement(By.ClassName(classname)).Click();
        }

        public void EnterInputById(string id, IWebDriver driver, string text)
        {
            IWebElement element = driver.FindElement(By.Id(id));

            element.Click();

            element.SendKeys(text);
        }

        public void EnterInputByClass(string classname, IWebDriver driver, string text)
        {
            IWebElement element = driver.FindElement(By.ClassName(classname));

            element.Click();

            element.SendKeys(text);
        }

        public string MessageReader(string id, IWebDriver driver, string classname)
        {
            IWebElement element = driver.FindElement(By.ClassName(classname));
            string innerText = element.Text;

            return innerText;
        }
    }
}
