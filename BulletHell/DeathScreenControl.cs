using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletHell
{
    public partial class DeathScreenControl : UserControl
    {
        public DeathScreenControl()
        {
            InitializeComponent();
            blink_timer.Start();

        }

        private void blink_Tick(object sender, EventArgs e)
        {
            text_gameover.Visible = !text_gameover.Visible;
        }

        private void text_mm_Click(object sender, EventArgs e)
        {
            GameMenu.Instance.PnlContainer.Controls["MainControl"].BringToFront();

        }

        private void text_quit_Click (object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
