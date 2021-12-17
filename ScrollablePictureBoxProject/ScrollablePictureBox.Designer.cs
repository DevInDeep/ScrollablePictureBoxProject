
namespace ScrollablePictureBoxProject
{
    partial class ScrollablePictureBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPictureParen = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pnlPictureParen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPictureParen
            // 
            this.pnlPictureParen.AutoScroll = true;
            this.pnlPictureParen.Controls.Add(this.pictureBox);
            this.pnlPictureParen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPictureParen.Location = new System.Drawing.Point(0, 0);
            this.pnlPictureParen.Name = "pnlPictureParen";
            this.pnlPictureParen.Size = new System.Drawing.Size(629, 580);
            this.pnlPictureParen.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // ScrollablePictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPictureParen);
            this.Name = "ScrollablePictureBox";
            this.Size = new System.Drawing.Size(629, 580);
            this.pnlPictureParen.ResumeLayout(false);
            this.pnlPictureParen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPictureParen;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
