
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

        public string MessageReader(IWebDriver driver, string classname)
        {
            IWebElement element = driver.FindElement(By.ClassName(classname));
            string innerText = element.Text;
            Console.WriteLine(innerText); 

            return innerText;
        }

        #endregion



        #region User hasn't entered any username or password
        [Given("User hasn't entered any username or password")]
        public void Userhasntenteredanyusernameorpassword() => InitChrome();

        [When("User clickes sign in button")]
        public void Userclickessigninbutton() =>
            ButtonClickById("submit-button", driver);

        [Then("3 red boxes with text should show on page two stating Something's missing. Please check and try again. one saying Sorry, those details don't match.Check you've typed them correctly.")]
        public void redboxeswithtextshouldshow()
        {
            // TODO: implement assert (verification) logic

            MessageReader(driver, "form-message__text");
            driver.Quit();
        }
        #endregion

        #region User enters incorrect email or username with no password
        [Given("User enters incorrect email or username with no password")]
        public void Userentersincorrectemailorusernamewithnopassword(string details)
        {
            // TODO: implement arrange (recondition) logic
            // For storing and retrieving scenario-specific data, 
            // the instance fields of the class or the
            //     ScenarioContext.Current
            // collection can be used.
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            ScenarioContext.Current.Pending();
        }

        [When("User clickes sign in button")]
        public void clickessigninbuttonincorrectcreds(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("two red boxes will show password related stating Something's missing. Please check and try again. and top message above username saying Sorry, those details don't match.Check you've typed them correctly.")]
        public void tworedboxeswillshowpasswordrelated(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region Sign in with non-regestored email and wrong password
        [Given("Sign in with non-regestored email and wrong password")]
        public void Signinwithnonregestoredemailandwrongpassword(string details)
        {
            // TODO: implement arrange (recondition) logic
            // For storing and retrieving scenario-specific data, 
            // the instance fields of the class or the
            //     ScenarioContext.Current
            // collection can be used.
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            ScenarioContext.Current.Pending();
        }

        [When("User clickes sign in button")]
        public void Userclickessigninbuttonnonregestored(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("One box appers under the username saying Sorry, we can’t find an account with that email.You can register for a new account or get help here.")]
        public void oneboxappersundertheusername(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region Sign in with regestored email and short password
        [Given("Sign in with regestored email and short password")]
        public void Userentersregestoredemailashortpassword(string details)
        {
            // TODO: implement arrange (recondition) logic
            // For storing and retrieving scenario-specific data, 
            // the instance fields of the class or the
            //     ScenarioContext.Current
            // collection can be used.
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            ScenarioContext.Current.Pending();
        }

        [When("User clickes sign in button")]
        public void Userclickessigninbuttonregemailshortps(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("message is shown below password box saying Sorry, that password is too short.It needs to be eight characters or more.")]
        public void messageisshownbelowpasswordboxsayingSorry(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

    }
}
