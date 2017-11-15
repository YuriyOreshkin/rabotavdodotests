Feature: CityInList
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@Cities
Scenario Outline: Check City in List
	Given I have entered <City> into the CityField
	When I press getCity
	Then the City should be <result> on the screen

Examples: 
| City      | result					 |
| Сыктывкар | Сыктывкар					 |
| Караганда | Выберите город из списка	 |
| братск	| Братск					 |
