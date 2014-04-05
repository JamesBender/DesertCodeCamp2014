Feature: Tic Tac Toe
	In order to determine who the winner of the game as
	As a Player
	I want to be told who (if anyone) won the game

Scenario: Empty board ends with a tie
	Given I have a tic tac toe board
	And the board is empty
	When I determine the winner
	Then the result be a " "

Scenario: If top row is all X then X is the winner
	Given I have a tic tac toe board
	And "X" is across the top row
	When I determine the winner
	Then the result be a "X"

Scenario: If top row is all O then O is the big winner
	Given I have a tic tac toe board
	And "O" is across the top row
	When I determine the winner
	Then the result be a "O"
