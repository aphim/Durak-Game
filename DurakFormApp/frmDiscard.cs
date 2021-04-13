/*  Project: OOP 4200: Durak Project
 *  Author: Jacky Yuan
 *          Ashok Sasitharan
 *          Andre Agrippa
 *          Roshan Persaud
 *          Manthan Amitkumar Shah
 *          
 *  Desc:  This is the form and event handlers for the discard pile pop-up form.
 * 
 */

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ch10CardLib;

namespace DurakFormApp
{
    public partial class frmDiscard : Form
    {
        //initialize the discard pile display list
        public List<CardBox.CardBox> discardPile = new List<CardBox.CardBox>();
        //initialize the field
        public static Field field { get; set;}

        public frmDiscard()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the playing field updating playing field panel
        /// </summary>
        private void DisplayDiscardPile()
        {
            //initialize counters
            int counter = 0;
            int topOffset = 10;
            int displayCounter = 10;
            //populate the discardpile
            ArrayList discardedCards = field.getDiscard();
            //populate the display discard pile list
            for (int i = 0; i< discardedCards.Count ; i++)
            {
                CardBox.CardBox newCardBox = new CardBox.CardBox((Card)discardedCards[i]);
                discardPile.Add(newCardBox);
            }
            //offset the cards for display purposes (rows of ten cards)
            for (int i = discardedCards.Count - 1; i >= 0; i--)
            {
                discardPile[i].Left = (displayCounter * 20) + 100;
                discardPile[i].Top = topOffset;
                counter++;
                displayCounter--;
                //add the card with the current offset to the output
                this.pnDiscard.Controls.Add(discardPile[i]);
                //checks if the line is at 10 cards and change the offsets if it is
                if( counter > 9)
                {
                    topOffset = topOffset + 120;
                    counter = 0;
                    displayCounter = 10;
                }

            }
        }
        //calls the display discard pile on load
        private void frmDiscard_Load(object sender, EventArgs e)
        {
            DisplayDiscardPile();
        }
    }
}
