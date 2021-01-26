﻿using System;
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

        public const int GameAreaWidth = 700;
        public const int GameAreaHeight = 700;

        private readonly Game game;

        private Form menu;
        Stopwatch sw;
        Timer timer;
        public GameArea(Form menu, string txtAddr1, int txtPort1) {

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

            sw = new Stopwatch();

            StopwatchUsingMethod();

            Renderer renderer = new Renderer();
            GameTime.Tick += new EventHandler(renderer.Update);

            game = new Game(this);

            // Backgroud thread listening for packets

            string txtAddress = txtAddr1;
            int txtPort = txtPort1;


            IListener listener = new UDPListener(txtAddress, txtPort);
            listener.MessageRecieved += new MessageRecievedHandler(MessageRecieved);

            Thread recieveMessageThread = new Thread(new ThreadStart(listener.ReceiveMessage)) {
                IsBackground = true
            };
            recieveMessageThread.Start();

            ISender sender = new UDPSender(txtAddress, txtPort);
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
            sw.Stop();
            game.GameOver();
            UDPListener.Done = true;
            menu.Show();
        }

        private void GameArea_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space) {
                Server.SendGameStart();
            }
        }

        public void UpdateTime(object sender, EventArgs e) {
            LabelSurvived.Text = "Survived: " + StopWatch.Elapsed.TotalSeconds + " s";
        }

        public void setDeathControlVisible(Boolean flag)
        {
            this.deathScreenControl1.Visible = flag;
            TimeSpan timeTaken = sw.Elapsed;
            string foo = "Time taken before death: " + timeTaken.ToString(@"m\:ss\.fff") + " seconds";
            deathScreenControl1.showResults(foo);
        }
        
        public void StopwatchUsingMethod()
        {
            timer = new Timer();
            timer.Interval = (1000);
            timer.Tick += new EventHandler(timer_Tick);
            sw = new Stopwatch();
            timer.Start();
            sw.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = sw.Elapsed.Seconds.ToString() + " seconds";
            Application.DoEvents();
        }

        //Messagebox is spammed due to GameOver state being spammed
        public void StopwatchUsingMethod1()
        {
            timer.Stop();
            sw.Stop();
                              }
    }
   }

