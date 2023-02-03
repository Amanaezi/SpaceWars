using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceWars
{
    class Ship : Sprite
    {
        const int size = 200;
        const int speed = 15;

        public Ship(Control container) : base(container)
        {
            Pb.Image = Resources.ufo;
            Pb.Size = new Size(size, size / 2);
            Pb.Location = new Point(container.Width / 5, container.ClientSize.Height / 2);
        }

        public void AccelerateUp()
        {
            SpeedY = -speed;
        }

        public void AccelerateDown()
        {
            SpeedY = speed;
        }

        public void Stop()
        {
            SpeedY = 0;
        }

        public override void Collide(Sprite another, Game game) { }
    }
}
