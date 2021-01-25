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

    public partial class GameMenu : Form
    {

        public static GameMenu MainForm { get; private set; }

        public const int GameAreaWidth = 1025;
        public const int GameAreaHeight = 735;

        //background sound
        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();


        static GameMenu _obj;

        public static GameMenu Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new GameMenu();
                }
                return _obj;
            }
        }

          public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }


        public GameMenu()
        {
            MainForm = this;
            Height = GameAreaHeight;
            Width = GameAreaWidth;
            StartPosition = FormStartPosition.CenterScreen;
            
            InitializeComponent();
            wplayer.URL = (@"C:\Users\kimer\Source\Repos\BulletHell\BulletHell\Resources\backgroundSound.wav");
            wplayer.settings.volume = 30;
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();
        }

        private void GameMenu_Load(object sender, EventArgs e)
        {
            //Display MainControl menu when form loads
            _obj = this;

            MainControl mc = new MainControl();
            mc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(mc);
        }

        private void cancel_option_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["MainControl"].BringToFront();
        }

    }

}



