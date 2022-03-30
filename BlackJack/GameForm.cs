using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class GameForm : Form
    {

        static String[] suits = { "Spades", "Clubs", "Hearts", "Diamonds" }; //suits
        static int[] ranks = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }; //ranks
        Random random = new Random(); //generate randoms
        Dealer dealer = new Dealer();
        Player player = new Player();
        List<Card> cards = new List<Card>();

        public GameForm(String nrOfDecks, String username, decimal startingMoney)
        {
            InitializeComponent();
            labelPlayer.Text=username+":";
            cards = generateCards(suits, ranks,int.Parse(nrOfDecks));
            player.setMoney(startingMoney);
            labelPlayerMoney.Text = "Total Money: $"+startingMoney.ToString();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            dealerCard1.BackgroundImage = findCardImage(dealer.dealDealerCard(cards,generateRandom(random,cards.Count)));
            playerCard1.BackgroundImage = findCardImage(dealer.dealPlayerCard(cards,player,generateRandom(random, cards.Count)));
            Card turnedDealerCard = dealer.dealDealerCard(cards, generateRandom(random, cards.Count));
            dealerCard2.BackgroundImage = Properties.Resources.CardBack;
            playerCard2.BackgroundImage = findCardImage(dealer.dealPlayerCard(cards, player, generateRandom(random, cards.Count)));

            labelDealerScore.Text = "Dealer Score: "+dealer.checkScore().ToString();
            labelPlayerScore.Text = "Player Score: "+player.checkScore().ToString();

            btnStartGame.Visible = false;
        }

        //Generate Random ints
        public int generateRandom(Random random, int max)
        {
            int nr = random.Next(0, max);
            return nr;
        }

        //Creates a list of 52 cards
        public List<Card> generateCards(String[] suits, int[] ranks, int decks)
        {
            List<Card> cards = new List<Card>();
            int k = 0;
            do
            {
                for (int i=0;i<ranks.Length;i++)
                {
                    for (int j=0;j<suits.Length;j++)
                    {
                        Card card = new Card(suits[j], ranks[i]);
                        cards.Add(card);
                    }
                }
                k++;
            } while(k<decks);
            return cards;
        }

        private Bitmap findCardImage(Card card)
        {
            String suit = card.getSuit();
            int rank = card.getRank();

            if(suit == "Spades")
            {
                switch (rank)
                {
                    case 2:
                        return Properties.Resources._2Spades;
                    case 3:
                        return Properties.Resources._3Spades;
                    case 4:
                        return Properties.Resources._4Spades;
                    case 5:
                        return Properties.Resources._5Spades;
                    case 6:
                        return Properties.Resources._6Spades;
                    case 7:
                        return Properties.Resources._7Spades;
                    case 8:
                        return Properties.Resources._8Spades;
                    case 9:
                        return Properties.Resources._9Spades;
                    case 10:
                        return Properties.Resources._10Spades;
                    case 11:
                        return Properties.Resources.JSpades;
                    case 12:
                        return Properties.Resources.QSpades;
                    case 13:
                        return Properties.Resources.KSpades;
                    case 14:
                        return Properties.Resources.ASpades;
                }
            }else if(suit == "Clubs")
            {
                switch (rank)
                {
                    case 2:
                        return Properties.Resources._2Clubs;
                    case 3:
                        return Properties.Resources._3Clubs;
                    case 4:
                        return Properties.Resources._4Clubs;
                    case 5:
                        return Properties.Resources._5Clubs;
                    case 6:
                        return Properties.Resources._6Clubs;
                    case 7:
                        return Properties.Resources._7Clubs;
                    case 8:
                        return Properties.Resources._8Clubs;
                    case 9:
                        return Properties.Resources._9Clubs;
                    case 10:
                        return Properties.Resources._10Clubs;
                    case 11:
                        return Properties.Resources.JClubs;
                    case 12:
                        return Properties.Resources.QClubs;
                    case 13:
                        return Properties.Resources.KClubs;
                    case 14:
                        return Properties.Resources.AClubs;
                }
            }else if(suit == "Hearts")
            {
                switch (rank)
                {
                    case 2:
                        return Properties.Resources._2Hearts;
                    case 3:
                        return Properties.Resources._3Hearts;
                    case 4:
                        return Properties.Resources._4Hearts;
                    case 5:
                        return Properties.Resources._5Hearts;
                    case 6:
                        return Properties.Resources._6Hearts;
                    case 7:
                        return Properties.Resources._7Hearts;
                    case 8:
                        return Properties.Resources._8Hearts;
                    case 9:
                        return Properties.Resources._9Hearts;
                    case 10:
                        return Properties.Resources._10Hearts;
                    case 11:
                        return Properties.Resources.JHearts;
                    case 12:
                        return Properties.Resources.QHearts;
                    case 13:
                        return Properties.Resources.KHearts;
                    case 14:
                        return Properties.Resources.AHearts;
                }
            }else if(suit == "Diamonds")
            {
                switch (rank)
                {
                    case 2:
                        return Properties.Resources._2Diamonds;
                    case 3:
                        return Properties.Resources._3Diamonds;
                    case 4:
                        return Properties.Resources._4Diamonds;
                    case 5:
                        return Properties.Resources._5Diamonds;
                    case 6:
                        return Properties.Resources._6Diamonds;
                    case 7:
                        return Properties.Resources._7Diamonds;
                    case 8:
                        return Properties.Resources._8Diamonds;
                    case 9:
                        return Properties.Resources._9Diamonds;
                    case 10:
                        return Properties.Resources._10Diamonds;
                    case 11:
                        return Properties.Resources.JDiamonds;
                    case 12:
                        return Properties.Resources.QDiamonds;
                    case 13:
                        return Properties.Resources.KDiamonds;
                    case 14:
                        return Properties.Resources.ADiamonds;
                }
            }

            return null;
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (playerCard3.BackgroundImage == null)
            {
                playerCard3.BackgroundImage = findCardImage(dealer.dealPlayerCard(cards, player, generateRandom(random, cards.Count)));
            }else if (playerCard4.BackgroundImage == null)
            {
                playerCard4.BackgroundImage = findCardImage(dealer.dealPlayerCard(cards, player, generateRandom(random, cards.Count)));
            }else if (playerCard5.BackgroundImage == null)
            {
                playerCard5.BackgroundImage = findCardImage(dealer.dealPlayerCard(cards, player, generateRandom(random, cards.Count)));
            }

            labelPlayerScore.Text = "Player Score: "+player.checkScore().ToString();
            if (player.getScore() > 21)
            {
                gameover();
            }
        }

        private void gameover()
        {
            
        }
    }
}
