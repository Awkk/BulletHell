using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BulletHell {

    public partial class DeathScreenControl : UserControl {
        private SoundPlayer buttonSound;

        private string GetResoucePath(string file) {
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);
            return Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(currentPath)), "Resources", file);
        }
        public DeathScreenControl() {
            InitializeComponent();
            buttonSound = new SoundPlayer(GetResoucePath("buttonSound.wav"));
            text_gameover.BackColor = Color.Transparent;
        }

        private void text_mm_Click(object sender, EventArgs e) {
            ((Form)TopLevelControl).Close();
        }

        private void text_quit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void text_mm_MouseHover(object sender, EventArgs e) {
            buttonSound.Play();
        }

        private void text_mm_MouseLeave(object sender, EventArgs e) {

        }

        private void quit_text_MouseHover(object sender, EventArgs e) {

            buttonSound.Play();
        }

        private void quit_text_MouseLeave(object sender, EventArgs e) {

        }

        private void DeathScreenControl_Load(object sender, EventArgs e) {
            
        }

        protected override void OnPaintBackground(PaintEventArgs e) {
            //empty implementation
        }
    }
}
