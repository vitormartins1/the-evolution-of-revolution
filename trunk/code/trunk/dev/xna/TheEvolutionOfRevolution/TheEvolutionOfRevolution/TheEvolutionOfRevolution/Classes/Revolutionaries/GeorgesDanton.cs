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
/* Georges Jacques Danton (1759-1794) foi um advogado e politico
 * frances que se tornou figura destacada nos estagios iniciais 
 * da Revolucao Francesa. Tornou-se membro da “Sociedade dos Amigos
 * da Constituição”, que deu origem ao Partido Jacobino, organizacao
 * politica radical representante dos anseios das camadas populares.
 * Integrou a Convenção Nacional e depois chefiou o Comite de Salvação
 * Publica. Morreu guilhotinado no periodo do Terror, acusado de conspiraçao.*/
#endregion

namespace TheEvolutionOfRevolution
{
    class GeorgesDanton : Character
    {
        public GeorgesDanton(Texture2D texture)
            : base(1,Type.Revolutionary, Vector2.Zero, Facing.West, State.Walking)
        {
            base.hp = 75;
            base.attack = 1;
            base.range = 500;
            base.velocity = 0.85f;

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
