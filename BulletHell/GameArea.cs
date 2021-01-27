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
using Network;
using UDP;
using Timer = System.Windows.Forms.Timer;

namespace BulletHell {


    public partial class GameArea : Form {
        public Timer GameTime { get; private set; }

        public GameServer Server { get; private set; }

        public Stopwatch StopWatch { get; set; }

        public const int GameAreaWidth = 700;
        public const int GameAreaHeight = 700;

        private readonly Game game;

        private IListener listener;

        private Form menu;
        public GameArea(Form menu, IListener listener, ISender sender) {

            InitializeComponent();

            FormClosing += new FormClosingEventHandler(GameArea_FormClosing);

            this.menu = menu;

            BackColor = Color.Black;

            Height = GameAreaHeight;
            Width = GameAreaWidth;
            StartPosition = FormStartPosition.CenterScreen;

            StopWatch = new Stopwatch();

            GameTime = new Timer {
                Interval = 10
            };

            GameTime.Tick += new EventHandler(UpdateTime);

            game = new Game(this);


            this.listener = listener;
            listener.MessageRecieved += new MessageRecievedHandler(MessageRecieved);

            Thread recieveMessageThread = new Thread(new ThreadStart(listener.ReceiveMessage)) {
                IsBackground = true
            };
            recieveMessageThread.Start();

            Server = new GameServer(game, sender);
        }


        public void MessageRecieved(object sender, string message) {
            Server.ProcessMessage(message);
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
            listener.Done = true;
            menu.Show();
        }

        private void GameArea_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                Server.SendGameStart();
            }
        }

        public void UpdateTime(object sender, EventArgs e) {
            lblTimer.Text = "Survived: " + StopWatch.Elapsed.TotalSeconds + " s";
        }

        public void SetDeathControlVisible(bool flag) {
            if (deathScreenControl1.InvokeRequired) {
                try {
                    deathScreenControl1.Invoke(new Action(() => deathScreenControl1.Visible = flag));
                } catch (ObjectDisposedException) {
                }
            } else {
                deathScreenControl1.Visible = flag;
            }
        }
    }
}

