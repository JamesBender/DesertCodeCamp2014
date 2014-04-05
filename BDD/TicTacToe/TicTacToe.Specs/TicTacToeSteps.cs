using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TicTacToe.Specs
{
    [Binding]
    public class TicTacToeSteps
    {
        private string[,] _board;
        private TicTacToe.Core.GameEngine _gameEngine = new TicTacToe.Core.GameEngine();
        private string _result;

        [Given(@"I have a tic tac toe board")]
        public void GivenIHaveATicTacToeBoard()
        {
            _board = new String[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        }

        [Given(@"the board is empty")]
        public void GivenTheBoardIsEmpty()
        {
            return;
        }

        [When(@"I determine the winner")]
        public void WhenIDetermineTheWinner()
        {
            _result = _gameEngine.GetWinner(_board);
        }

        [Then(@"the result be a ""(.*)""")]
        public void ThenTheResultBeA(string expectedResult)
        {
            Assert.AreEqual(expectedResult, _result);
        }

        [Given(@"""(.*)"" is across the top row")]
        public void GivenIsAcrossTheTopRow(string token)
        {
            _board[0, 0] = token;
            _board[0, 1] = token;
            _board[0, 2] = token;
        }

    }
}
