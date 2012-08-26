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
using Foxpaw.Game2D;

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
        int time = 55;
        Texture2D t;

        List<TestProjectile> projectiles;

        public GeorgesDanton(Texture2D texture)
            : base(1,Type.Revolutionary, Vector2.Zero, Facing.West, State.Walking)
        {
            base.hp = 50;
            base.attack = 0.33f;
            base.range = 200;
            base.velocity =  0.75f;
            t = SceneManager.content.Load<Texture2D>("Images//stone_moon");
            Point frameCount = new Point(6, 4);
            List<Point> loopList = new List<Point>()
            {
                Point.Zero,
                new Point(1, 5)
            };

            projectiles = new List<TestProjectile>();

            base.Initialize(texture, frameCount, loopList);
        }
        
        public override void Update()
        {
            if (!attacking)
            {
                position.X -= base.velocity;
            }
            
            if (attacking)
            {
                time++;
                if (time >75)
                {
                    if (attackedEnemy != null)
                    {
                        projectiles.Add(new TestProjectile(t, base.position));
                    }
                    time = 0;
                }

                for (int i = 0; i < projectiles.Count;i++)
	            {
                    projectiles[i].Update();
                    if (projectiles[i].position.Y > position.Y)
                    {
                        projectiles.RemoveAt(i);
                    }
	            }
            }
            else if (projectiles.Count > 0)
            {
                foreach (TestProjectile p in projectiles)
                {
                    p.Update();
                }
            }

            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (TestProjectile p in projectiles)
            {
                p.Draw(spriteBatch);
            }

            base.Draw(spriteBatch);
        }
    }
}
