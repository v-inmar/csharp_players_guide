using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Square
    {
        public string Value { get; set; } = "";

        public int CoordinateRow { get; init; }
        public int CoordinateColumn { get; init; }

        public Square(int coordinateRow, int coordinateColumn)
        {
            Value = "";
            CoordinateRow = coordinateRow;
            CoordinateColumn = coordinateColumn;
        }


        override
        public string ToString() => $"Square at Column: {CoordinateColumn} Row: {CoordinateRow} with a value of {Value}";
    }
}
