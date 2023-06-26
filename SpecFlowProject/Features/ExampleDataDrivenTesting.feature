Feature: Examples Data Driven Testing

A short summary of the feature


@TesterTalk
Scenario Outline: Examples Data Driven Testing
	Given Open the browser
	When Enter the URL
	Then Search with <searchKey>
	Examples:
	| searchKey                |
	| specflow by Testers talk |
	| selenium by Testers talk |

