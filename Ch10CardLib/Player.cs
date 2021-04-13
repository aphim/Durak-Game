/*  Project: OOP 4200: Durak Project
 *  Author: Jacky Yuan
 *          Ashok Sasitharan
 *          Andre Agrippa
 *          Roshan Persaud
 *          Manthan Amitkumar Shah
 *          
 *  Desc:  This class is used for the player in CardLib.
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
    public class Player
    {
        /// <summary>
        /// getter and setter for the playername attribute
        /// </summary>
        public string playerName { get; set; }

        /// <summary>
        /// getter and setter for the playerhand attribute
        /// </summary>
        public Hand playerHand { get; set; }


        /// <summary>
        /// Constructor for the player class, entering his name
        /// </summary>
        /// <param name="name">name of the player as a string</param>
        public Player(string name)
        {
            playerName = name;
        }

        /// <summary>
        /// Method used to draw cards from the deck
        /// </summary>
        /// <param name="myDeck">a deck object</param>
        public void DrawCards(Deck myDeck)
        {
            bool attackerDraw = true;
            string filePath = @"../../GameLog.txt";
            string tempString = "";
            //check the remaining deck size

            while (attackerDraw)
            {
                //check to see if there are still cards in the deck
                if (myDeck.getCardsRemaining() > 0)
                {
                    //check if the attacker's hand is greater than 6 (standard hand size)
                    int attackerHandSize = this.playerHand.gethandSize();
                    if (attackerHandSize < 6)
                    {
                        Card drawnCard = myDeck.drawCard();
                        tempString += " " + drawnCard.ToString();
                        //output what card the player drew
                     
                        this.playerHand.addCard(drawnCard);
                    

                    }
                    else
                    {
                        attackerDraw = false;

                    }
                }
                else
                {
                    attackerDraw = false;

                }
            }
            if(tempString != "")
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {

                    writer.WriteLine(this.playerName + " drew:" + tempString);

                }
            }
          

        }


    }
}
