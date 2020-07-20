namespace tSpritePadder
{
    partial class ImageForm
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseButton.Location = new System.Drawing.Point(206, 415);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Image
            // 
            this.Image.BackColor = System.Drawing.Color.GhostWhite;
            this.Image.Location = new System.Drawing.Point(13, 13);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(465, 396);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Image.TabIndex = 1;
            this.Image.TabStop = false;
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.CloseButton);
            this.Name = "ImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image";
            this.Load += new System.EventHandler(this.ImageForm_Load);
            this.Resize += new System.EventHandler(this.ImageForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.PictureBox Image;
    }
}