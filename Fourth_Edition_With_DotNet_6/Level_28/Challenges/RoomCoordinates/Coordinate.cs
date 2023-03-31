using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCoordinates
{
    public struct Coordinate
    {
        public readonly int Row { get; }
        public readonly int Column { get; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }

        /// <summary>
        /// Check if a coordinate is adjacent to this instance
        /// </summary>
        /// <param name="c">Coordinate instance to be checked against</param>
        /// <returns>Boolean</returns>
        public bool IsAdjacent(Coordinate c)
        {
            if(Math.Abs(Row - c.Row) == 1 && (Math.Abs(Column - c.Column)) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
