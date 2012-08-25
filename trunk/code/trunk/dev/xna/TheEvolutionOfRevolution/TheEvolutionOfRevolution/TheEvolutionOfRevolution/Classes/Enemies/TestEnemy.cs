using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TheEvolutionOfRevolution
{
    class TesteEnemy : Character
    {
        public TesteEnemy(Texture2D texture)
            : base(0,Type.Enemy, Vector2.Zero, Facing.East, State.Walking)
        {
            base.hp = 100;
            base.attack = 1;
            base.range = 0;

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
                position.X++;

            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
