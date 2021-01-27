
namespace BulletHell
{
    partial class WebPlayControl
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cancel2_option = new System.Windows.Forms.PictureBox();
            this.done_option = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textAddr = new wmgCMS.WaterMarkTextBox();
            this.textPort = new wmgCMS.WaterMarkTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel2_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.done_option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::BulletHell.Properties.Resources.ServerPortText;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(403, 395);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(182, 38);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BulletHell.Properties.Resources.ServerAddress;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(378, 263);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 38);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // cancel2_option
            // 
            this.cancel2_option.BackgroundImage = global::BulletHell.Properties.Resources.Cancel2;
            this.cancel2_option.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel2_option.Location = new System.Drawing.Point(298, 611);
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
            this.done_option.Location = new System.Drawing.Point(298, 551);
            this.done_option.Name = "done_option";
            this.done_option.Size = new System.Drawing.Size(399, 39);
            this.done_option.TabIndex = 7;
            this.done_option.TabStop = false;
            this.done_option.Click += new System.EventHandler(this.done_option_Click);
            this.done_option.MouseLeave += new System.EventHandler(this.done_option_MouseLeave);
            this.done_option.MouseHover += new System.EventHandler(this.done_option_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BulletHell.Properties.Resources.OnlinePlayText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(215, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(569, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textAddr
            // 
            this.textAddr.BackColor = System.Drawing.Color.White;
            this.textAddr.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.textAddr.ForeColor = System.Drawing.Color.Black;
            this.textAddr.Location = new System.Drawing.Point(324, 324);
            this.textAddr.Name = "textAddr";
            this.textAddr.Size = new System.Drawing.Size(340, 33);
            this.textAddr.TabIndex = 13;
            this.textAddr.Text = "localhost";
            this.textAddr.WaterMarkColor = System.Drawing.Color.Gray;
            this.textAddr.WaterMarkText = "eg. 224.168.100.2";
            this.textAddr.TextChanged += new System.EventHandler(this.textAddr_TextChanged);
            // 
            // textPort
            // 
            this.textPort.BackColor = System.Drawing.Color.White;
            this.textPort.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold);
            this.textPort.ForeColor = System.Drawing.Color.Black;
            this.textPort.Location = new System.Drawing.Point(324, 456);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(340, 33);
            this.textPort.TabIndex = 14;
            this.textPort.Text = "8080";
            this.textPort.WaterMarkColor = System.Drawing.Color.Gray;
            this.textPort.WaterMarkText = "eg. 11000";
            this.textPort.TextChanged += new System.EventHandler(this.textPort_TextChanged);
            // 
            // WebPlayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textAddr);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cancel2_option);
            this.Controls.Add(this.done_option);
            this.Controls.Add(this.pictureBox1);
            this.Name = "WebPlayControl";
            this.Size = new System.Drawing.Size(1025, 735);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel2_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.done_option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox cancel2_option;
        private System.Windows.Forms.PictureBox done_option;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private wmgCMS.WaterMarkTextBox textAddr;
        private wmgCMS.WaterMarkTextBox textPort;
    }
}
