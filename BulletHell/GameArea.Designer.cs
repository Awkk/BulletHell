
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
            this.LabelSurvived = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelSurvived
            // 
            this.LabelSurvived.AutoSize = true;
            this.LabelSurvived.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.LabelSurvived.Location = new System.Drawing.Point(550, 20);
            this.LabelSurvived.Name = "LabelSurvived";
            this.LabelSurvived.TabIndex = 1;
            this.LabelSurvived.ForeColor = Color.White;
            // 
            // GameArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.LabelSurvived);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GameArea";
            this.Text = "BulletHell";
            this.Load += new System.EventHandler(this.GameArea_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameArea_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelSurvived;
    }
}

