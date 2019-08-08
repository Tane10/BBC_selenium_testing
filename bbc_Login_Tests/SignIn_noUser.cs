
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace bbc_Login_Tests
{
    [Binding]
    public class SignIn_noUser
    {
        public IWebDriver driver = new ChromeDriver();
        
        #region test functions
        public IWebDriver InitChrome()
        {
            
            driver.Url = "https://account.bbc.com/signin";
            return driver;

        }

        public void  DriverCloseQuit()
        {
            driver.Close();
            driver.Quit();
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


        public bool MessageReaderById(IWebDriver driver, string id,string equalString)
        {
            IWebElement element = driver.FindElement(By.Id(id));
            string innerText = element.Text;
            bool textMatch = true;
            bool textNotMatch = false;
            Console.WriteLine(equalString);

            if(innerText == equalString)
            {

                return textMatch;
            }
            else
            {
                return textNotMatch;
            }
        }


        public bool MessageReaderByClass(IWebDriver driver, string classname, string equalString)
        {
            IWebElement element = driver.FindElement(By.ClassName(classname));
            string innerText = element.Text;
            bool textMatch = true;
            bool textNotMatch = false;
            Console.WriteLine(equalString);

            if (innerText == equalString)
            {

                return textMatch;
            }
            else
            {
                return textNotMatch;
            }
        }
        #endregion



        #region User hasn't entered any username or password
        [Given("User hasn't entered any username or password")]
        public void Userhasntenteredanyusernameorpassword() => InitChrome();

        [When(@"User clickes sign in button with no infomation")]
        public void WhenUserClickesSignInButtonWithNoInfomation()
        {
            ButtonClickById("submit-button", driver);
        }

        [Then(@"(.*) red boxes with text should show on page two stating ""(.*)"" one saying ""(.*)""")]
        public void ThenRedBoxesWithTextShouldShowOnPageTwoStatingOneSaying(int p0, string p1, string p2)
        {
            MessageReaderById(driver, "form-message-username", "Something's missing. Please check and try again.");
            DriverCloseQuit();

        }
       
        #endregion

        
        #region User enters incorrect email or username with no password
        [Given("User enters incorrect email or username with no password")]
        public void Userentersincorrectemailorusernamewithnopassword()
        {
            InitChrome();
            EnterInputByClass("field__input", driver, "jeff");

        }

        [When(@"User clickes sign in button with no pass and wrong email")]
        public void WhenUserClickesSignInButtonWithNoPassAndWrongEmail()
        {
            ButtonClickById("submit-button", driver);
        }

        [Then(@"two red boxes will show password related stating ""(.*)"" and top message above username saying ""(.*)""")]
        public void ThenTwoRedBoxesWillShowPasswordRelatedStatingAndTopMessageAboveUsernameSaying(string p0, string p1)
        {
            MessageReaderById(driver, "form-message-general", "Something's missing. Please check and try again.");
            DriverCloseQuit();
        }

        #endregion

        #region Sign in with non-regestored email and wrong password
        [Given(@"User enters non-regestored email with a password")]
        public void GivenUserEntersNon_RegestoredEmailWithAPassword()
        {
            InitChrome();
            EnterInputByClass("field__input", driver, "jeff.test@gmail.com");
            EnterInputById("password-input", driver, "apple");
       
        }

        [When(@"User clickes sign in button with non-regestored email and wrong password")]
        public void WhenUserClickesSignInButtonWithNon_RegestoredEmailAndWrongPassword()
        {
            ButtonClickById("submit-button", driver);
        }


        [Then(@"One box appers under the username saying ""(.*)""")]
        public void ThenOneBoxAppersUnderTheUsernameSaying(string p0)
        {

            MessageReaderByClass(driver, "form-message__text", "Sorry, that password is too short.It needs to be eight characters or more.");
            DriverCloseQuit();

            
        }
        #endregion

        #region Sign in with regestored email and short password


        [Given(@"User enters regestored email with a short password")]
        public void GivenUserEntersRegestoredEmailWithAShortPassword()
        {
            InitChrome();
            EnterInputByClass("field__input", driver, "j.thomas.gmail.com");
            EnterInputById("password-input", driver, "apple");
        }

        [When(@"User clickes sign in button with regestored email and short password")]
        public void WhenUserClickesSignInButtonIwithRegestoredEmailAndShortPassword()
        {
            ButtonClickById("submit-button", driver);
        }

        [Then(@"message is shown below password box saying ""(.*)""")]
        public void ThenMessageIsShownBelowPasswordBoxSaying(string p0)
        {
            MessageReaderByClass(driver, "form-message__text", "Sorry, that password is too short.It needs to be eight characters or more.");
            MessageReaderById(driver, "form-message-username", "Usernames can only include... Letters, numbers and these characters: ?/|}{+=_-^~`%$#");
            DriverCloseQuit();
        }
        #endregion

    }

    internal class SelectElement
    {
    }
}
