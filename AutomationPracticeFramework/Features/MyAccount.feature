Feature: MyAccount
	Simple calculator for adding two numbers

@MyAccount
Scenario: User can log in
	Given user opens sign in 
	And enters correct credentials
	When user submits the login form
	Then user will be logged in