namespace DurakFormApp
{
    partial class frmDiscard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnDiscard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnDiscard
            // 
            this.pnDiscard.Location = new System.Drawing.Point(12, 12);
            this.pnDiscard.Name = "pnDiscard";
            this.pnDiscard.Size = new System.Drawing.Size(767, 426);
            this.pnDiscard.TabIndex = 0;
            // 
            // frmDiscard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnDiscard);
            this.Name = "frmDiscard";
            this.Text = "Discard Pile";
            this.Load += new System.EventHandler(this.frmDiscard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDiscard;
    }
}