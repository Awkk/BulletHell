
namespace BulletHell
{
    partial class MainControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainControl));
            this.main_menu = new System.Windows.Forms.Panel();
            this.bh_title = new System.Windows.Forms.Panel();
            this.quit_option = new System.Windows.Forms.PictureBox();
            this.options_option = new System.Windows.Forms.PictureBox();
            this.add_option = new System.Windows.Forms.PictureBox();
            this.join_option = new System.Windows.Forms.PictureBox();
            this.main_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quit_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.options_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.join_option)).BeginInit();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.BackColor = System.Drawing.Color.Transparent;
            this.main_menu.BackgroundImage = global::BulletHell.Properties.Resources.border1;
            this.main_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_menu.Controls.Add(this.bh_title);
            this.main_menu.Controls.Add(this.quit_option);
            this.main_menu.Controls.Add(this.options_option);
            this.main_menu.Controls.Add(this.add_option);
            this.main_menu.Controls.Add(this.join_option);
            this.main_menu.Location = new System.Drawing.Point(38, 71);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(948, 593);
            this.main_menu.TabIndex = 10;
            // 
            // bh_title
            // 
            this.bh_title.BackColor = System.Drawing.Color.Transparent;
            this.bh_title.BackgroundImage = global::BulletHell.Properties.Resources.bulletTitle;
            this.bh_title.Location = new System.Drawing.Point(17, 53);
            this.bh_title.Name = "bh_title";
            this.bh_title.Size = new System.Drawing.Size(913, 117);
            this.bh_title.TabIndex = 10;
            // 
            // quit_option
            // 
            this.quit_option.BackColor = System.Drawing.Color.Transparent;
            this.quit_option.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quit_option.BackgroundImage")));
            this.quit_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit_option.Image = ((System.Drawing.Image)(resources.GetObject("quit_option.Image")));
            this.quit_option.Location = new System.Drawing.Point(383, 473);
            this.quit_option.Name = "quit_option";
            this.quit_option.Size = new System.Drawing.Size(196, 39);
            this.quit_option.TabIndex = 10;
            this.quit_option.TabStop = false;
            this.quit_option.Click += new System.EventHandler(this.quit_option_Click);
            this.quit_option.MouseLeave += new System.EventHandler(this.quit_option_MouseLeave);
            this.quit_option.MouseHover += new System.EventHandler(this.quit_option_MouseHover);
            // 
            // options_option
            // 
            this.options_option.BackColor = System.Drawing.Color.Transparent;
            this.options_option.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("options_option.BackgroundImage")));
            this.options_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.options_option.Image = global::BulletHell.Properties.Resources.OptionsOption;
            this.options_option.Location = new System.Drawing.Point(383, 398);
            this.options_option.Name = "options_option";
            this.options_option.Size = new System.Drawing.Size(196, 41);
            this.options_option.TabIndex = 10;
            this.options_option.TabStop = false;
            this.options_option.Click += new System.EventHandler(this.options_option_Click);
            this.options_option.MouseLeave += new System.EventHandler(this.options_option_MouseLeave);
            this.options_option.MouseHover += new System.EventHandler(this.options_option_MouseHover);
            // 
            // add_option
            // 
            this.add_option.BackColor = System.Drawing.Color.Transparent;
            this.add_option.BackgroundImage = global::BulletHell.Properties.Resources.DirectConnectionText;
            this.add_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_option.Location = new System.Drawing.Point(382, 251);
            this.add_option.Name = "add_option";
            this.add_option.Size = new System.Drawing.Size(199, 39);
            this.add_option.TabIndex = 10;
            this.add_option.TabStop = false;
            this.add_option.Click += new System.EventHandler(this.add_option_Click);
            this.add_option.MouseLeave += new System.EventHandler(this.add_option_MouseLeave);
            this.add_option.MouseHover += new System.EventHandler(this.add_option_MouseHover);
            // 
            // join_option
            // 
            this.join_option.BackColor = System.Drawing.Color.Transparent;
            this.join_option.BackgroundImage = global::BulletHell.Properties.Resources.MultiplayerText;
            this.join_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.join_option.Image = global::BulletHell.Properties.Resources.MultiplayerText;
            this.join_option.Location = new System.Drawing.Point(383, 323);
            this.join_option.Name = "join_option";
            this.join_option.Size = new System.Drawing.Size(199, 41);
            this.join_option.TabIndex = 7;
            this.join_option.TabStop = false;
            this.join_option.Click += new System.EventHandler(this.join_option_Click);
            this.join_option.MouseLeave += new System.EventHandler(this.join_option_MouseLeave);
            this.join_option.MouseHover += new System.EventHandler(this.join_option_MouseHover);
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.main_menu);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(1025, 735);
            this.main_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quit_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.options_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.join_option)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_menu;
        private System.Windows.Forms.Panel bh_title;
        private System.Windows.Forms.PictureBox quit_option;
        private System.Windows.Forms.PictureBox options_option;
        private System.Windows.Forms.PictureBox add_option;
        private System.Windows.Forms.PictureBox join_option;
    }
}
