using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulletHell.Controller;
using System.Diagnostics;

namespace BulletHell.Model {
    public class Game {
        public GameObject Player { get; set; }
        public GameArea GameArea { get; set; }

        public Game(GameArea gameArea) {
            this.GameArea = gameArea;
            gameArea.GameTime.Enabled = true;

            Player = new Player();
            AddGameObject(Player, new FollowCursor());
        }
        public void Start() {
            GameArea.StopWatch.Start();

            int top = 10, left = 10, right = GameArea.Width - 50, bottom = GameArea.Height - 50;

            // Top
            AddGameObject(new Bullet(this) {
                Location = new Point(50, top)
            }, new BounceOffWall(2, 2));
            AddGameObject(new Bullet(this) {
                Location = new Point(100, top)
            }, new BounceOffWall(3, 1));
            AddGameObject(new Bullet(this) {
                Location = new Point(150, top)
            }, new BounceOffWall(1, 3));
            AddGameObject(new Bullet(this) {
                Location = new Point(200, top)
            }, new BounceOffWall(2, 2));
            AddGameObject(new Bullet(this) {
                Location = new Point(250, top)
            }, new BounceOffWall(2, 2));
            AddGameObject(new Bullet(this) {
                Location = new Point(300, top)
            }, new BounceOffWall(3, 1));
            AddGameObject(new Bullet(this) {
                Location = new Point(350, top)
            }, new BounceOffWall(1, 3));
            AddGameObject(new Bullet(this) {
                Location = new Point(400, top)
            }, new BounceOffWall(2, 2));

            // Left
            AddGameObject(new Bullet(this) {
                Location = new Point(left, 50)
            }, new BounceOffWall(2, 2));
            AddGameObject(new Bullet(this) {
                Location = new Point(left, 100)
            }, new BounceOffWall(3, -1));
            AddGameObject(new Bullet(this) {
                Location = new Point(left, 150)
            }, new BounceOffWall(1, 3));
            AddGameObject(new Bullet(this) {
                Location = new Point(left, 200)
            }, new BounceOffWall(2, -2));
            AddGameObject(new Bullet(this) {
                Location = new Point(left, 250)
            }, new BounceOffWall(2, 2));
            AddGameObject(new Bullet(this) {
                Location = new Point(left, 300)
            }, new BounceOffWall(3, 1));
            AddGameObject(new Bullet(this) {
                Location = new Point(left, 350)
            }, new BounceOffWall(1, -3));
            AddGameObject(new Bullet(this) {
                Location = new Point(left, 400)
            }, new BounceOffWall(2, 2));

            // Right
            AddGameObject(new Bullet(this) {
                Location = new Point(right, 50)
            }, new BounceOffWall(-2, 2));
            AddGameObject(new Bullet(this) {
                Location = new Point(right, 100)
            }, new BounceOffWall(-3, -1));
            AddGameObject(new Bullet(this) {
                Location = new Point(right, 150)
            }, new BounceOffWall(-1, 3));
            AddGameObject(new Bullet(this) {
                Location = new Point(right, 200)
            }, new BounceOffWall(-2, -2));
            AddGameObject(new Bullet(this) {
                Location = new Point(right, 250)
            }, new BounceOffWall(-2, 2));
            AddGameObject(new Bullet(this) {
                Location = new Point(right, 300)
            }, new BounceOffWall(-3, 1));
            AddGameObject(new Bullet(this) {
                Location = new Point(right, 350)
            }, new BounceOffWall(-1, -3));
            AddGameObject(new Bullet(this) {
                Location = new Point(right, 400)
            }, new BounceOffWall(-2, 2));

            // Bottom
            AddGameObject(new Bullet(this) {
                Location = new Point(50, bottom)
            }, new BounceOffWall(-3, -3));
            AddGameObject(new Bullet(this) {
                Location = new Point(100, bottom)
            }, new BounceOffWall(2, -2));
            AddGameObject(new Bullet(this) {
                Location = new Point(150, bottom)
            }, new BounceOffWall(-1, -1));
            AddGameObject(new Bullet(this) {
                Location = new Point(200, bottom)
            }, new BounceOffWall(1, -3));
            AddGameObject(new Bullet(this) {
                Location = new Point(250, bottom)
            }, new BounceOffWall(-2, -2));
            AddGameObject(new Bullet(this) {
                Location = new Point(300, bottom)
            }, new BounceOffWall(-1, -1));
            AddGameObject(new Bullet(this) {
                Location = new Point(350, bottom)
            }, new BounceOffWall(1, -3));
            AddGameObject(new Bullet(this) {
                Location = new Point(400, bottom)
            }, new BounceOffWall(-2, -2));
        }

        public void AddGameObject(GameObject obj, IController controller) {
            obj.GameArea = GameArea;
            obj.Controller = controller;
            obj.Handler = new EventHandler(obj.UpdateObject);
            GameArea.GameTime.Tick += obj.Handler;
            if (GameArea.InvokeRequired) {
                GameArea.Invoke(new Action(() => GameArea.Controls.Add(obj.Body)));
            } else {
                GameArea.Controls.Add(obj.Body);
            }
        }

        public void GameOver() {
            GameArea.GameTime.Enabled = false;
            GameArea.StopWatch.Stop();
            GameArea.Server.SendGameOver();
           
        }
    }
}
