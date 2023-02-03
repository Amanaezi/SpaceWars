using System;
using System.Windows.Forms;

namespace SpaceWars
{
    internal class EnvironmentSprite : Sprite
    {
        public static readonly Random random = new Random();

        protected EnvironmentSprite(Control container) : base(container)
        {
            Container = container;

            GoToStart();
            SpeedX = -random.Next(5, 20);
        }

        public Control Container { get; }

        public override void Move()
        {
            base.Move();
            if (Pb.Left + Pb.Width < 0)
            {
                GoToStart();
            }
        }

        public void GoToStart()
        {
            Pb.Left = Container.Width * 15 / 10;
            Pb.Top = random.Next(Container.ClientSize.Height - Pb.Width);
            int size = random.Next(20, 100);
            Pb.Size = new System.Drawing.Size(size, size);
        }

        public override void Collide(Sprite another, Game game) { }
    }
}