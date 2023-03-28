using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        public Player CurrentPlayer { get; set; }
        public bool IsFinished { get; set; }

        public bool IsWinner { get; set; }

        private Square[,] _squares;

        public Board(Player currentPlayer, Square[,] squares)
        {
            CurrentPlayer = currentPlayer;
            IsFinished = false;
            IsWinner = false;
            _squares = squares;
        }

        public bool SetSquareValue(int row, int column)
        {
            if (IsSquareAvailable(row: row, column: column))
            {
                _squares[row, column].Value = CurrentPlayer.Symbol;
                SetFinished();
                return true;
            }
            Console.WriteLine("Square has already been filled");
            return false;
            
        }

        private bool IsSquareAvailable(int row, int column)
        {
            if (_squares[row, column].Value != "")
            {
                return false;
            }
            return true;
        }


        public void PrintBoard()
        {
            for(int row = 0; row < _squares.GetLength(0); row++)
            {
                for(int column = 0; column < _squares.GetLength(1); column++)
                {
                    string toPrint = _squares[row, column].Value == "" ? "   " : $" {_squares[row, column].Value} ";
                    if (column == _squares.GetLength(1) - 1)
                    {
                        Console.WriteLine($"{toPrint}");
                    }
                    else
                    {
                        Console.Write($"{toPrint}|");
                    }
                    
                }
                if(row != _squares.GetLength(0)-1)
                    Console.WriteLine("---+---+---");
            }
        }

        public void IsThereWinner()
        {

            // rows check
            for(int row = 0; row < _squares.GetLength(0); row++)
            {
                if (_squares[row, 0].Value == _squares[row, 1].Value && _squares[row, 1].Value == _squares[row, 2].Value && _squares[row, 0].Value != "")
                {
                    IsFinished = true;
                    IsWinner = true;
                }
            }

            // columns check
            for(int column = 0; column < _squares.GetLength(1); column++)
            {
                if (_squares[0, column].Value == _squares[1, column].Value && _squares[1, column].Value == _squares[2, column].Value && _squares[0, column].Value != "")
                {
                    IsFinished = true;
                    IsWinner = true;
                }
            }

            // diagonal check
            if (_squares[0,0].Value == _squares[1, 1].Value && _squares[1, 1].Value == _squares[2, 2].Value && _squares[0, 0].Value != "")
            {
                IsFinished = true;
                IsWinner = true;
            }

            // counter diagonal check
            if (_squares[0, 2].Value == _squares[1, 1].Value && _squares[1, 1].Value == _squares[2, 0].Value && _squares[0, 2].Value != "")
            {
                IsFinished = true;
                IsWinner = true;
            }

        }

        private void SetFinished()
        {
            bool hasEmpty = false;
            for(int row = 0; row < _squares.GetLength(0); row++)
            {
                for (int column = 0; column < _squares.GetLength(1); column++)
                {
                    if (_squares[row, column].Value == "")
                    {
                        return;
                    }
                }
            }

            if (!hasEmpty)
            {
                IsFinished = true;
            }
        }


    }
}
