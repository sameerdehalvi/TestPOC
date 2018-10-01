Feature: CondecoTest
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag

	Scenario Outline: Login Condeco
	Given I launch Condeco website
	And I enter my username and Password
	When I click Sign in
	Then I am on landing page
	Examples:
	| Data |
	| x    |
	| y    |

	Scenario: View Apps Page
	Given I launch Condeco website
	And I enter my username and Password
	When I click Sign in
	And I click on Go to my apps
	Then I am on Room Booking Page