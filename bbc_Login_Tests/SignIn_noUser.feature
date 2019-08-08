@ignore
Feature: sign in page
	Before we can make it to the next page we need to do these test for 
    sign in.

@SigningIn
Scenario: Sign in with no infomation
	Given User hasn't entered any username or password 
	When User clickes sign in button with no infomation
	Then 3 red boxes with text should show on page two stating "Something's missing. Please check and try again." one saying "Sorry, those details don't match. Check you've typed them correctly."

Scenario: Sign in with no pass and wrong email
    Given User enters incorrect email or username with no password
    When User clickes sign in button with no pass and wrong email
    Then two red boxes will show password related stating "Something's missing. Please check and try again." and top message above username saying "Sorry, those details don't match. Check you've typed them correctly."

Scenario: Sign in with non-regestored email and wrong password
    Given User enters non-regestored email with a password
    When User clickes sign in button with non-regestored email and wrong password
    Then One box appers under the username saying "Sorry, we can’t find an account with that email. You can register for a new account or get help here."


Scenario: Sign in with regestored email and short password
    Given User enters regestored email with a short password
    When User clickes sign in button with regestored email and short password
    Then message is shown below password box saying "Sorry, that password is too short. It needs to be eight characters or more."

