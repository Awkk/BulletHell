using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;

namespace BulletHell {
    public partial class MainControl : UserControl {

        private SoundPlayer buttonSound;
        public MainControl() {
            InitializeComponent();
            buttonSound = new SoundPlayer(GetResoucePath("buttonSound.wav"));
        }

        private string GetResoucePath(string file) {
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);
            return Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(currentPath)), "Resources", file);
        }


        //Menu pictureBox mouse hover/leave effect
        private void add_option_MouseHover(object sender, EventArgs e) {
            add_option.Image = Properties.Resources.AddServerHighlight;

            buttonSound.Play();
        }

        private void join_option_MouseHover(object sender, EventArgs e) {
            join_option.Image = Properties.Resources.JoinServerHighlight;

            buttonSound.Play();
        }

        private void options_option_MouseHover(object sender, EventArgs e) {
            options_option.Image = Properties.Resources.OptionsHighlight;

            buttonSound.Play();
        }


        private void quit_option_MouseHover(object sender, EventArgs e) {
            quit_option.Image = Properties.Resources.QuitHighlight;

            buttonSound.Play();
        }

        private void add_option_MouseLeave(object sender, EventArgs e) {
            add_option.Image = Properties.Resources.AddServer;


        }

        private void join_option_MouseLeave(object sender, EventArgs e) {
            join_option.Image = Properties.Resources.JoinServer;


        }

        private void options_option_MouseLeave(object sender, EventArgs e) {
            options_option.Image = Properties.Resources.OptionsOption;



        }
        private void quit_option_MouseLeave(object sender, EventArgs e) {
            quit_option.Image = Properties.Resources.QuitOption;


        }

        private void options_option_Click(object sender, EventArgs e) {
            if (!GameMenu.Instance.PnlContainer.Controls.ContainsKey("OptionControl")) {
                OptionControl oc = new OptionControl();
                oc.Dock = DockStyle.Fill;
                GameMenu.Instance.PnlContainer.Controls.Add(oc);
            }
            GameMenu.Instance.PnlContainer.Controls["OptionControl"].BringToFront();
        }

        private void quit_option_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void add_option_Click(object sender, EventArgs e) {
            if (!GameMenu.Instance.PnlContainer.Controls.ContainsKey("AddServerControl"))
            {
                AddServerControl asc = new AddServerControl();
                asc.Dock = DockStyle.Fill;
                GameMenu.Instance.PnlContainer.Controls.Add(asc);
            }
            GameMenu.Instance.PnlContainer.Controls["AddServerControl"].BringToFront();
        }

        private void join_option_Click(object sender, EventArgs e)
        {
            if (!GameMenu.Instance.PnlContainer.Controls.ContainsKey("JoinServerControl"))
            {
                JoinServerControl jsc = new JoinServerControl();
                jsc.Dock = DockStyle.Fill;
                GameMenu.Instance.PnlContainer.Controls.Add(jsc);
            }
            GameMenu.Instance.PnlContainer.Controls["JoinServerControl"].BringToFront();
        }
    }


}
