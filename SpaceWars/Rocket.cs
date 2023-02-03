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
    class Rocket : Sprite
    {
        const int size = 100;

        public Rocket(Control container) : base(container)
        {
            Pb.Image = Resources.rocket;
            Pb.Size = new Size(size, size / 2);
            Pb.Location = new Point(0, 0);
        }

        public void Shoot(Ship ship)
        {
            Pb.Location = ship.Pb.Location;
            SpeedX += 20;
        }
        public override void Collide(Sprite another, Game game) { }
    }
}
