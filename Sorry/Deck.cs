using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorry
{
   public class Deck 
    {
        private Card[] deck { get; set; }  //array of all cards
        private const int NUM_OF_CARDS = 45;  //number of cards in the game
        int positionInArray;

        public Deck()
        {
            deck = new Card[NUM_OF_CARDS]; //Initialize array to necessary size of Cards

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
        public void DrawCard()
        {

        }
        
        public void CreateDeck()//Create deck of 45 cards
        {
            int i = 0;
            foreach(Card.VALUE v in Enum.GetValues(typeof(Card.VALUE)))
            {
                deck[i] = new Card{ cardVal = v };
                i++;
            }

            Shuffle();
        }
    }

    
}
