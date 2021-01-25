using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulletHell.Model;
using BulletHell.View;
using Network;
using UDP;
using Timer = System.Windows.Forms.Timer;

namespace BulletHell {


    public partial class GameArea : Form {
        public static GameArea MainForm { get; set; }
        public static Timer GameTime { get; set; }
        public static GameState State { get; set; }

        public const int GameAreaWidth = 1025;
        public const int GameAreaHeight = 720;

        private Game game;


        public GameArea() {
            InitializeComponent();
            FormClosing += new FormClosingEventHandler(GameArea_FormClosing);

            MainForm = this;
            Height = GameAreaHeight;
            Width = GameAreaWidth;
            StartPosition = FormStartPosition.CenterScreen;

            GameTime = new Timer {
                Interval = 10
            };

            Renderer renderer = new Renderer();
            GameTime.Tick += new EventHandler(renderer.Update);

            game = new Game();

            IListener listener = new UDPListener("224.168.100.2", 11000);
            listener.MessageRecieved += new MessageRecievedHandler(MessageRecieved);

            Thread recieveMessageThread = new Thread(new ThreadStart(listener.ReceiveMessage)) {
                IsBackground = true
            };

            recieveMessageThread.Start();
        }

        public static void MessageRecieved(object sender, string message) {
            Debug.WriteLine(message);
        }


        void ChangeCursor() {
            Bitmap bmp = new Bitmap(Properties.Resources.p1cursor);
            Cursor c = new Cursor(bmp.GetHicon());

            this.Cursor = c;
        }
        private void GameArea_Load(object sender, EventArgs e) {
        }

        private void GameArea_FormClosing(object sender, FormClosingEventArgs e) {
            game.GameOver();
        }

        private void GameArea_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Space) {
                game.Start();
            }
        }
    }


}
