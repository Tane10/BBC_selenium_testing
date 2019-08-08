using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace bbc_Login_Tests
{
    [Binding]
    public class SignUp
    {

        public IWebDriver driver = new ChromeDriver();

        #region test functions
        public IWebDriver InitChrome()
        {

            driver.Url = "https://account.bbc.com/register?context=HOMEPAGE&nonce=lzmqOnpN-6_UY3zHemC6aQTY_d-B0H7uXDvA&ptrt=https%3A%2F%2Fwww.bbc.co.uk%2F&userOrigin=HOMEPAGE_PS";
            return driver;

        }

        public IWebDriver InitChromeOVer13()
        {

            driver.Url = "https://account.bbc.com/register/details/age?context=HOMEPAGE&nonce=T0z2BmRJ-5tbbnTFmLDb2AEs-lpguiECPyq8&ptrt=https%3A%2F%2Fwww.bbc.co.uk%2F&userOrigin=HOMEPAGE_PS";
            return driver;

        }

        public void DriverCloseQuit()
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


        public bool MessageReaderById(IWebDriver driver, string id, string equalString)
        {
            IWebElement element = driver.FindElement(By.Id(id));
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

        public void ClickXpath(IWebDriver driver, string xpath)
        {
            //, bool shouldWait,int time = 0
            IWebElement element = driver.FindElement(By.XPath(xpath));
            

            //if (shouldWait == true && time != 0)
            //{
            //    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));

            //    element.Click();


            //    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeout));
            //    return wait.Until(ExpectedConditions.ElementExists(elementLocator));
            //}
            //else
            //{


            //    element.Click();

            //}

            //var element = Driver.FindElement(elementLocator);
            element.Click();
            //wait.Until(ExpectedConditions.StalenessOf(element));

        }


        public bool IsItemDisplayedXpath(IWebDriver driver, string xpath)
        {
            bool isElementDisplayed = driver.findElement(By.xpath("element")).isDisplayed();
            return isElementDisplayed;
        }
        #endregion





        #region Useris under 13 and needs to sign up
        [Given("Useris under 13 and needs to sign up")]
        public void Userisunder13andneedstosignup()
        {
            InitChrome();

        }

        [Given("user clicks on under 13 button")]
        public void userclicksonunder13button()
        {

            ClickXpath(driver, "//span[@aria-label='Under 13']");
            
        }

        [When("is taken to page requesting parent or gadient email")]
        public void istakentopagerequestingparentorgadientemail()
        {
            string pageUrl = "https://account.bbc.com/register/details/guardian?context=HOMEPAGE&nonce=kUUTTY6k-a8h2dsR1d1bWTjYuoKQMqmijReo&ptrt=https%3A%2F%2Fwww.bbc.co.uk%2F&userOrigin=HOMEPAGE_PS";
            string url = this.driver.Url;
            if(url == pageUrl)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("wrong");
            }
        }

        [Then("parent enters email adress and starts the sign up process")]
        public void parententersemailadressandstartsthesignupprocess()
        {

            EnterInputByClass("email - input", driver, "mummay@gmial.com");
            ButtonClickById("submit-button", driver);
            DriverCloseQuit();

            
        }
        #endregion

        #region User is over 13 
        [Given("User is over 13 ")]
        public void Userisover13()
        {
            InitChromeOVer13();
   
        }

        [When("user click on over 13 button")]
        public void userclickonover13button()
        {
            ClickXpath(driver, "//*[@aria-label='13 or over']");
        }

        [Then("it should take them to register screen")]
        public void itshouldtakethemtoregisterscreenover13()
        {
            string pageUrl = "https://account.bbc.com/register/details/age?context=HOMEPAGE&nonce=kUUTTY6k-a8h2dsR1d1bWTjYuoKQMqmijReo&ptrt=https%3A%2F%2Fwww.bbc.co.uk%2F&userOrigin=HOMEPAGE_PS";
            string url = this.driver.Url;
            if (url == pageUrl)
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("wrong");
            }
        }
        #endregion

        #region User is presented with DOB boxes
        [Given("User is presented with DOB boxes")]
        public void UserispresentedwithDOBboxes()
        {
            InitChromeOVer13();
            System.Threading.Thread.Sleep(1000);
            ClickXpath(driver, "//*[@aria-label='13 or over']");
            //ClickXpath(driver, "//*[@href='https://account.bbc.com/register/details/age?context=HOMEPAGE']");
        


        }
        [When(@"user enters charectors instead of numbers and clicks continue")]
        public void WhenUserEntersCharectorsInsteadOfNumbersAndClicksContinue()
        {
            EnterInputById("year - input", driver, "one");
            EnterInputById("month - input", driver, "jun");
            EnterInputById("day - input", driver, "mon");

        }


        [Then(@"they should be present with a red warning box explaing the correct format ""(.*)""")]
        public void ThenTheyShouldBePresentWithARedWarningBoxExplaingTheCorrectFormat(string p0)
        {
            MessageReaderByClass(driver, "form-message__text", "Oops, that date doesn't look right. Make sure it's a real date written as DD-MM-YYYY e.g. the 5th of June 2009 is 05-06-2009.");
            DriverCloseQuit();
        }

        #endregion

        #region User enter their DOB in correct formate but doesn't make them over 13 
        [Given("User enter their DOB in correct formate but doesn't make them over 13")]
        public void UserentertheirDOBincorrectformatebutdoesntmakethemover13()
        {
            InitChromeOVer13();
            EnterInputById("year - input", driver, "one");
            EnterInputById("month - input", driver, "jun");
            EnterInputById("day - input", driver, "mon");
        }

        [When("user click on continue")]
        public void userclickoncontinue()
        {
            ButtonClickById("submit-button",driver);
        }

        [Then("it should show a message stating that there under the age of 13 Sorry, you need to be 13 or over.")]
        public void undertheageof13Sorryyouneedtobe13orover()
        {
            MessageReaderByClass(driver, "form-message__text", "Sorry, you need to be 13 or over.");
            DriverCloseQuit();
        }
        #endregion

        #region User enter their DOB in correct formate and is over 13
        [Given("User enter their DOB in correct formate and is over 13")]
        public void Userhasntenteredanyusernameorpassword()
        {
            InitChromeOVer13();
            EnterInputById("year - input", driver, "1995");
            EnterInputById("month - input", driver, "7");
            EnterInputById("day - input", driver, "10");
        }

        [When("user click on continue")]
        public void userclickoncontinuecorrectover13()
        {
            ButtonClickById("submit-button", driver);
        }

        [Then("it takes user to Register with the BBC screen asking for more details")]
        public void ittakesusertoRegisterwiththeBBCscreenaskingformoredetails()
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User enters a word for email, enters a password too short and a postcode that is too short
        [Given("User enters a word for email, enters a password too short and a postcode that is too short")]
        public void Userentersawordforemailentersapasswordtooshortandapostcodethatistooshort()
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

        [When("user clicks register")]
        public void userclicksregisterFailed()
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("it should fail and tell then that the password is too short, passcode is too short and the email doesn't look like a real email address")]
        public void tellthenthatthepasswordtooshortpasscodeistooshort()
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User enters a correct email address, a password only containing letters and an invaild postcode
        [Given("User enters a correct email address, a password only containing letters and an invaild postcode")]
        public void Userentersacorrectemailaddressapasswordonlycontaininglettersandaninvaildpostcode()
        {
            // TODO: implement arrange (recondition) logic
            // For storing and retrieving scenario-specific data, 
            // the instance fields of the class or the



            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            ScenarioContext.Current.Pending();
        }

        [When("user clicks register")]
        public void userclicksregisterletteronlypassword()
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("its fails and informs that Sorry, that password isn't valid. Please include something that isn't a letter. and Sorry, that postcode isn't valid. Please check it's a proper postcode")]
        public void passwordisntvaildpostcodeinvailed()
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User enter all correct registration details 
        [Given("User enter all correct registration details ")]
        public void allcorrectdetails()
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
        public void userclicksregisterpassed()
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("taken to the next page")]
        public void takentothenextpage()
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

    }
}
