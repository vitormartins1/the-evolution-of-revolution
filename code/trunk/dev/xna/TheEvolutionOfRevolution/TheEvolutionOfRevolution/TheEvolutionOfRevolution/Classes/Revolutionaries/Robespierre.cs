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

#region Bibliografia
/* Maximilien Francois Robespierre (1758-1794) foi advogado e
 * politico frances, considerado uma das personalidades mais
 * importantes da Revolução Francesa. Seus amigos chamavam-lhe
 * “O Incorruptivel”. Ele encarnou a tendencia mais radical da
 * Revolucao, transformando-se numa das personagens mais controversas
 * deste periodo e lider durante o Terror. Foi guilhotinado em
 * julho de 1794, sem julgamento.*/
#endregion

namespace TheEvolutionOfRevolution
{
    class Robespierre : Character
    {
        public Robespierre(Texture2D texture)
            : base(1,Type.Revolutionary, Vector2.Zero, Facing.West, State.Walking)
        {
            base.hp = CharacterBalance.robespierreHP;
            base.attack = CharacterBalance.robespierreAttack;
            base.range = CharacterBalance.robespierreRange;
            base.velocity = CharacterBalance.robespierreVelocity;

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
            {
                position.X -= base.velocity;
            }
            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
