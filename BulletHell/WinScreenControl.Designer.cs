
namespace BulletHell
{
    partial class WinScreenControl
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
            this.components = new System.ComponentModel.Container();
            this.text_Win = new System.Windows.Forms.PictureBox();
            this.quit_text = new System.Windows.Forms.PictureBox();
            this.text_mm = new System.Windows.Forms.PictureBox();
            this.blink_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.text_Win)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quit_text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_mm)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Win
            // 
            this.text_Win.BackgroundImage = global::BulletHell.Properties.Resources.youWinText;
            this.text_Win.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.text_Win.Location = new System.Drawing.Point(314, 216);
            this.text_Win.Name = "text_Win";
            this.text_Win.Size = new System.Drawing.Size(341, 95);
            this.text_Win.TabIndex = 0;
            this.text_Win.TabStop = false;
            // 
            // quit_text
            // 
            this.quit_text.BackgroundImage = global::BulletHell.Properties.Resources.quitText;
            this.quit_text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quit_text.Location = new System.Drawing.Point(525, 404);
            this.quit_text.Name = "quit_text";
            this.quit_text.Size = new System.Drawing.Size(72, 35);
            this.quit_text.TabIndex = 4;
            this.quit_text.TabStop = false;
            this.quit_text.Click += new System.EventHandler(this.text_quit_Click);
            // 
            // text_mm
            // 
            this.text_mm.BackgroundImage = global::BulletHell.Properties.Resources.mainMenuText;
            this.text_mm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.text_mm.Location = new System.Drawing.Point(358, 404);
            this.text_mm.Name = "text_mm";
            this.text_mm.Size = new System.Drawing.Size(140, 35);
            this.text_mm.TabIndex = 3;
            this.text_mm.TabStop = false;
            this.text_mm.Click += new System.EventHandler(this.text_mm_Click);
            // 
            // blink_timer
            // 
            this.blink_timer.Interval = 1000;
            // 
            // WinScreenControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.quit_text);
            this.Controls.Add(this.text_mm);
            this.Controls.Add(this.text_Win);
            this.Name = "WinScreenControl";
            this.Size = new System.Drawing.Size(1025, 735);
            ((System.ComponentModel.ISupportInitialize)(this.text_Win)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quit_text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_mm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox text_Win;
        private System.Windows.Forms.PictureBox quit_text;
        private System.Windows.Forms.PictureBox text_mm;
        private System.Windows.Forms.Timer blink_timer;
    }
}
