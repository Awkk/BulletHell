using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulletHell
{
    public partial class JoinServerControl : UserControl
    {



        private SoundPlayer buttonSound;
                
        public JoinServerControl()
        {
            InitializeComponent();
            buttonSound = new SoundPlayer(GetResoucePath("buttonSound.wav"));

        }
        private string GetResoucePath(string file)
        {
            string currentPath = Path.GetDirectoryName(Application.ExecutablePath);
            return Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(currentPath)), "Resources", file);
        }
        private void done_option_MouseHover(object sender, EventArgs e)
        {
            done_option.Image = Properties.Resources.DoneHighlight;
            buttonSound.Play();
        }

        private void done_option_MouseLeave(object sender, EventArgs e)
        {
            done_option.Image = Properties.Resources.Done;
        }

        private void cancel2_option_MouseHover(object sender, EventArgs e)
        {
            cancel2_option.Image = Properties.Resources.CancelHighlight2;
            buttonSound.Play();
        }

        private void cancel2_option_MouseLeave(object sender, EventArgs e)
        {
            cancel2_option.Image = Properties.Resources.Cancel2;
        }

        private void cancel2_option_Click(object sender, EventArgs e)
        {
            GameMenu.Instance.PnlContainer.Controls["MainControl"].BringToFront();
        }

        private void done_option_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textAddr.Text) || string.IsNullOrWhiteSpace(textPort.Text)) {
                MessageBox.Show("Please enter an IP Address and/or Port Number");
            }

            ParentForm.Hide();
            GameArea game = new GameArea(ParentForm, textAddr.Text, Int32.Parse(textPort.Text));
            game.Show();
        }

        //Just was testing with interface for more decoupled design 
        //private string TextAddr()
        //{
        //    return textAddr.Text;

        //}
        //public string TextPort()
        //{
        //    return textPort.Text;
        //}
        //public string TextBoxAddr
        //{
        //    get { return textBox1.Text; }
        //}
        //public string TextBoxPort
        //{
        //    get { return txtPort.Text; }
        //}
        //private void TextBoxAddr_TextChanged(object sender, EventArgs e)
        //{
        //    var textBoxContent = this.textBox1.Text;
        //    var parent = this.Parent as GameArea;
        //    parent.TextBoxAddr = TextBoxAddr;
        //}

        //private void TextBoxPort_TextChanged(object sender, EventArgs e)
        //{
        //    var textBoxContent = this.txtPort.Text;
        //    var parent = this.Parent as GameArea;
        //    parent.TextBoxAddr = TextBoxAddr;
        //}


        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    var textBoxContent = this.textAddr.Text;
        //    var parent = this.Parent as GameArea;
        //    parent.ID2 = ID2;
        //}
    }
}
