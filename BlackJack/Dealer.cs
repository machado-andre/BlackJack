using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer
    {
        private int score;
        private List<Card> dealerCards = new List<Card>();

        public Dealer(){
            score = 0;
        }

        public int getScore()
        {
            return score;
        }
        // Removes 1 random card from the deck and places it on dealer's hand
        public Card dealDealerCard(List<Card> cards, int random)
        {
            if (cards == null)
                return null;
            Card card = cards[random];
            card.removeCardFromList(cards);
            addCard(card);
            return card;
        }
        // Removes 1 random card from the deck and places it on players's hand
        public Card dealPlayerCard(List<Card> cards, Player player, int random)
        {
            if (cards == null || player == null)
                return null;
            Card card = cards[random];
            card.removeCardFromList(cards);
            player.addCard(card);
            return card;
        }

        public void addCard(Card card)
        {
            if (card == null || dealerCards.Contains(card))
                return;
            dealerCards.Add(card);
            card.setDealer(this);
        }

        public int checkScore()
        {
            score = 0;
            for (int i = 0; i < dealerCards.Count; i++)
            {
                score += dealerCards[i].getScore();
            }
            return score;
        }
    }
}
