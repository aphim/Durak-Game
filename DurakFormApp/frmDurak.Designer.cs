namespace DurakFormApp
{
    partial class frmDurak
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Ch10CardLib.Card card5 = new Ch10CardLib.Card();
            Ch10CardLib.Card card6 = new Ch10CardLib.Card();
            this.lblDeckSize = new System.Windows.Forms.Label();
            this.lblDeckSizeValue = new System.Windows.Forms.Label();
            this.pnPlayerHand = new System.Windows.Forms.Panel();
            this.btnPlayCard = new System.Windows.Forms.Button();
            this.btnSkipTurn = new System.Windows.Forms.Button();
            this.lblCardSelected = new System.Windows.Forms.Label();
            this.pnPlayingField = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHowToPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDiscardPile = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.lblHand = new System.Windows.Forms.Label();
            this.cbTrumpCard = new CardBox.CardBox();
            this.cardBox1 = new CardBox.CardBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.pnAIHand = new System.Windows.Forms.Panel();
            this.chkAIHandToggle = new System.Windows.Forms.CheckBox();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnResetStats = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeckSize
            // 
            this.lblDeckSize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckSize.Location = new System.Drawing.Point(16, 310);
            this.lblDeckSize.Name = "lblDeckSize";
            this.lblDeckSize.Size = new System.Drawing.Size(105, 30);
            this.lblDeckSize.TabIndex = 1;
            this.lblDeckSize.Text = "Deck Size:";
            this.lblDeckSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeckSizeValue
            // 
            this.lblDeckSizeValue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckSizeValue.Location = new System.Drawing.Point(143, 307);
            this.lblDeckSizeValue.Name = "lblDeckSizeValue";
            this.lblDeckSizeValue.Size = new System.Drawing.Size(54, 31);
            this.lblDeckSizeValue.TabIndex = 3;
            this.lblDeckSizeValue.Text = "36";
            this.lblDeckSizeValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pnPlayerHand
            // 
            this.pnPlayerHand.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnPlayerHand.Location = new System.Drawing.Point(238, 431);
            this.pnPlayerHand.Name = "pnPlayerHand";
            this.pnPlayerHand.Size = new System.Drawing.Size(747, 109);
            this.pnPlayerHand.TabIndex = 4;
            // 
            // btnPlayCard
            // 
            this.btnPlayCard.Location = new System.Drawing.Point(140, 405);
            this.btnPlayCard.Name = "btnPlayCard";
            this.btnPlayCard.Size = new System.Drawing.Size(75, 23);
            this.btnPlayCard.TabIndex = 5;
            this.btnPlayCard.Text = "Play Card";
            this.btnPlayCard.UseVisualStyleBackColor = true;
            this.btnPlayCard.Click += new System.EventHandler(this.btnPlayCard_Click);
            // 
            // btnSkipTurn
            // 
            this.btnSkipTurn.Location = new System.Drawing.Point(140, 493);
            this.btnSkipTurn.Name = "btnSkipTurn";
            this.btnSkipTurn.Size = new System.Drawing.Size(75, 23);
            this.btnSkipTurn.TabIndex = 6;
            this.btnSkipTurn.Text = "Skip Turn";
            this.btnSkipTurn.UseVisualStyleBackColor = true;
            this.btnSkipTurn.Click += new System.EventHandler(this.btnSkipTurn_Click);
            // 
            // lblCardSelected
            // 
            this.lblCardSelected.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardSelected.Location = new System.Drawing.Point(538, 398);
            this.lblCardSelected.Name = "lblCardSelected";
            this.lblCardSelected.Size = new System.Drawing.Size(433, 30);
            this.lblCardSelected.TabIndex = 7;
            this.lblCardSelected.Text = "Card Selected:";
            this.lblCardSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPlayingField
            // 
            this.pnPlayingField.BackColor = System.Drawing.Color.Maroon;
            this.pnPlayingField.Location = new System.Drawing.Point(237, 176);
            this.pnPlayingField.Name = "pnPlayingField";
            this.pnPlayingField.Size = new System.Drawing.Size(748, 218);
            this.pnPlayingField.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Trump Card:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHowToPlay,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHowToPlay
            // 
            this.mnuHowToPlay.Name = "mnuHowToPlay";
            this.mnuHowToPlay.Size = new System.Drawing.Size(84, 20);
            this.mnuHowToPlay.Text = "How To Play";
            this.mnuHowToPlay.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnDiscardPile
            // 
            this.btnDiscardPile.Location = new System.Drawing.Point(140, 448);
            this.btnDiscardPile.Name = "btnDiscardPile";
            this.btnDiscardPile.Size = new System.Drawing.Size(75, 23);
            this.btnDiscardPile.TabIndex = 14;
            this.btnDiscardPile.Text = "Discard Pile";
            this.btnDiscardPile.UseVisualStyleBackColor = true;
            this.btnDiscardPile.Click += new System.EventHandler(this.btnDiscardPile_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(140, 358);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.Location = new System.Drawing.Point(622, 145);
            this.lblPlayerTurn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(110, 24);
            this.lblPlayerTurn.TabIndex = 18;
            this.lblPlayerTurn.Text = "Player turn";
            this.lblPlayerTurn.TextChanged += new System.EventHandler(this.lblPlayerTurn_TextChanged);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.Location = new System.Drawing.Point(241, 149);
            this.lblField.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(48, 20);
            this.lblField.TabIndex = 19;
            this.lblField.Text = "Field";
            // 
            // lblHand
            // 
            this.lblHand.AutoSize = true;
            this.lblHand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHand.Location = new System.Drawing.Point(241, 405);
            this.lblHand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHand.Name = "lblHand";
            this.lblHand.Size = new System.Drawing.Size(92, 20);
            this.lblHand.TabIndex = 20;
            this.lblHand.Text = "Your hand";
            // 
            // cbTrumpCard
            // 
            card5.FaceUp = false;
            this.cbTrumpCard.Card = card5;
            this.cbTrumpCard.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cbTrumpCard.FaceUp = false;
            this.cbTrumpCard.Location = new System.Drawing.Point(59, 72);
            this.cbTrumpCard.Margin = new System.Windows.Forms.Padding(4);
            this.cbTrumpCard.Name = "cbTrumpCard";
            this.cbTrumpCard.rank = Ch10CardLib.Rank.Seven;
            this.cbTrumpCard.Size = new System.Drawing.Size(92, 129);
            this.cbTrumpCard.Suit = Ch10CardLib.Suit.Diamonds;
            this.cbTrumpCard.TabIndex = 16;
            // 
            // cardBox1
            // 
            card6.FaceUp = false;
            this.cardBox1.Card = card6;
            this.cardBox1.CardOrientation = System.Windows.Forms.Orientation.Vertical;
            this.cardBox1.FaceUp = false;
            this.cardBox1.Location = new System.Drawing.Point(14, 358);
            this.cardBox1.Margin = new System.Windows.Forms.Padding(4);
            this.cardBox1.Name = "cardBox1";
            this.cardBox1.rank = Ch10CardLib.Rank.Seven;
            this.cardBox1.Size = new System.Drawing.Size(111, 175);
            this.cardBox1.Suit = Ch10CardLib.Suit.Diamonds;
            this.cardBox1.TabIndex = 15;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Location = new System.Drawing.Point(293, 154);
            this.lblErrorMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMsg.TabIndex = 23;
            // 
            // pnAIHand
            // 
            this.pnAIHand.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnAIHand.Location = new System.Drawing.Point(237, 22);
            this.pnAIHand.Name = "pnAIHand";
            this.pnAIHand.Size = new System.Drawing.Size(748, 109);
            this.pnAIHand.TabIndex = 24;
            // 
            // chkAIHandToggle
            // 
            this.chkAIHandToggle.AutoSize = true;
            this.chkAIHandToggle.Location = new System.Drawing.Point(59, 240);
            this.chkAIHandToggle.Margin = new System.Windows.Forms.Padding(2);
            this.chkAIHandToggle.Name = "chkAIHandToggle";
            this.chkAIHandToggle.Size = new System.Drawing.Size(102, 17);
            this.chkAIHandToggle.TabIndex = 25;
            this.chkAIHandToggle.Text = "Display AI Hand";
            this.chkAIHandToggle.UseVisualStyleBackColor = true;
            this.chkAIHandToggle.CheckedChanged += new System.EventHandler(this.chkAIHandToggle_CheckedChanged);
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(54, 209);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(100, 20);
            this.txtNameInput.TabIndex = 26;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnResetStats
            // 
            this.btnResetStats.Location = new System.Drawing.Point(59, 271);
            this.btnResetStats.Name = "btnResetStats";
            this.btnResetStats.Size = new System.Drawing.Size(75, 23);
            this.btnResetStats.TabIndex = 28;
            this.btnResetStats.Text = "Reset Stats";
            this.btnResetStats.UseVisualStyleBackColor = true;
            this.btnResetStats.Visible = false;
            this.btnResetStats.Click += new System.EventHandler(this.btnResetStats_Click);
            // 
            // frmDurak
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 555);
            this.Controls.Add(this.btnResetStats);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.chkAIHandToggle);
            this.Controls.Add(this.pnPlayingField);
            this.Controls.Add(this.pnAIHand);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.lblHand);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbTrumpCard);
            this.Controls.Add(this.cardBox1);
            this.Controls.Add(this.btnDiscardPile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCardSelected);
            this.Controls.Add(this.btnSkipTurn);
            this.Controls.Add(this.btnPlayCard);
            this.Controls.Add(this.pnPlayerHand);
            this.Controls.Add(this.lblDeckSizeValue);
            this.Controls.Add(this.lblDeckSize);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDurak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Durak";
            this.Load += new System.EventHandler(this.frmDurak_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDeckSize;
        private System.Windows.Forms.Label lblDeckSizeValue;
        private System.Windows.Forms.Panel pnPlayerHand;
        private System.Windows.Forms.Button btnPlayCard;
        private System.Windows.Forms.Button btnSkipTurn;
        private System.Windows.Forms.Label lblCardSelected;
        private System.Windows.Forms.Panel pnPlayingField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHowToPlay;
        private System.Windows.Forms.Button btnDiscardPile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private CardBox.CardBox cbTrumpCard;
        private CardBox.CardBox cardBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblHand;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Panel pnAIHand;
        private System.Windows.Forms.CheckBox chkAIHandToggle;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnResetStats;
    }
}

