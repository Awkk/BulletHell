
namespace BulletHell
{
    partial class JoinServerControl
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cancel2_option = new System.Windows.Forms.PictureBox();
            this.done_option = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cancel2_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.done_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(297, 334);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(399, 199);
            this.listBox1.TabIndex = 2;
            // 
            // cancel2_option
            // 
            this.cancel2_option.BackgroundImage = global::BulletHell.Properties.Resources.Cancel2;
            this.cancel2_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel2_option.Location = new System.Drawing.Point(298, 638);
            this.cancel2_option.Name = "cancel2_option";
            this.cancel2_option.Size = new System.Drawing.Size(399, 40);
            this.cancel2_option.TabIndex = 8;
            this.cancel2_option.TabStop = false;
            this.cancel2_option.Click += new System.EventHandler(this.cancel2_option_Click);
            this.cancel2_option.MouseLeave += new System.EventHandler(this.cancel2_option_MouseLeave);
            this.cancel2_option.MouseHover += new System.EventHandler(this.cancel2_option_MouseHover);
            // 
            // done_option
            // 
            this.done_option.BackgroundImage = global::BulletHell.Properties.Resources.Done;
            this.done_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.done_option.Location = new System.Drawing.Point(298, 578);
            this.done_option.Name = "done_option";
            this.done_option.Size = new System.Drawing.Size(399, 39);
            this.done_option.TabIndex = 7;
            this.done_option.TabStop = false;
            this.done_option.Click += new System.EventHandler(this.done_option_Click);
            this.done_option.MouseLeave += new System.EventHandler(this.done_option_MouseLeave);
            this.done_option.MouseHover += new System.EventHandler(this.done_option_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BulletHell.Properties.Resources.ServersList;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(428, 274);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 38);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BulletHell.Properties.Resources.JoinServerTitle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(220, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // JoinServerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cancel2_option);
            this.Controls.Add(this.done_option);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "JoinServerControl";
            this.Size = new System.Drawing.Size(1025, 735);
            ((System.ComponentModel.ISupportInitialize)(this.cancel2_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.done_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox cancel2_option;
        private System.Windows.Forms.PictureBox done_option;
    }
}
