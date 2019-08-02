using System;

using TechTalk.SpecFlow;

namespace bbc_Login_Tests
{
    [Binding]
    public class SignIn_noUser
    {
        #region User hasn't entered any username or password
        [Given("User hasn't entered any username or password")]
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

        [When("User clickes sign in button")]
        public void wheniclickbutton(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("3 red boxes with text should show on page two stating Something's missing. Please check and try again. one saying Sorry, those details don't match.Check you've typed them correctly.")]
        public void rebboxresults(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User enters incorrect email or username with no password
        [Given("User enters incorrect email or username with no password")]
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

        [When("User clickes sign in button")]
        public void wheniclickbutton(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("3 red boxes with text should show on page two stating Something's missing. Please check and try again. one saying Sorry, those details don't match.Check you've typed them correctly.")]
        public void rebboxresults(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region Sign in with non-regestored email and wrong password
        [Given("Sign in with non-regestored email and wrong password")]
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

        [When("User clickes sign in button")]
        public void wheniclickbutton(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("3 red boxes with text should show on page two stating Something's missing. Please check and try again. one saying Sorry, those details don't match.Check you've typed them correctly.")]
        public void rebboxresults(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region Sign in with regestored email and short password
        [Given("Sign in with regestored email and short password")]
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

        [When("User clickes sign in button")]
        public void wheniclickbutton(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("3 red boxes with text should show on page two stating Something's missing. Please check and try again. one saying Sorry, those details don't match.Check you've typed them correctly.")]
        public void rebboxresults(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

        #region User enters regestored email with a short password
        [Given("User enters regestored email with a short password")]
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

        [When("User clickes sign in button")]
        public void wheniclickbutton(string id)
        {
            // TODO: implement act (action) logic

            ScenarioContext.Current.Pending();
        }

        [Then("3 red boxes with text should show on page two stating Something's missing. Please check and try again. one saying Sorry, those details don't match.Check you've typed them correctly.")]
        public void rebboxresults(string result)
        {
            // TODO: implement assert (verification) logic

            ScenarioContext.Current.Pending();
        }
        #endregion

    }
}
