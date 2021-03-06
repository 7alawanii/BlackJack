﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        public List<Card> hand = new List<Card>();
        public string Name { get; set; }
        //public bool IsDealer { get; set; }
        public bool IsDealer;

        public void GenerateHand()
        {
            for (int i = 0; i < 2; i++)
            {
                Card card = Form1.deck.RandomCard();
                hand.Add(card);
                Form1.deck.cards.Remove(card);
            }
        }

        public int Total()
        {
            int total = 0;

            foreach (var card in hand)
            {
                Number number;
                int value;
                if (Enum.TryParse(card.Number.ToString(), out number))
                {
                    value = (int)number;
                    total += value;
                }
            }

            return total;
        }

        public Player(string name, bool isDealer)
        {
            Name = name;
            IsDealer = isDealer;
        }
    }
}
