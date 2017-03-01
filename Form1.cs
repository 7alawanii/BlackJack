using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public static Deck deck = new Deck();
        public static Player mainPlayer = new Player("Player", false);
        public static Player computerPlayer = new Player("Computer", true);
        public static Boolean btn_hit = false;
        public Form1()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            hit.Enabled = false;
            stand.Enabled = false;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stand_Click(object sender, EventArgs e)
        {
            stand.Enabled = false;
            hit.Enabled = false;
            ProcessTurn_d(computerPlayer, computerPlayer.hand);
            EndTotals(mainPlayer, computerPlayer);
        }

        private void hit_Click(object sender, EventArgs e)
        {
            ProcessTurn_main(mainPlayer, mainPlayer.hand);
            if (btn_hit)
            {
                hit.Enabled = false;
                EndTotals(mainPlayer, computerPlayer);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
           
            start.Enabled = false;
            hit.Enabled = true;
            stand.Enabled = true;
            GameStart();
        }
        private void GameStart()
        {
            deck.Shuffle();
            List<Player> players = new List<Player> { mainPlayer, computerPlayer };

            foreach (var player in players)
            {
                player.GenerateHand();

            }
            computer.AppendText("**Hidden** , " + computerPlayer.hand[1].Number.ToString() + Environment.NewLine);
            txt_my.AppendText(mainPlayer.hand[0].Number.ToString()+" , "+ mainPlayer.hand[1].Number.ToString()+ Environment.NewLine);
            total.AppendText("( " + mainPlayer.Total() + " )");
        }


        private void ProcessTurn_d(Player player, List<Card> hand) {
            computer.AppendText(player.hand[0].Number.ToString() + " , " + player.hand[1].Number.ToString() + Environment.NewLine);
            dtotal.AppendText("( " + player.Total().ToString() + " )");
            if (player.Total() == 21 && player.hand.Count == 2)
            {
                return; 
            }
            else
            {
                List<string> newHand = new List<string>();
                foreach (Card card in player.hand)
                {
                    newHand.Add(card.Number.ToString());
                }
                while (player.Total() < 19)
                {
                    Thread.Sleep(1000);
                    Card randomCard = deck.RandomCard();
                    player.hand.Add(randomCard);
                    newHand.Add(randomCard.Number.ToString());
                    computer.AppendText(string.Join(" , ", newHand) + Environment.NewLine);
                    dtotal.Clear();
                    dtotal.AppendText("( " + player.Total().ToString() + " )");
                }
                if (player.Total() > 21)
                {
                    return;
                }
            }


        }

        private void total_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ProcessTurn_main(Player player, List<Card> hand)
        {
                    List<string> newHand = new List<string>();
                        Card randomCard = deck.RandomCard();
                        player.hand.Add(deck.RandomCard());

                        foreach (var card in player.hand)
                        {
                            newHand.Add(card.Number.ToString());
                        }
            txt_my.AppendText(string.Join(" , ", newHand) + Environment.NewLine);
            total.Clear();
            total.AppendText("( " + player.Total().ToString() + " )");


            if (player.Total() > 21)
            {
                hit.Enabled = false;
                stand.Enabled = false;
                btn_hit = true;
                return; 

            }
        }

        private void EndTotals(Player player, Player computerp)
        {
            if (computerp.Total() > 21)
            {
                result.AppendText("Computer busts ! You wins !");
                return;
            }
            else if (computerp.Total() > 21 && player.Total() > 21)
            {
                result.AppendText("You and The Computer both lose ! Nobody wins.");
            }
            else if (computerp.Total() == 21 && computerp.hand.Count == 2)
            {
                result.AppendText("Computer has Blackjack. You lose !");
            }
            else
            {
                if (player.Total() > 21)
                {
                    result.AppendText("You busted. Sorry, you lose !");
                }
                else if (player.Total() <= 21)
                {
                    if (player.Total() < computerp.Total())
                    {
                        result.AppendText("You had less than the Computer. Sorry, You lose!");
                    }
                    else if (player.Total() == computerp.Total())
                    {
                        result.AppendText("You had the same as the Computer. Push, take your money back.");
                    }
                    else if (player.Total() > computerp.Total())
                    {
                        result.AppendText("You had more than the Computer. You won!");
                    }
                }
            }
            
        }
    }
}
