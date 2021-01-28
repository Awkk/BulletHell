
namespace BulletHell
{
    partial class DeathScreenControl
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
            this.quit_text = new System.Windows.Forms.PictureBox();
            this.text_mm = new System.Windows.Forms.PictureBox();
            this.text_gameover = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quit_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_mm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_gameover)).BeginInit();
            this.SuspendLayout();
            // 
            // quit_text
            // 
            this.quit_text.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.quit_text.BackgroundImage = global::BulletHell.Properties.Resources.quitText;
            this.quit_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quit_text.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit_text.Location = new System.Drawing.Point(754, 758);
            this.quit_text.Margin = new System.Windows.Forms.Padding(6);
            this.quit_text.Name = "quit_text";
            this.quit_text.Size = new System.Drawing.Size(144, 67);
            this.quit_text.TabIndex = 2;
            this.quit_text.TabStop = false;
            this.quit_text.Click += new System.EventHandler(this.text_quit_Click);
            this.quit_text.MouseLeave += new System.EventHandler(this.quit_text_MouseLeave);
            this.quit_text.MouseHover += new System.EventHandler(this.quit_text_MouseHover);
            // 
            // text_mm
            // 
            this.text_mm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_mm.BackgroundImage = global::BulletHell.Properties.Resources.mainMenuText;
            this.text_mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.text_mm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.text_mm.Location = new System.Drawing.Point(422, 758);
            this.text_mm.Margin = new System.Windows.Forms.Padding(6);
            this.text_mm.Name = "text_mm";
            this.text_mm.Size = new System.Drawing.Size(280, 67);
            this.text_mm.TabIndex = 1;
            this.text_mm.TabStop = false;
            this.text_mm.Click += new System.EventHandler(this.text_mm_Click);
            this.text_mm.MouseLeave += new System.EventHandler(this.text_mm_MouseLeave);
            this.text_mm.MouseHover += new System.EventHandler(this.text_mm_MouseHover);
            // 
            // text_gameover
            // 
            this.text_gameover.BackgroundImage = global::BulletHell.Properties.Resources.gameOverText;
            this.text_gameover.Location = new System.Drawing.Point(268, 400);
            this.text_gameover.Margin = new System.Windows.Forms.Padding(6);
            this.text_gameover.Name = "text_gameover";
            this.text_gameover.Size = new System.Drawing.Size(858, 179);
            this.text_gameover.TabIndex = 0;
            this.text_gameover.TabStop = false;
            // 
            // DeathScreenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quit_text);
            this.Controls.Add(this.text_mm);
            this.Controls.Add(this.text_gameover);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DeathScreenControl";
            this.Size = new System.Drawing.Size(1400, 1346);
            this.Load += new System.EventHandler(this.DeathScreenControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quit_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_mm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_gameover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox text_gameover;
        private System.Windows.Forms.PictureBox text_mm;
        private System.Windows.Forms.PictureBox quit_text;
    }
}
