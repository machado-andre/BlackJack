using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        private String suit;
        private int rank;
        private int score;
        private Dealer dealer;
        private Player player;

        public Card(String suit, int rank){
            this.suit = suit;
            this.rank = rank;
            setScore();
        }

        public String getSuit(){
            return this.suit;
        }

        public void setScore()
        {
            if (rank == 11 || rank == 12 || rank == 13 || rank == 14)
            {
                score = 10;
            }
            else
            {
                score=rank;
            }
        }

        public int getScore()
        {
            return score;
        }

        public int getRank(){
            return this.rank;
        }

        public void removeCardFromList(List<Card> cards)
        {
            if(cards == null || !cards.Contains(this))
                return;
            cards.Remove(this);
        }

        public void setPlayer(Player player){
            if (player == null || this.player == player)
                return;
            this.player = player;
            player.addCard(this);
        }

        public void setDealer(Dealer dealer){
            if (dealer == null || this.dealer == dealer)
                return;
            this.dealer = dealer;
            dealer.addCard(this);
        }

    }
}
