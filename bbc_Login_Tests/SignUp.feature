
Feature: Signing up to BBC website
	In order to user the site a user needs to sign up 
    this is the process of testing that journey
	
    @ignore
Scenario: User is under 13 
    Given Useris under 13 and needs to sign up 
    And user clicks on under 13 button  
    When is taken to page requesting parent or gadient email
    Then parent enters email adress and starts the sign up process
@ignore
@Over13SignUp
Scenario: User is over 13
    Given User is over 13 
    When user click on over 13 button 
    Then it should take them to register screen

Scenario: User enter day, month, year in wrong formate
    Given User is presented with DOB boxes 
    When user enters charectors instead of numbers and clicks continue 
    Then they should be present with a red warning box explaing the correct format "Oops, that date doesn't look right. Make sure it's a real date written as DD-MM-YYYY e.g. the 5th of June 2009 is 05-06-2009."
@ignore
Scenario: User enter a DOB that is not above 13 but in correct formate
    Given User enter their DOB in correct formate but doesn't make them over 13 
    When user click on continue
    Then it should show a message stating that there under the age of 13 "Sorry, you need to be 13 or over."
@ignore
Scenario: User enters correct details and is taken to the register page
    Given User enter their DOB in correct formate and is over 13
    When user click on continue
    Then it takes user to Register with the BBC screen asking for more details
@ignore    
Scenario: User enter all details on registor page incorrectly with a short postcode
    Given User enters a word for email, enters a password too short and a postcode that is too short
    When user clicks register
    Then it should fail and tell then that the password is too short, passcode is too short and the email doesn't look like a real email address
@ignore
Scenario: User enters correct email, a password with only letters and a incorrect passcode
    Given User enters a correct email address, a password only containing letters and an invaild postcode
    When user clicks register
    Then its fails and informs that "Sorry, that password isn't valid. Please include something that isn't a letter." and "Sorry, that postcode isn't valid. Please check it's a proper postcode."
@ignore
Scenario: User enters all correct details 
    Given User enter all correct registration details 
    When  user clicks register
    Then taken to the next page
      