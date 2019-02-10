Feature: ErrorMessages

@mytag
Scenario Outline: Invalid Registration #Scenario outline allows you have series of test cases to test
	Given I navigate to the site
	When I click on register link
	And I enter firstname
	And I enter lastname
	And I enter email "test@"
	And I enter mobile number
	And I input password "MyNewPassword"
	And I confirm password "No"
	And I click on signUp
	Then the error message "<message>" is displayed for "<test>"

	Examples:
	| test            | message                                                |
	| PasswordTooShort | Your Password Must Be At Least 5 Characters Long       |
	| Invalidemail     | Please Enter A Valid Email Address                     |
	| MobileTooShort   | Your Mobile Number Must Be At Least 10 Characters Long |

