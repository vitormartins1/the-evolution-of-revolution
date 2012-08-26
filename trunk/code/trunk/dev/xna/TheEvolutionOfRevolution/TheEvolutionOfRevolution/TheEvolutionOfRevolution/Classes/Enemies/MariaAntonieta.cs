using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

#region Bibliografia
/* Maria Antonieta Josefa (1755-1793) foi arquiduquesa da Austria
 * e rainha consorte de Franca de 1774 ate a Revolucao Francesa,
 * em 1789. Casou-se em 1770, aos catorze anos de idade, com o
 * delfim frances Luis Augusto de Bourbon, que, em 1774, tornou-se
 * o rei de Franca, com o nome de Luis XVI. Maria Antonieta era
 * tia-avo da primeira imperatriz do Brasil, Maria Leopoldina da
 * Austria. Foi executada na guilhotina alguns meses depois de Luis XVI.*/
#endregion

namespace TheEvolutionOfRevolution
{
    class MariaAntonieta : Character
    {
        public MariaAntonieta(Texture2D texture)
            : base(0,Type.Enemy, Vector2.Zero, Facing.East, State.Walking)
        {
            base.hp = CharacterBalance.mariaHP;
            base.attack = CharacterBalance.mariaAttack;
            base.range = CharacterBalance.mariaRange;
            base.velocity = CharacterBalance.mariaVelocity;

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
