
namespace BulletHell
{
    partial class OptionControl
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
            this.option_menu = new System.Windows.Forms.Panel();
            this.btn_sound = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel_option = new System.Windows.Forms.PictureBox();
            this.option_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_option)).BeginInit();
            this.SuspendLayout();
            // 
            // option_menu
            // 
            this.option_menu.BackColor = System.Drawing.Color.Transparent;
            this.option_menu.BackgroundImage = global::BulletHell.Properties.Resources.border1;
            this.option_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.option_menu.Controls.Add(this.cancel_option);
            this.option_menu.Controls.Add(this.btn_sound);
            this.option_menu.Controls.Add(this.trackBar1);
            this.option_menu.Controls.Add(this.pictureBox2);
            this.option_menu.Controls.Add(this.pictureBox1);
            this.option_menu.Location = new System.Drawing.Point(38, 71);
            this.option_menu.Name = "option_menu";
            this.option_menu.Size = new System.Drawing.Size(948, 593);
            this.option_menu.TabIndex = 1;
            // 
            // btn_sound
            // 
            this.btn_sound.Image = global::BulletHell.Properties.Resources.sound_on;
            this.btn_sound.Location = new System.Drawing.Point(450, 270);
            this.btn_sound.Name = "btn_sound";
            this.btn_sound.Size = new System.Drawing.Size(50, 50);
            this.btn_sound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_sound.TabIndex = 3;
            this.btn_sound.TabStop = false;
            this.btn_sound.Click += new System.EventHandler(this.btn_sound_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.trackBar1.LargeChange = 3;
            this.trackBar1.Location = new System.Drawing.Point(342, 346);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(286, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BulletHell.Properties.Resources.soundText;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(355, 207);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 38);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BulletHell.Properties.Resources.optionTitle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(263, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cancel_option
            // 
            this.cancel_option.BackgroundImage = global::BulletHell.Properties.Resources.Cancel;
            this.cancel_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_option.Location = new System.Drawing.Point(411, 464);
            this.cancel_option.Name = "cancel_option";
            this.cancel_option.Size = new System.Drawing.Size(148, 40);
            this.cancel_option.TabIndex = 17;
            this.cancel_option.TabStop = false;
            this.cancel_option.Click += new System.EventHandler(this.cancel_option_Click);
            this.cancel_option.MouseLeave += new System.EventHandler(this.cancel_option_MouseLeave);
            this.cancel_option.MouseHover += new System.EventHandler(this.cancel_option_MouseHover);
            // 
            // OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.option_menu);
            this.Name = "OptionControl";
            this.Size = new System.Drawing.Size(1025, 735);
            this.option_menu.ResumeLayout(false);
            this.option_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_option)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel option_menu;
        private System.Windows.Forms.PictureBox btn_sound;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cancel_option;
    }
}
