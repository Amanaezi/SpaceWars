using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceWars
{
    class Rock : EnvironmentSprite
    {
        public Rock(Control container) : base(container)
        {
            Pb.Image = Resources.rock;
        }

        public override void Collide(Sprite another, Game game)
        {
            if (another is Rocket)
            {
                GoToStart();
            }
            else
            {
                game.Over();
            }
        }
    }
}
