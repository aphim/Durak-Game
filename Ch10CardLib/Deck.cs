/*  Project: OOP 4200: Durak Project
 *  Author: Jacky Yuan
 *          Ashok Sasitharan
 *          Andre Agrippa
 *          Roshan Persaud
 *          Manthan Amitkumar Shah
 *          
 *  Desc:  This class is used for the deck in CardLib based on the tutorials.
 * 
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
    /// <summary>
    /// Deck class
    /// </summary>
    public class Deck
    {
        //private card array
        public static int cardsInDeck = 36;
        private ArrayList cards = new ArrayList(cardsInDeck);

        /// <summary>
        /// Deck constructor that initializes a deck of cards
        /// </summary>
        public Deck()
        {
            //card value and in initial value are both set to increment the cards and assign them values properly due to way the cards are ordered when initialized
            int cardValue = 1;
            int initialValue = 1;
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                //reinitialize the starting point of the value assignment
                cardValue = initialValue;
                //increment the starting point by 1
                initialValue++;
                for (int rankVal = 1; rankVal < 10; rankVal++)
                {
                    //Adds the card to the deck
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal, cardValue));
                    //increments the value by 4
                    cardValue = cardValue + 4;
                }
            }
        }

        /// <summary>
        /// Method for getting the value of a card
        /// </summary>
        /// <param name="cardNum">holds the value of a particular card</param>
        /// <returns>the value of the card</returns>
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= cardsInDeck - 1)
            {
                return (Card)cards[cardNum];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and 36."));
            }
        }

        /// <summary>
        /// Method used to shuffle the deck of cards
        /// </summary>
        public void Shuffle()
        {
            //creates arrays for the shuffle method
            Card[] newDeck = new Card[cardsInDeck];
            bool[] assigned = new bool[cardsInDeck];
            Random sourceGen = new Random();
            //for loop shuffling the cards
            for (int i = 0; i < cardsInDeck; i++)
            {
                int destCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    destCard = sourceGen.Next(cardsInDeck);
                    if (assigned[destCard] == false)
                    {
                        foundCard = true;
                    }
                }
                assigned[destCard] = true;
                newDeck[destCard] = (Card)cards[i];
            }
            cards = new ArrayList(newDeck);
        }

        /// <summary>
        /// Gets the number of remaining cards in the deck
        /// </summary>
        /// <returns>number of cards in the current deck</returns>
        public int getCardsRemaining()
        {
            int cardsRemaining = cards.Count;
            return cardsRemaining;
        }

        /// <summary>
        /// Gets the trump card from the deck.
        /// </summary>
        /// <returns>Pulls the bottom card and sets it as the trump card</returns>
        public Card getTrumpcard()
        {
            Card trumpCard = new Card((Card)cards[0]);

            return trumpCard;
        }

        /// <summary>
        /// Draws a card from the deck
        /// </summary>
        /// <returns>the top card from the deck as the drawn card</returns>
        public Card drawCard()
        {
            Card drawnCard = new Card((Card)cards[cards.Count - 1]);

            cards.RemoveAt(cards.Count - 1);
            
            return drawnCard;
        }

        /// <summary>
        /// Display deck method used to display the remaining deck
        /// </summary>
        /// <param name="myDeck"></param>
        public void displayDeck(Deck myDeck)
        {
            //loops through the length of the deck
            for (int i = 0; i < myDeck.getCardsRemaining(); i++)
            {
                //displays the current card
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString());
                if (i != myDeck.getCardsRemaining() - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }



    }
}