using SpaceWars.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceWars
{
    class Star : EnvironmentSprite
    {
        public Star(Control container) : base(container)
        {
            Pb.Image = Resources.star;
        }

        public override void Collide(Sprite another, Game game)
        {
            if(another is Ship)
            {
                game.ScoreUp();
                GoToStart();
            }
            else if (another is Rocket)
            {
                game.ScoreUp();
                GoToStart();
            }
        }
    }
}
