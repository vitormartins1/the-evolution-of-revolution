using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TheEvolutionOfRevolution.Classes.Revolutionaries
{
    class TestProjectile : StaticGameObject
    {
        Character target;

        public TestProjectile(Texture2D image, Vector2 position, Character target)
            : base(position, image, new Point(20, 20))
        {
            this.target = target;
        }
    }
}
