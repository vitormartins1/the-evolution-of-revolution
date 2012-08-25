#region Microsoft
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

using Foxpaw.Game2D;

namespace TheEvolutionOfRevolution
{
    abstract class Character : GameObject
    {
        public float hp;
        public float attack;
        public int ID;

        public Type type;

        protected Character(Type type, Vector2 position, Facing facing, State state)
            : base(position, facing, state)
        {
            SetParameters(type);
        }

        public virtual void Update()
        {

            base.Update();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

            base.Draw(spriteBatch);
        }

        private void SetParameters(Type type)
        {
            switch (type)
            {
                case Type.Enemy:
                    ID = 0;
                    attack = 5;
                    hp = 40;
                    break;
                case Type.Revolutionary:
                    ID = 1;
                    attack = 6;
                    hp = 39;
                    break;
                default:
                    break;
            }
        }

        public enum Type
        {
            Enemy,
            Revolutionary,
        }
    }
}
