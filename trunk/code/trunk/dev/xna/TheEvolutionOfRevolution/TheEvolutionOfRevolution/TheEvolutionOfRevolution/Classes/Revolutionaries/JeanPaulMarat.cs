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
/* Jean-Paul Marat (1743-1793) foi um medico, filosofo, teorico
 * politico e cientista mais conhecido como jornalista radical
 * e politico da Revolucao Francesa. Seu trabalho era conhecido
 * e respeitado. Sua persistente perseguicao, habilidade de orador
 * e seu incomum poder preditivo levaram ele a confianca do povo e
 * fizeram dele a principal ponte entre eles e o grupo radical jacobino.
 * Morreu apunhalado no coracao com uma lamina enquanto estava
 * dentro de sua banheira.*/
#endregion

namespace TheEvolutionOfRevolution
{
    class JeanPaulMarat : Character
    {
        public JeanPaulMarat(Texture2D texture)
            : base(1,Type.Revolutionary, Vector2.Zero, Facing.West, State.Walking)
        {
            base.hp = CharacterBalance.maratHP;
            base.attack = CharacterBalance.maratAttack;
            base.range = CharacterBalance.maratRange;
            base.velocity = CharacterBalance.maratVelocity;

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
