Feature: GiftreteBackground
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Background: 
	Given I navigate to site "https://qa.giftrete.com/account/authentication?ref=1"
	When I enter email "dougdodo@gmail.com"
	And I enter password "Thankyou"
	And I click on remember me box
	And I click on sign in
	

@mytag
Scenario: Posting An Item
	When I enter click on Post item
	And I enter item name "FootBall"
	And I enter Item description "Playing Football"
	And I click on item category 
	And I selecct Games from the dropdown
	And I click on Item type
	And I select Wanted
	And I enter item weight "30"
	And I enter location "SE18 1NR"
	And I click on item image
	And I click on choose file
	And I click on Add item
	And I click on my posted item	
	Then I should be able to see my post items
