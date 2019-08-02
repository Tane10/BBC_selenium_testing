using System;

using TechTalk.SpecFlow;

namespace bbc_Login_Tests
{
    [Binding]
    public class SignUp
    {
        #region User has no login credentials 
        [Given("User has no login credentials")]
        public void Userhasnologincredentials(string details)
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

        [When("user click on Regsiter now link")]
        public void userclickonRegsiternowlink(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("it should take them to register screen")]
        public void itshouldtakethemtoregisterscreen(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region Useris under 13 and needs to sign up
        [Given("Useris under 13 and needs to sign up")]
        public void Userisunder13andneedstosignup(string details)
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

        [Given("user clicks on under 13 button")]
        public void userclicksonunder13button(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [When("is taken to page requesting parent or gadient email")]
        public void istakentopagerequestingparentorgadientemail(string id)
        {
            ScenarioContext.Current.Pending();
        }

        [Then("parent enters email adress and starts the sign up process")]
        public void parententersemailadressandstartsthesignupprocess(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User is over 13 
        [Given("User is over 13 ")]
        public void Userisover13(string details)
        {
            // TODO: implement arrange (recondition) logic
            // For storing and retrieving scenario-specific data, 
            // the instance fields of the class or the


        
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            ScenarioContext.Current.Pending();
        }

        [When("user click on over 13 button")]
        public void userclickonover13button(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("it should take them to register screen")]
        public void itshouldtakethemtoregisterscreenover13(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User is presented with DOB boxes
        [Given("User is presented with DOB boxes")]
        public void UserispresentedwithDOBboxes(string details)
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

        [When("user enters charectors instead of numbers and clicks continue ")]
        public void userenterscharectorsinsteadofnumbersandclickscontinue(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("they should be present with a red warning box explaing the correct format Oops, that date doesn't look right. Make sure it's a real date written as DD - MM - YYYY e.g.the 5th of June 2009 is 05 - 06 - 2009.")]
        public void Oopsthatdatedoesntlookright(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User enter their DOB in correct formate but doesn't make them over 13 
        [Given("User enter their DOB in correct formate but doesn't make them over 13")]
        public void UserentertheirDOBincorrectformatebutdoesntmakethemover13(string details)
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

        [When("user click on continue")]
        public void userclickoncontinue(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("it should show a message stating that there under the age of 13 Sorry, you need to be 13 or over.")]
        public void undertheageof13Sorryyouneedtobe13orover(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User enter their DOB in correct formate and is over 13
        [Given("User enter their DOB in correct formate and is over 13")]
        public void Userhasntenteredanyusernameorpassword(string details)
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

        [When("user click on continue")]
        public void userclickoncontinuecorrectover13(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("it takes user to Register with the BBC screen asking for more details")]
        public void ittakesusertoRegisterwiththeBBCscreenaskingformoredetails(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User enters a word for email, enters a password too short and a postcode that is too short
        [Given("User enters a word for email, enters a password too short and a postcode that is too short")]
        public void Userentersawordforemailentersapasswordtooshortandapostcodethatistooshort(string details)
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
        public void userclicksregisterFailed(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("it should fail and tell then that the password is too short, passcode is too short and the email doesn't look like a real email address")]
        public void tellthenthatthepasswordtooshortpasscodeistooshort(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User enters a correct email address, a password only containing letters and an invaild postcode
        [Given("User enters a correct email address, a password only containing letters and an invaild postcode")]
        public void Userentersacorrectemailaddressapasswordonlycontaininglettersandaninvaildpostcode(string details)
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
        public void userclicksregisterletteronlypassword(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("its fails and informs that Sorry, that password isn't valid. Please include something that isn't a letter. and Sorry, that postcode isn't valid. Please check it's a proper postcode")]
        public void passwordisntvaildpostcodeinvailed(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User enter all correct registration details 
        [Given("User enter all correct registration details ")]
        public void allcorrectdetails(string details)
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
        public void userclicksregisterpassed(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("taken to the next page")]
        public void takentothenextpage(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

    }
}
