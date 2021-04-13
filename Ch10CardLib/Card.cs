/*  Project: OOP 4200: Durak Project
 *  Author: Jacky Yuan
 *          Ashok Sasitharan
 *          Andre Agrippa
 *          Roshan Persaud
 *          Manthan Amitkumar Shah
 *          
 *  Desc:  This class is used for the deck in CardLib based on the tutorials.
 * 
 *The Card images were all taken from this website below:
 *http://acbl.mybigcommerce.com/52-playing-cards/
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Ch10CardLib
{
    /// <summary>
    /// Card class
    /// </summary>
    public class Card
    {
        //calls the suit and rank enumerations
        public Suit suit;
        public Rank rank;

        public readonly int value;

        public static Suit trump;
        public static Rank trumpRank;

        protected bool faceUp = true;
        public bool FaceUp
        {
            get { return faceUp; }
            set { faceUp = value; }
        }

        /// <summary>
        /// parameterized constructor: Sets the suit and rank for the card object.
        /// </summary>
        /// <param name="newSuit">stores the suit of the card</param>
        /// <param name="newRank">stores the rank of the card</param>
        public Card(Suit newSuit, Rank newRank, int newValue)
        {
            suit = newSuit;
            rank = newRank;
            value = newValue;
        }

        /// <summary>
        /// Constructor that takes in a card and sets the current card to have the same suit, rank, and value
        /// </summary>
        /// <param name="card">the card object</param>
        public Card(Card card)
        {
            suit = card.suit;
            rank = card.rank;
            value = card.value;
        }


        /// <summary>
        /// Defualt constructor for cards.
        /// </summary>
        public Card()
        {

        }

        /// <summary>
        /// Overrides the tostring method for formatting the output of a card object.
        /// </summary>
        /// <returns>string displaying a card object</returns>
        public override string ToString()
        {
            return "The " + rank + " of " + suit;
        }



        //OPERATOR OVERLAODS

        /// <summary>
        /// Flag for trump usage If true, trumps are value higher thant cards of other suits
        /// </summary>
        /// 
        public static bool useTrumps = false;



        /// <summary>
        /// Overriden GetHashCode()
        /// </summary>
        /// <returns>the hash code of the card</returns>
        public override int GetHashCode()
        {
            return 13 * (int)suit + (int)rank;
        }

        /// <summary>
        /// Method that sets the trump suit to be equal to the trump card's suit
        /// </summary>
        /// <param name="trumpCard">the trump card obejct</param>
        public static void setTrumpSuit(Card trumpCard)
        {
            Suit trump = trumpCard.suit;

        }

        /// <summary>
        /// Method that returns the trump suit
        /// </summary>
        /// <returns>returns the trump card</returns>
        public Suit getTrumpSuit()
        {
            return trump;
        }

        /// <summary>
        /// method that sets the trump card's rank to be the rank of the trumpo card
        /// </summary>
        /// <param name="trumpCard">the current trump card</param>
        public static void setTrumpRank(Card trumpCard)
        {
            Rank trumpRank = trumpCard.rank;

        }

        /// <summary>
        /// Method used to obtain the rank of the trump card
        /// </summary>
        /// <returns>the rank of the current trump card</returns>
        public Rank getTrumpRank()
        {
            return trumpRank;
        }

        /// <summary>
        /// method used to check if the ranks of 2 cards are the same
        /// </summary>
        /// <param name="card1">a card object</param>
        /// <returns>true if they are the same rank or false if they are not</returns>
        public bool isSameRank(Card card1)
        {
            if (card1.rank == this.rank)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool isAceHigh = true;

        //OPERATOR OVERLOADS AND OVERRIDES
        /// <summary>
        /// Overriden == operator
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1.suit == card2.suit) && (card1.rank == card2.rank);
        }

        /// <summary>
        /// Gets the card image based on suit and rank
        /// </summary>
        /// <returns></returns>
        public Image GetCardImage()
        {
            string imageName;
            Image cardImage;

            if (!faceUp)
            {
                imageName = "purple_back";
            }
            else
            {
                imageName = suit.ToString() + "_" + rank.ToString();
            }
            cardImage = Properties.Resources.ResourceManager.GetObject(imageName) as Image;
            return cardImage;
        }


        /// <summary>
        /// Overriden != operator
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }

        /// <summary>
        /// Overriden Equals()
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public override bool Equals(object card)
        {
            return this == (Card)card;
        }




        /// <summary>
        /// Overloaded > operator
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static bool operator >(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        if (card2.rank == Rank.Ace)
                        {
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                        {
                            return false;
                        }
                        else
                        {
                            return (card1.rank > card2.rank);
                        }
                    }
                }
                else
                {
                    return (card1.rank > card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        /// <summary>
        /// Overloaded < operator
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static bool operator <(Card card1, Card card2)
        {
            return !(card1 >= card2);
        }

        /// <summary>
        /// Overloaded >= operator
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static bool operator >=(Card card1, Card card2)
        {
            if (card1.suit == card2.suit)
            {
                if (isAceHigh)
                {
                    if (card1.rank == Rank.Ace)
                    {
                        return true;
                    }
                    else
                    {
                        if (card2.rank == Rank.Ace)
                        {
                            return false;
                        }
                        else
                        {
                            return (card1.rank >= card2.rank);
                        }
                    }
                }
                else
                {
                    return (card1.rank >= card2.rank);
                }
            }
            else
            {
                if (useTrumps && (card2.suit == Card.trump))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        /// <summary>
        /// Overloaded <= operator
        /// </summary>
        /// <param name="card1"></param>
        /// <param name="card2"></param>
        /// <returns></returns>
        public static bool operator <=(Card card1, Card card2)
        {
            return !(card1 > card2);
        }

    }
}