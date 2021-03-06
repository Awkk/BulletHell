﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BulletHell.Controller;

namespace BulletHell.Model {
    public class GameObject {
        public GameArea GameArea { get; set; }
        public PictureBox Body { get; private set; }
        public IController Controller { get; set; }

        public EventHandler Handler { get; set; }
        public Rectangle Bounds { get { return Body.Bounds; } }
        public int Height { get { return Body.Size.Height; } }
        public int Width { get { return Body.Size.Width; } }
        public Size Size {
            get { return Body.Size; }
            set {
                if (value.Height > 0 && value.Width > 0)
                    Body.Size = value;
            }
        }
        public Point Location {
            get { return Body.Location; }
            set { Body.Location = value; }
        }

        public Color BackColor {
            get { return Body.BackColor; }
            set { Body.BackColor = value; }
        }

        public GameObject() {
            Body = new PictureBox();
        }

        public virtual void UpdateObject(object sender, EventArgs e) {
            if (Controller != null) {
                Controller.UpdateLocation(this);
            }
        }
    }
}
