Feature: Login

Automated test cases for login page.

@tc-1
Scenario: User can login to Zaplify main page
	Given User goes to Zaplify login page
	When User fills email
	And User fills password
	And User cliks login
	Then User is redirected to Zaplify main page

@tc-2 
Scenario: User tries to log in with incorrect email
	Given User goes to Zaplify login page
	When User fills incorrect email
	And User fills password
	And User cliks login
	Then User sees incorrect email message

@tc-3 
Scenario: User tries to log in with incorrect password
	Given User goes to Zaplify login page
	When User fills email
	And User fills incorrect password
	And User cliks login
	Then User sees incorrect password message
	