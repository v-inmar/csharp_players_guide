using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePoint
{
    class Card
    {
        public Enums.CardColor Color { get; set; }
        public Enums.CardRank Rank { get; set; }

        public string GetCardType => (int)Rank <= 10 ? "Number" : "Symbol";
    }
}
