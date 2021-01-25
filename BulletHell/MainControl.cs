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
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }


        //Menu pictureBox mouse hover/leave effect
        private void add_option_MouseHover(object sender, EventArgs e)
        {
            add_option.Image = Properties.Resources.AddServerHighlight;

            //System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            //System.IO.Stream s = a.GetManifestResourceStream("<AssemblyName>.chimes.wav");
            //SoundPlayer player = new SoundPlayer(s);
            //player.Play();

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\kimer\Source\Repos\BulletHell\BulletHell\Resources\buttonSound.wav");
            sound.Play();
        }

        private void join_option_MouseHover(object sender, EventArgs e)
        {
            join_option.Image = Properties.Resources.JoinServerHighlight;

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\kimer\Source\Repos\BulletHell\BulletHell\Resources\buttonSound.wav");
            sound.Play();
        }

        private void options_option_MouseHover(object sender, EventArgs e)
        {
            options_option.Image = Properties.Resources.OptionsHighlight;

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\kimer\Source\Repos\BulletHell\BulletHell\Resources\buttonSound.wav");
            sound.Play();
        }


        private void quit_option_MouseHover(object sender, EventArgs e)
        {
            quit_option.Image = Properties.Resources.QuitHighlight;

            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\kimer\Source\Repos\BulletHell\BulletHell\Resources\buttonSound.wav");
            sound.Play();
        }

        private void add_option_MouseLeave(object sender, EventArgs e)
        {
            add_option.Image = Properties.Resources.AddServer;


        }

        private void join_option_MouseLeave(object sender, EventArgs e)
        {
            join_option.Image = Properties.Resources.JoinServer;


        }

        private void options_option_MouseLeave(object sender, EventArgs e)
        {
            options_option.Image = Properties.Resources.OptionsOption;



        }
        private void quit_option_MouseLeave(object sender, EventArgs e)
        {
            quit_option.Image = Properties.Resources.QuitOption;


        }

        private void add_option_MouseClick(object sender, MouseEventArgs e)
        {
           
            GameArea game = new GameArea();
            game.Show();
        }

        private void options_option_Click(object sender, EventArgs e)
        {

            if (!GameMenu.Instance.PnlContainer.Controls.ContainsKey("OptionControl"))
            {
                OptionControl oc = new OptionControl();
                oc.Dock = DockStyle.Fill;
                GameMenu.Instance.PnlContainer.Controls.Add(oc);
            }
            GameMenu.Instance.PnlContainer.Controls["OptionControl"].BringToFront();
        }


        private void quit_option_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_option_Click(object sender, EventArgs e)
        {
         
        }

        
    }


}
