Feature: Registrations
	So that I can use the site
	I need to register

@ValidRegistration
Scenario: Valid Registration
	Given I navigate to the site
	When I click on register link
	And I enter firstname
	And I enter lastname
	And I enter email "test@giftrete.com"
	And I enter mobile number
	And I input password
	And I confirm password
	And I click on signUp
	Then I should be registered

@Invalid Registration
Scenario: Invalid Registration
	Given I navigate to the site
	When I click on register link
	And I enter firstname
	And I enter lastname
	And I enter email "test@giftrete.com"
	And I enter mobile number
	And I input password "MyNewPassword"
	And I confirm password "No"
	Then the password is too short error is displayed

Scenario: Not Navigating to the registration page
	Given I navigate to the site 
	When  I click on login link
	Then the registration page is not displayed 

Scenario: Navigating to the registration page
	Given I navigate to the site 
	When I click on register link
	Then the registration page should be displayed