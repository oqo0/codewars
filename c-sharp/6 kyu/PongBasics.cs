// https://www.codewars.com/kata/5b432bdf82417e3f39000195/

using System;

namespace CodeWars
{
    class Pong
    {
        private int _maxScore;
        private Player _player1;
        private Player _player2;
        private int _playerTurn = 1;
        private bool _gameIsOver = false;
    
        public Pong(int maxScore)
        {
            _maxScore = maxScore;
            _player1 = new Player();
            _player2 = new Player();
        }

        public string play(int ballPos, int playerPos)
        {
            if (_gameIsOver)
                return "Game Over!";
      
            string res;
            Player currentPlayer, anotherPlayer;

            if (_playerTurn == 1)
            {
                currentPlayer = _player1;
                anotherPlayer = _player2;
            }
            else
            {
                currentPlayer = _player2;
                anotherPlayer = _player1;
            }

            currentPlayer.Position = playerPos;
      
            if (currentPlayer.CatchBall(ballPos))
            {
                res = $"Player {_playerTurn} has hit the ball!";
            }
            else
            {
                anotherPlayer.Score++;
                res = $"Player {_playerTurn} has missed the ball!";
            }

            if (currentPlayer.Score >= _maxScore)
            {
                res = $"Player {_playerTurn} has won the game!";
                _gameIsOver = true;
            }
            if (anotherPlayer.Score >= _maxScore)
            {
                int p = _playerTurn == 1 ? 2 : 1;
                res = $"Player {p} has won the game!";
                _gameIsOver = true;
            }
            
            _playerTurn = _playerTurn == 1 ? 2 : 1;
            
            return res;
        }
    }

    internal class Player
    {
        private const int PaddleHeight = 7;

        public int Score { get; set; }
        public int Position { get; set; }
    
        public bool CatchBall(int ballPosition)
        {
            int posDiff = Math.Abs(Position - ballPosition);

            if (posDiff <= (PaddleHeight - 1) / 2)
                return true;

            return false;
        }
    }
}