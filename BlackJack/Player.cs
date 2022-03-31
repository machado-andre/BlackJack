using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        private int score;
        private decimal money;
        private decimal wage;
        private List<Card> playerCards = new List<Card>();

        public Player()
        {
        }

        public void setWage(decimal wage)
        {
            this.wage = wage;
        }

        public void setMoney(decimal money)
        {
            this.money = money;
        }

        public decimal getMoney()
        {
            return money;
        }

        public int getScore()
        {
            return score;
        }

        public void bet(decimal wage)
        {
            if(money < wage || wage <=0)
            {
                return;
            }
            setMoney(money -= wage);
        }

        public void addCard(Card card){
            if (card == null || playerCards.Contains(card))
                return;
            playerCards.Add(card);
            card.setPlayer(this);
        }

        public List<Card> getCards()
        {
            return playerCards;
        }

        public int checkScore()
        {
            score=0;
            for (int i=0; i<playerCards.Count;i++)
            {                
                score += playerCards[i].getScore();
            }
            return score;
        }

        public void loseBet()
        {
            clearHand();
            money -= wage;
        }

        public void clearHand()
        {
            if (playerCards == null)
                return;
            foreach (Card card in playerCards){
                card.removePlayer(this);
            }
            playerCards.Clear();
        }
    }
}
