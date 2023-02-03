using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceWars
{
    class Game
    {
        public bool IsOver { get; set; } = false;
        public int Score { get; set; } = 0;
        public Ship Ship { get; }

        public Rocket Rocket { get; }
        public List<Sprite> Sprites { get; } = new List<Sprite>();

        public Game(Control container)
        {
            Ship = new Ship(container);
            Rocket = new Rocket(container);
            Sprites.Add(Ship);
            Sprites.Add(Rocket);

            for (int i = 0; i < 5; i++)
            {
                Sprites.Add(new Star(container));
            }

            for (int i = 0; i < 3; i++)
            {
                Sprites.Add(new Rock(container));
            }
        }

        internal void Over()
        {
            IsOver = true;
        }

        public void Update()
        {
            foreach(var sprite in Sprites)
            {
                sprite.Move();
                if (Ship.IsCollide(sprite)) sprite.Collide(Ship, this);
                if (Rocket.IsCollide(sprite)) sprite.Collide(Rocket, this);
            }

        }

        internal void ScoreUp()
        {
            Score += 10;
        }
    }
}
