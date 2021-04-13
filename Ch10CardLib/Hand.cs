/*  Project: OOP 4200: Durak Project
 *  Author: Jacky Yuan
 *          Ashok Sasitharan
 *          Andre Agrippa
 *          Roshan Persaud
 *          Manthan Amitkumar Shah
 *          
 *  Desc:  This class is used for the hand in CardLib.
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
    public class Hand
    {
        //set the default hand size to 6 and create an arraylist for the hand
        public static int defaultHandSize = 6;
        private ArrayList hand = new ArrayList(defaultHandSize);

        /// <summary>
        /// Draws out initial hand from the selected deck.
        /// </summary>
        /// <param name="deck">deck to draw the hand from</param>
        public Hand(Deck deck)
        {
            //loops until we reach the default hand size
            for (int i=0; i< defaultHandSize; i++)
            {
                //draw a card
                hand.Add(deck.drawCard());
            }
        }

        /// <summary>
        /// default constructor 
        /// </summary>
        private Hand()
        {
        }

        /// <summary>
        /// Gets a card using its index from the hand
        /// </summary>
        /// <param name="cardNum">index of the card</param>
        /// <returns>returns selected card</returns>
        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= hand.Count-1)
            {
                return (Card)hand[cardNum];
            }
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and handsize"));
            }
        }

        /// <summary>
        /// returns the size of the current hand
        /// </summary>
        /// <returns>size of the hand</returns>
        public int gethandSize()
        {
            int handSize = hand.Count;
            return handSize;
        }

        /// <summary>
        /// Plays a card from the hand returning the selected card and removing it from the hand
        /// </summary>
        /// <param name="cardNum">index of the card to be played</param>
        /// <returns>returns selected card from the hand</returns>
        public Card playCard(int cardNum)
        {
            //checks to see if the index is within range of the hand and plays the corresponding card
            if (cardNum >= 0 && cardNum <= hand.Count - 1)
            {
                Card playedCard = (Card)hand[cardNum];

                hand.RemoveAt(cardNum);

                return playedCard;
            }
            //returns an error message
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and handsize"));
            }

        }

        /// <summary>
        /// Chooses a card from the hand but does not play it (Similar to playCard method but doesn't play the card. Used for
        /// validating the card selection before it is played)
        /// </summary>
        /// <param name="cardNum"></param>
        /// <returns>the selected card</returns>
        public Card selectCard(int cardNum)
        {
            //checks to see of the card selected is within the handsize
            if (cardNum >= 0 && cardNum <= hand.Count - 1)
            {
                Card playedCard = (Card)hand[cardNum];

                return playedCard;
            }
            //otherwise throws an exception
            else
            {
                throw (new System.ArgumentOutOfRangeException("cardNum", cardNum, "Value must be between 0 and handsize"));
            }
        }

        public void removeHand()
        {
            //loops through the hand
            for (int i = 0; i < this.gethandSize(); i++)
            {
                hand.RemoveAt(i);
            }
        }


        /// <summary>
        /// adds a card to the hand
        /// </summary>
        /// <param name="card">card to be added</param>
        public void addCard(Card card)
        {
            hand.Add(card);
        }

        /// <summary>
        /// Method used to display the current hand
        /// </summary>
        public void displayHand()
        {
            //loops through the hand
            for (int i = 0; i < this.gethandSize(); i++)
            {
                //displays the current card
                Card tempCard = this.GetCard(i);
                Console.Write(tempCard.ToString());
                if (i != this.gethandSize() - 1)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        /// <summary>
        /// Function used for displaying the hand in the GUI
        /// </summary>
        /// <returns>the hand in a string format</returns>
        public override string ToString()
        {
            String tempString = "";
            //loops through the hand
            for (int i = 0; i < this.gethandSize(); i++)
            {
                //displays the current card
                Card tempCard = this.GetCard(i);
                
                tempString +=   " "+ tempCard.ToString();
            }
            return tempString;
        }

    }
}
