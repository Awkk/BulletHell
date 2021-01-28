
using System;
using System.Drawing;

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
            this.lblTimer = new System.Windows.Forms.Label();
            this.deathScreenControl1 = new BulletHell.DeathScreenControl();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(470, 26);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(192, 44);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "0 seconds";
            // 
            // deathScreenControl1
            // 
            this.deathScreenControl1.BackColor = System.Drawing.Color.Transparent;
            this.deathScreenControl1.Location = new System.Drawing.Point(0, -1);
            this.deathScreenControl1.Margin = new System.Windows.Forms.Padding(6);
            this.deathScreenControl1.Name = "deathScreenControl1";
            this.deathScreenControl1.Size = new System.Drawing.Size(700, 700);
            this.deathScreenControl1.TabIndex = 1;
            this.deathScreenControl1.Visible = false;
            // 
            // GameArea
            // 
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.deathScreenControl1);
            this.Name = "GameArea";
            this.Text = "BulletHell";
            this.Load += new System.EventHandler(this.GameArea_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameArea_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private DeathScreenControl deathScreenControl1;
    }
}

