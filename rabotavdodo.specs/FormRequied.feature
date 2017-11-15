Feature: Form
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@RequiedFields
Scenario Outline: Check Requied fields
	Given I have entered <FirstName>,<SecondName>,<City>,<BirthDay> into the Form
	When I press submit
	Then the result should be <result> on the screen

Examples: 
| FirstName | SecondName | City      | BirthDay   | result |
|	        | Иванов     | Сыктывкар | 11.12.1990 | true   |
| Петр      |		     | Москва    | 01.04.1998 | false  |
| Евгений   | Сидоров    |			 | 11.12.1990 | false  |
| Артем     | Мамаев     | Братск	 |			  | false  |

