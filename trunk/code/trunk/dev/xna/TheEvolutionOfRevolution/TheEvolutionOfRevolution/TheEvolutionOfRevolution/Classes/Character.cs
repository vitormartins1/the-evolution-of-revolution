#region Microsoft
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

using Foxpaw.Game2D;

namespace TheEvolutionOfRevolution
{
    abstract class Character : GameObject
    {
        public int range;
        public float hp;
        public float attack;
        public int ID;
        public bool attacking;

        private Character attackedEnemy;

        public Type type;

        protected Character(Type type, Vector2 position, Facing facing, State state)
            : base(position, facing, state)
        {
            SetParameters(type);
        }

        public virtual void Update()
        {
            if (attackedEnemy != null)
            {
                // state = State.Attacking;
                attackedEnemy.hp -= attack;
            }

            base.Update();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

            base.Draw(spriteBatch);
        }

        public void TryAttack(Character enemy)
        {
            if (this.position.X + range < enemy.position.X && this.position.X < enemy.position.X)
            {
                attacking = true;
                attackedEnemy = enemy;
            }
            else
            {
                attackedEnemy = null;
            }
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
