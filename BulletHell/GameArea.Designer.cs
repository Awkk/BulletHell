
using System;

namespace BulletHell {
    partial class GameArea {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.deathScreenControl1 = new BulletHell.DeathScreenControl();
            this.SuspendLayout();
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 1000;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Miriam Mono CLM", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTimer.Location = new System.Drawing.Point(531, 26);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(109, 21);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "0 seconds";
            // 
            // deathScreenControl1
            // 
            this.deathScreenControl1.BackColor = System.Drawing.Color.Transparent;
            this.deathScreenControl1.Location = new System.Drawing.Point(-9, -29);
            this.deathScreenControl1.Name = "deathScreenControl1";
            this.deathScreenControl1.Size = new System.Drawing.Size(700, 700);
            this.deathScreenControl1.TabIndex = 1;
            this.deathScreenControl1.Visible = false;
            // 
            // GameArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.deathScreenControl1);
            this.Name = "GameArea";
            this.Text = "8";
            this.Load += new System.EventHandler(this.GameArea_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameArea_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblTimer;
        private DeathScreenControl deathScreenControl1;
    }
}

