using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public Number Number { get; set; }
        public Suit Suit { get; set; }

        public Card(Number number, Suit suit)
        {
            Number = number;
            Suit = suit;
        }

    }
}
