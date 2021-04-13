/*  Project: OOP 4200: Durak Project
 *  Author: Jacky Yuan
 *          Ashok Sasitharan
 *          Andre Agrippa
 *          
 *  Desc:  This class is used for the AI logic for the game Durak.
 * 
 * The Card images were all taken from this website below:
 *http://acbl.mybigcommerce.com/52-playing-cards/
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10CardLib
{
    public class AI : Player
    {

        const int TURNSKIPPED = -1;


        //constructor for making an instance of an AI object
        public AI (string name) : base(name)
        {
            playerName = name;
        }

        /// <summary>
        /// this function checks which turn it is and directs it to the proper turn function
        /// </summary>
        /// <param name="TrumpCard">the current trump card object</param>
        /// <param name="PlayingField">the current playing field object</param>
        /// <param name="round">the string corresponding to the current round</param>
        /// <param name="perevodnoyFlag">the flag for whether it is in the turn swapped state</param>
        /// <returns>int corresponding to the index of the card in the player hand</returns>
        public int AITurnCycle(Card TrumpCard, Field PlayingField, string round, bool perevodnoyFlag)
        {
                const string ATTACKINITIAL = "initialTurn";
                const string ATTACKERTURN = "attacker";
                const string DEFENDERTURN = "defender";
            //Checks to see what state the game is currently in an calls the corresponding function
                if (round == ATTACKINITIAL)
                {
                    return AIAttackerInitialTurn(TrumpCard);
                }
                else if (round == ATTACKERTURN)
                {
                    return AIAttackerTurn(PlayingField, TrumpCard);
                }
                else if (round == DEFENDERTURN)
                {
                    return AIDefenderTurn(PlayingField, TrumpCard, perevodnoyFlag);
                }
                else
                {
                    return TURNSKIPPED;
                }
   
        }


        /// <summary>
        /// Method used to control the AI's decisions while making the initial attack (Will play the lowest value card)
        /// </summary>
        /// <param name="trumpCard">the current trump card object</param>
        /// <returns>int corresponding to the index of the card in the player hand</returns>
        public int AIAttackerInitialTurn(Card trumpCard)
        {

            ////////// CHECKS FOR THE LOWEST "VALUE" CARD IN THE HAND WITH TRUMP SUIT CARDS GETTING MORE VALUE THAN OTHER CARDS ///////////
            //sets the first card as the current lowest card 
            Card lowestCard = playerHand.GetCard(0);
            int lowestcardIndex = 0;

            //initialize the lowestcard value
            int lowestCardValue = lowestCard.value;

            //checks to see if the current card is of the trump suit and raises its value if it is
            if (lowestCard.suit.Equals(trumpCard.suit))
            {
                lowestCardValue = lowestCard.value + 36;
            }

            //loops through the hand
            for (int i = 1; i < playerHand.gethandSize(); i++)
            {
                //create a variable for the next card
                Card nextCard = playerHand.GetCard(i);

                //initialize the nextCardValue;
                int nextCardValue = nextCard.value;

                //checks to see if the next card is of the trump suit and raises its value if it is
                if (nextCard.suit.Equals(trumpCard.suit))
                {
                    nextCardValue = nextCard.value + 36;
                }

                //checks if the value of the new card is lower than the current card
                if (lowestCardValue > nextCardValue)
                {
                    //sets the lowest card to new card if new card is lower than current card
                    lowestCard = nextCard;
                    lowestCardValue = nextCardValue;
                    lowestcardIndex = i;
                }
            }

            //////////////////// Plays the lowest value card ///////////////////////////////

            //play the card onto the field (removing it from the hand)'
            //playingField.cardPlayed(playerHand.playCard(lowestcardIndex));
            return lowestcardIndex;

        }

        /// <summary>
        /// Method used to control the AI's decisions while making a standard attack turn.
        /// </summary>
        /// <param name="playingField">the current playing field object</param>
        /// <param name="trumpCard">the current trump card object</param>
        /// <returns>int corresponding to the index of the card in the player hand</returns>
        public int AIAttackerTurn(Field playingField, Card trumpCard)
        {

            //check the playingfield
            ArrayList validCards = new ArrayList();
            ArrayList validCardIndex = new ArrayList();
            bool passFlag = false;

            //loop through the hand of the AI
            for (int i = 0; i < playerHand.gethandSize(); i++)
            {
                //declare a temp card as the current card
                Card tempCard = (Card)playerHand.GetCard(i);
                int tempCardIndex = i;

                //loop through the field
                for (int j = 0; j < playingField.getField().Count; j++)
                {
                    //declares a card as the currently viewed field card
                    Card fieldCard = (Card)playingField.getField()[j];

                    //checks to see if the card is the same rank
                    if (fieldCard.isSameRank(tempCard))
                    {
                        //if the card is of the same rank, adds it to the validCards arrayList and breaks out of the current loop
                        validCards.Add(tempCard);
                        validCardIndex.Add(tempCardIndex);
                        break;
                    }

                }
            }

            ////////// Skips the turn if no cards are valid ////////////////////////

            //If there are no valid cards, setup bypass flag and defender win flag
            if (validCards.Count == 0)
            {
                passFlag = true;
            }


            /////// If moves are valid //////////////////////////////////////////

            //checks to see if there are any moves available
            if (passFlag == false)
            {
                //initialize some arraylists
                ArrayList trumpSuits = new ArrayList();
                ArrayList trumpSuitIndex = new ArrayList();

                ///////Sorts the valid Cards into trump cards and non trump cards//////////

                //loops through the vaild cards and finds the cards that are trump suits and the 
                //indexes assocaiated with them
                for (int i = 0; i < validCards.Count; i++)
                {
                    Card tempCard = (Card)validCards[i];
                    int tempIndex = (int)validCardIndex[i];

                    //if they are of the trump suits, move them to the trump suits arraylist
                    if (tempCard.suit == trumpCard.suit)
                    {
                        trumpSuits.Add(tempCard);
                        trumpSuitIndex.Add(tempIndex);
                        validCards.RemoveAt(i);
                        validCardIndex.RemoveAt(i);
                    }
                }

                //initialize the variables
                Card cardSelected = null;
                int indexSelected = 0;

                //////////Selects the to play first looking through the non trump cards and selecting the lowest//////
                //////////before looking at the trump cards and selecting the lowest.  ///////////////////////////////

                //if the validCards arraylist is greater than 0, looks for the the lowest card
                if (validCards.Count > 0)
                {
                    //sets the first card as the current lowest card 
                    cardSelected = (Card)validCards[0];
                    indexSelected = (int)validCardIndex[0];

                    //loops through the hand
                    for (int i = 0; i < validCards.Count; i++)
                    {
                        //checks if the value of the new card is lower than the current card
                        if (cardSelected.value > ((Card)validCards[i]).value)
                        {
                            //sets the lowest card to new card if new card is lower than current card 
                            cardSelected = (Card)validCards[i];
                            indexSelected = (int)validCardIndex[i];
                        }
                    }
                }
                //otherwise, checks the trumpsuits arraylist to find the lowest card there
                else if (trumpSuits.Count > 0)
                {
                    //sets the first card as the current lowest card 
                    cardSelected = (Card)trumpSuits[0];
                    indexSelected = (int)trumpSuitIndex[0];

                    //loops through the hand
                    for (int i = 0; i < trumpSuits.Count; i++)
                    {
                        //checks if the value of the new card is lower than the current card
                        if (cardSelected.value > ((Card)trumpSuits[i]).value)
                        {
                            //sets the lowest card to new card if new card is lower than current card
                            cardSelected = (Card)trumpSuits[i];
                            indexSelected = (int)trumpSuitIndex[i];
                        }
                    }
                }

                //play the card onto the field 
                // playingField.cardPlayed(playerHand.playCard(indexSelected));
                return indexSelected;
            }
            else
            {
                return TURNSKIPPED;
            }

        }


        /// <summary>
        /// This method controls the AI's descisions on a defender turn
        /// </summary>
        /// <param name="playingField">the current playing field object</param>
        /// <param name="trumpCard"> the current trump card object</param>
        /// <param name="perevodnoyFlag">the perevodnoyFlag</param>
        /// <returns>int corresponding to the index of the card in the player hand</returns>
        public int AIDefenderTurn(Field playingField, Card trumpCard, bool perevodnoyFlag)
        {

            this.playerHand.displayHand();
            ArrayList validCards = new ArrayList();
            ArrayList validCardIndex = new ArrayList();
            ArrayList equalRank = new ArrayList();
            ArrayList equalRankIndex = new ArrayList();
            bool passFlag = false;
            bool equalsTrump = false;
            //Find the last card played on the field by the attacker

            //check if the last placed card on the field is the same suit as the trump suit
            if (playingField.getCurrentCard().suit == trumpCard.suit)
            {
                equalsTrump = true;
            }


            //loop through ai hand ///////////////////////For turn swapping mechanic///////////////
            if (perevodnoyFlag == true)
            {
                for (int i = 0; i < playerHand.gethandSize(); i++)
                {
                    //declare a temp card as the current card
                    Card tempCard = (Card)playerHand.GetCard(i);
                    int tempCardIndex = i;

                    if (tempCard.rank == ((Card)playingField.getCurrentCard()).rank)
                    {
                        equalRank.Add((Card)playerHand.GetCard(i));
                        equalRankIndex.Add(tempCardIndex);
                    }
                }

                //if there are matching cards
                if (equalRank.Count > 0)
                {
                    //check to see if there are more than one match
                    if (equalRank.Count > 1)
                    {
                        Card equalCard = (Card)equalRank[0];
                        int equalCardIndex = 0;

                        for (int i = 0; i < equalRank.Count; i++)
                        {
                            //check for if any of the cards are trump suit
                            if (((Card)equalRank[i]).suit != trumpCard.suit)
                            {
                                equalCard = (Card)equalRank[i];
                                equalCardIndex = (int)equalRankIndex[i];
                            }
                        }
                        return equalCardIndex;
                    }
                    else
                    {
                        return (int)equalRankIndex[0];
                    }
                }

            }

            //////////////////////////////////////////////////////////////////////////////////////////
            //loop through ai hand
            for (int i = 0; i < playerHand.gethandSize(); i++)
            {
                //declare a temp card as the current card
                Card tempCard = (Card)playerHand.GetCard(i);
                int tempCardIndex = i;

                //Run if the last placed card on the field is of the trump suit
                if (equalsTrump == true)
                {
                    //check if the suit of the current card in the hand has the same suit as the trump card and is higher in value than the last placed card
                    if (tempCard.suit == trumpCard.suit && tempCard.rank > playingField.getCurrentCard().rank)
                    {
                        //adds the card to the validCards arrayList and breaks out of the current loop
                        validCards.Add(tempCard);
                        validCardIndex.Add(tempCardIndex);
                    }

                }
                else//run if the last placed card was not a trump suit
                {
                    //run if the tempCard's suit is the same as the last placed card's suit is greater in value compared to the last placed card
                    if (tempCard.suit == playingField.getCurrentCard().suit && tempCard.rank > playingField.getCurrentCard().rank)
                    {
                        //adds the card to the validCards arrayList and breaks out of the current loop
                        validCards.Add(tempCard);
                        validCardIndex.Add(tempCardIndex);
                    }
                    //checks if the suit is the same as the trump suit
                    else if (tempCard.suit == trumpCard.suit)
                    {
                        //adds the card to the validCards arrayList and breaks out of the current loop
                        validCards.Add(tempCard);
                        validCardIndex.Add(tempCardIndex);
                    }

                }
            }

            ////////// Ends the turn if no cards are valid ////////////////////////

            //If there are no valid cards, setup bypass flag
            if (validCards.Count == 0)
            {
                passFlag = true;
            }
            else
            {
                passFlag = false;
            }

            /////// If moves are valid //////////////////////////////////////////

            //checks to see if there are any moves available
            if (passFlag == false)
            {
                //initialize some arraylists
                ArrayList trumpSuits = new ArrayList();
                ArrayList trumpSuitIndex = new ArrayList();

                ///////Sorts the valid Cards into trump cards and non trump cards//////////

                //initialize the variables
                Card cardSelected = null;
                int indexSelected = 0;

                //If the last card played is a trump card
                if (equalsTrump == true)
                {
                    //sets cardSelected as the first card in the arrayList
                    cardSelected = (Card)validCards[0];
                    indexSelected = (int)validCardIndex[0];

                    //loops through the hand
                    for (int i = 0; i < validCards.Count; i++)
                    {

                        //checks if the value of the cardSelected is greater than the value of the next card in the array
                        if (cardSelected.rank > ((Card)validCards[i]).rank)
                        {
                            //set cardSelected to the current card in the arrayList
                            cardSelected = (Card)validCards[i];
                            indexSelected = (int)validCardIndex[i];
                        }
                    }
                    return indexSelected;
                }
                else// run if the last card played was not a trump card
                {
                    //loops through the hand
                    for (int i = 0; i < validCards.Count; i++)
                    {
                        //seperates the trump cards from the non-trump cards in the list of valid cards
                        if (((Card)validCards[0]).suit == trumpCard.suit)
                        {
                            trumpSuits.Add((Card)validCards[i]);
                            trumpSuitIndex.Add((int)validCardIndex[i]);
                            validCards.RemoveAt(i);
                            validCardIndex.RemoveAt(i);
                        }
                    }
                    //checks if there are any non-trump valid cards
                    if (validCards.Count > 0)
                    {
                        //set cardSelected to the current card in the arrayList
                        cardSelected = (Card)validCards[0];
                        indexSelected = (int)validCardIndex[0];

                        //loop through the hand
                        for (int i = 0; i < validCards.Count; i++)
                        {
                            //if the tempCard's suit is the same as the trump suit and the value is greater than the last placed card's value
                            if (cardSelected.rank > ((Card)validCards[i]).rank)
                            {
                                cardSelected = (Card)validCards[i];
                                indexSelected = (int)validCardIndex[i];
                            }

                        }

                    }
                    else
                    {
                        //set cardSelected to the current card in the arrayList
                        cardSelected = (Card)trumpSuits[0];
                        indexSelected = (int)trumpSuitIndex[0];

                        //loop through the hand
                        for (int i = 0; i < trumpSuits.Count; i++)
                        {
                            //if the tempCard's suit is the same as the trump suit and the value is greater than the last placed card's value
                            if (cardSelected.rank > ((Card)trumpSuits[i]).rank)
                            {
                                cardSelected = (Card)trumpSuits[i];
                                indexSelected = (int)trumpSuitIndex[i];
                            }

                        }
                    }
                    return indexSelected;
                }
            }
            else
            {
                return TURNSKIPPED;
            }


        }//END OF DEFENDER METHOD







    }
}
