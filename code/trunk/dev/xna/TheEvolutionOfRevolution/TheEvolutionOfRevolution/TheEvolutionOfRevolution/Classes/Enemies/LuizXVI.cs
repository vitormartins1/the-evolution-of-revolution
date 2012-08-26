using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

#region Bibliografia
/* Luis XVI de Bourbon (1754-1793), foi rei da França entre
 * 1774 e 1791, depois rei dos Franceses entre 1791 e 1792.
 * Era neto do grande rei absolutista Luis XIV e foi casado
 * com Maria Antonieta. Quando subiu ao trono em 1774,
 * ocasiao em que contava com 20 anos, as financas reais nao
 * se encontravam numa situacao favoravel e assim permaneceram
 * ate o eclodir na Revolucao Francesa, altura em que Luis XVI
 * foi deposto. Foi executado na guilhotina, em janeiro de 1793.*/
#endregion

namespace TheEvolutionOfRevolution
{
    class LuizXVI : Character
    {
        public LuizXVI(Texture2D texture)
            : base(0,Type.Enemy, Vector2.Zero, Facing.East, State.Walking)
        {
            base.hp = 210;
            base.attack = 1;
            base.range = 0;
            base.velocity = 0.5f;

            Point frameCount = new Point(10, 2);
            List<Point> loopList = new List<Point>()
            {
                Point.Zero,
                new Point(0, 4),
                new Point(5, 9),
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
