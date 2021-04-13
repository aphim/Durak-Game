/*  Project: OOP 4200: Durak Project
 *  Author: Jacky Yuan
 *          Ashok Sasitharan
 *          Andre Agrippa
 *          
 *  Desc:   This page was made with reference to the tutorial 8 of OOP 4200 from Durham College
 *          The purpose of this page is to generate cardbox objects that can be used in the graphical
 *          interface of the Durak Project.
 * 
 * The Card images were all taken from this website below:
 *http://acbl.mybigcommerce.com/52-playing-cards/
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ch10CardLib;

namespace CardBox
{
    public partial class CardBox: UserControl
    {

        private Card myCard;
        /// <summary>
        /// Mutators for Card object
        /// </summary>
        public Card Card
        {
            set
            { 
                myCard = value;
                UpdateCardImage();
            }
            get { return myCard; }
        }

        /// <summary>
        /// Mutators for Suit enum
        /// </summary>
        public Suit Suit
        {
            set
            {
                Card.suit = value;
                UpdateCardImage();
            }
            get { return Card.suit; }
        }
        /// <summary>
        /// Mutators for Rank enum
        /// </summary>
        public Rank rank
        {
            set
            {
                Card.rank = value;
                UpdateCardImage();
            }
            get { return Card.rank; }
        }
        /// <summary>
        /// Mutators for FaceUp property
        /// </summary>
        public bool FaceUp
        {
            set
            {
                if (myCard.FaceUp != value)
                {
                    myCard.FaceUp = value;
                    UpdateCardImage();

                    if (CardFlipped != null)
                        CardFlipped(this, new EventArgs());
                }
            }
            get { return Card.FaceUp; }
        }

        //Cardbox orientation property (size, width, rotate)
        private Orientation myOrientation;
        /// <summary>
        /// Mutators for orientation property
        /// </summary>
        public Orientation CardOrientation
        {
            set
            {             
                if (myOrientation != value)
                {
                    myOrientation = value;
                    this.Size = new Size(Size.Height, Size.Width);
                    UpdateCardImage();
                }
            }
            get { return myOrientation; }
        }

        /// <summary>
        /// Function to update the card image
        /// </summary>
        private void UpdateCardImage()
        {
            pbMyPictureBox.Image = myCard.GetCardImage();

            if(myOrientation == Orientation.Horizontal)
            {
                pbMyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
        }
        /// <summary>
        /// Default constructor for CardBox
        /// </summary>
        public CardBox()
        {
            InitializeComponent();
            myOrientation = Orientation.Vertical;
            myCard = new Card();
            UpdateCardImage();
        }

        /// <summary>
        /// Parameterized constructor for CardBox
        /// </summary>
        /// <param name="card">Specified Card</param>
        /// <param name="orientation">Specified orientation of the card, default vertical</param>
        public CardBox(Card card, Orientation orientation = Orientation.Vertical)
        {
            InitializeComponent();
            myOrientation = orientation;
            myCard = card;
        }

        #region Events and Event handlers
        /// <summary>
        /// On CardBox object load, update the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardBox_Load(object sender, EventArgs e)
        {
            UpdateCardImage();
        }

        //Event handlers for CardBox Object, on click and on card flipped
        new public event EventHandler Click;
        public event EventHandler CardFlipped;

        #endregion

        #region other methods
        /// <summary>
        /// Overridden to String
        /// </summary>
        /// <returns>Card suit and value string</returns>
        public override string ToString()
        {
            return myCard.ToString();
        }


        #endregion

        /// <summary>
        /// Event for picture box click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbMyPictureBox_Click(object sender, EventArgs e)
        {
            if (Click != null)
                Click(this, e);
        }
    }
}
