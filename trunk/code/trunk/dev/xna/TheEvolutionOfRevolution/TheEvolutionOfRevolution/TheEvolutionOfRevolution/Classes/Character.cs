#region Microsoft
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

using Foxpaw.Game2D;

namespace TheEvolutionOfRevolution
{
    abstract class Character : GameObject
    {
        public int hp;

        protected Character(int ID, Vector2 position, Facing facing, State state) : base(position, facing, state) { }

        public virtual void Update()
        {

            base.Update();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

            base.Draw(spriteBatch);
        }
    }
}
