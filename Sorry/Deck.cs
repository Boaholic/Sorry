using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorry
{
   public class Deck 
    {
        private List<Card> deck { get; set; }  //array of all cards
        private const int NUM_OF_CARDS = 45;  //number of cards in the game
        int positionInArray;

        public Deck()
        {
            deck = new List<Card>(); //Initialize array to necessary size of Cards
            CreateDeck();
        }

        public void Shuffle()//shuffles the deck of cards
        {
            Random rand = new Random();
            Card temp;
            //shuffle 100 times
            for(int i = 0 ; i < 100 ; i++)
            {
                for(int j = 0; j < NUM_OF_CARDS; j++)
                {
                    int secondCard = rand.Next(11);//The total number of cards in 1 'set'

                    temp = deck[j];
                    deck[j] = deck[secondCard];  //Swap the two cards
                    deck[secondCard] = temp;
                }
            }
        }
        
        //This actually need to return type Card
        public Card DrawCard()
        {
            Card toReturn=deck[positionInArray];
            positionInArray = (positionInArray + 1) % NUM_OF_CARDS;
            if (positionInArray == 0)
                Shuffle();
            return toReturn;
        }
        
        public void CreateDeck()//Create deck of 45 cards
        {
            int i = 0;
            for (int j = 0; j < 4; j++)
            {
                foreach (Card.VALUE v in Enum.GetValues(typeof(Card.VALUE)))
                {
                    deck.Add(new Card { cardVal = v });
                    i++;
                }
            }
            deck.Add(new Card { cardVal = Card.VALUE.One });
            Shuffle();
        }
    }

    
}
