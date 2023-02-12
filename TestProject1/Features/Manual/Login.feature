Feature: Login

Manual test cases for login page.

@tc-4
Scenario: User tries to log in with incorrect email or password too many times and sees validation message	
	User goes to Zaplify login page
	User fills incorrect email or password
	User cliks login too many times
	User sees message "Too many invalid requests, please try again later"

@tc-5
Scenario: User tries to log in with too short password and sees validation message	
	User goes to Zaplify login page
	User fills email 
	User fills password shorter than 6 characters
	User sees message "Password must contain a minimum of 6 characters"

@tc-6
Scenario: User tries to log in with incorrect email format and sees validation message	
	User goes to Zaplify login page
	User fills incorrect email format
	Log in button is disabled
	User sees message "Invalid email address"

@tc-7
Scenario: User recovers forgotten password
	User goes to Zaplify login page
	User cliks "Forgot password?" button
	User fills email input on reset-password page
	User cliks "Send reset instructions"
	User sees "Check your email" modal and can click "Open Outlook" or "Open Gmail" button
	Reset Instructions should be sent to email


	