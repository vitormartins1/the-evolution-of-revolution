using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace TheEvolutionOfRevolution
{
    class RevolutionaryTest : Character
    {
        public RevolutionaryTest(Texture2D texture)
            : base(1,Type.Revolutionary, Vector2.Zero, Facing.West, State.Walking)
        {
            base.hp = 80;
            base.attack = 13;
            base.range = 3;

            Point frameCount = new Point(6, 4);
            List<Point> loopList = new List<Point>()
            {
                Point.Zero,
                new Point(1, 5)
            };

            base.Initialize(texture, frameCount, loopList);
        }

        public override void Update()
        {
            if (!attacking)
                position.X--;
            System.Console.WriteLine("Revolutionary: " + position.ToString());

            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
