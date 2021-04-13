/*  Project: OOP 4200: Durak Project
 *  Author: Jacky Yuan
 *          Ashok Sasitharan
 *          Andre Agrippa
 *          Roshan Persaud
 *          Manthan Amitkumar Shah
 *          
 *  Desc:  This class is used for the field in CardLib.
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
    public class Field
    {
        /// <summary>
        /// ArrayLists for the field and the discard piles
        /// </summary>
        private ArrayList field = new ArrayList();
        private ArrayList discard = new ArrayList();

        /// <summary>
        /// Defualt constructor for the field class 
        /// </summary>
        public Field()
        {
        }

        /// <summary>
        /// Method used to get the field cards
        /// </summary>
        /// <returns>returns the cards from the field in an arraylist</returns>
        public ArrayList getField()
        {
            //Creates and arraylist fieldCards
            ArrayList fieldCards = new ArrayList();
            //checks if the arraylist is empty
            if (field.Count > 0)
            {
                //loops through and places the field cards into the arraylist
               for (int i = 0; i < field.Count; i++)
               {
                  fieldCards.Add((Card)field[i]);
               }
            }
            //displays message field is empty
            else
            {
                Console.WriteLine("Field is empty.");
            }
            //returns the arraylist
            return fieldCards;
        }

        /// <summary>
        /// Method used to add a card to the field
        /// </summary>
        /// <param name="card">a card object </param>
        public void cardPlayed(Card card)
        {
            field.Add(card);
        }

       /// <summary>
       /// Method used to get the current card from the field (card last played)
       /// </summary>
       /// <returns> last card played on the field</returns>
        public Card getCurrentCard()
        {
            Card currentCard;

            currentCard = ((Card)field[field.Count-1]);

            return currentCard;
        }

        /// <summary>
        /// Method used to get a particular card from the field using an index
        /// </summary>
        /// <param name="index"></param>
        /// <returns>the card of the index entered</returns>
        public Card getIndexCard(int index)
        {
            Card indexCard;

            indexCard = ((Card)field[index]);

            return indexCard;
        }

        /// <summary>
        /// Method used to get the discard pile
        /// </summary>
        /// <returns> an arraylist containing the discard pile</returns>
        public ArrayList getDiscard()
        {
            //creates a new arraylist
            ArrayList discardCards = new ArrayList();
            //checks to see if the discardpile is empty
            if (discard.Count > 0)
            {
                //loops through and adds the cards of the discard pile into the arraylist
                for (int i = 0; i < discard.Count; i++)
                {
                    discardCards.Add((Card)discard[i]);
                }
            }
            //displays a message saying the discardpile is empty
            else
            {
                Console.WriteLine("discard is empty.");
            }
            return discardCards;
        }

        /// <summary>
        /// Method used to discard the field into the discard pile
        /// </summary>
        public void discardField()
        {
            //checks if the field is empty
            if (field.Count > 0)
            {
                //loops through and places the field cards into the discardpile
                for (int i = 0; i < field.Count; i++)
                {
                    discard.Add((Card)field[i]);
                }
            }
            //Displays a message if the field is empty
            else
            {
                Console.WriteLine("Field is empty.");
            }
            //clears the field of all its cards
            field.Clear();
        }

        /// <summary>
        /// Method used to pickup all the cards from the field
        /// </summary>
        /// <returns> an arrayList with all the cards from the field</returns>
        public ArrayList pickupField()
        {
            //Declares a new arraylist
            ArrayList pickupCards = new ArrayList();
            //calls the getField function to get an arrayList of all the field cards
            pickupCards = getField();
            //clear the field
            field.Clear();
            return pickupCards;

        }

        /// <summary>
        /// Method used to display all the cards on the field
        /// </summary>
        public void displayField()
        {
            //loops through the field
            for (int i = 0; i < this.getField().Count; i++)
            {
                //displays the current card
                Card tempCard = (Card)this.getField()[i];
                Console.Write(tempCard.ToString());
                if (i != this.getField().Count - 1)
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
        /// Method used to display the discard pile
        /// </summary>
        public void displayDiscarded()
        {
            //loops through the discard pile
            for (int i = 0; i < this.getDiscard().Count; i++)
            {
                //displays the current card
                Card tempCard = (Card)this.getDiscard()[i];
                Console.Write(tempCard.ToString());
                if (i != this.getDiscard().Count - 1)
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
