using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public string Name { get; init; }
        public string Symbol { get; init; }

        public Player(string name, string symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        override
        public string ToString()
        {
            return $"Player: {Name} has the Symbol: {Symbol}";
        }
    }
}
