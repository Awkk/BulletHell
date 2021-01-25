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
    public partial class OptionControl : UserControl
    {
        public OptionControl()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            GameMenu.wplayer.controls.play();
            GameMenu.wplayer.settings.volume = trackBar1.Value;

            if (trackBar1.Value == 0)
            {
                btn_sound.Image = Properties.Resources.sound_off;
            }
            else
            {
                btn_sound.Image = Properties.Resources.sound_on;
            }
        }

        private void btn_sound_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value > 0)
            {
                GameMenu.wplayer.settings.volume = 0;
                btn_sound.Image = Properties.Resources.sound_off;

            }

        }


            private void cancel_option_MouseHover(object sender, EventArgs e)
        {
            cancel_option.Image = Properties.Resources.CancelHighlight;

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\kimer\Source\Repos\BulletHell\BulletHell\Resources\buttonSound.wav");
            sound.Play();
        }

        private void cancel_option_MouseLeave(object sender, EventArgs e)
        {
            cancel_option.Image = Properties.Resources.Cancel;


        }

        private void cancel_option_Click(object sender, EventArgs e)
        {
            GameMenu.Instance.PnlContainer.Controls["MainControl"].BringToFront();
        }
    }

}
