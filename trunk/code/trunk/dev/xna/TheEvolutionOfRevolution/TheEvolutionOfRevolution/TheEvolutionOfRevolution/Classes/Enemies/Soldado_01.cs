using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TheEvolutionOfRevolution
{
    class Soldado_01 : Character
    {
        public Soldado_01(Texture2D texture)
            : base(0,Type.Enemy, Vector2.Zero, Facing.East, State.Walking)
        {
            base.hp = CharacterBalance.soldado_01HP;
            base.attack = CharacterBalance.soldado_01Attack;
            base.range = CharacterBalance.soldado_01Range;
            base.velocity = CharacterBalance.soldado_01Velocity;

            Point frameCount = new Point(13, 2);
            List<Point> loopList = new List<Point>()
            {
                Point.Zero,
                new Point(0, 4),
                new Point(5, 9),
                new Point(10, 12)
            };

            base.Initialize(texture, frameCount, loopList);
        }

        public override void Update()
        {
            if (!attacking)
                position.X += base.velocity;

            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
