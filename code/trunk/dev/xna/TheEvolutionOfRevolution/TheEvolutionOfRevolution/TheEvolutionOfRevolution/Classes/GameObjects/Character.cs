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
        public float velocity;
        public bool attacking;
        public bool dead = false;

        protected Character attackedEnemy;

        protected Character(int ID, Type type, Vector2 position, Facing facing, State state)
            : base(position, facing, state)
        {
            this.ID = ID;

            System.Random random = new System.Random();

            if (ID == 0)
                base.position = new Vector2(0, 500 + (random.Next(0, 50) - random.Next(0, 50)));
            else
                base.position = new Vector2(800, 500 + (random.Next(0, 50) - random.Next(0, 50)));
        }

        int i = 0;
        public override void Update()
        {
            if (hp > 0)
            {
                if (this.position.X < 0 || this.position.X > 800) { this.hp = 0; }

                if (attackedEnemy != null)
                {
                    attackedEnemy.hp -= attack;
                    state = State.Attacking;
                    if (attackedEnemy.hp <= 0) { attackedEnemy = null; }
                }
                else { attacking = false; state = State.Walking; }
            }
            else
            {
                state = State.Dead;

                i++;
                if (i > 25) { dead = true; }
            }

            base.Update();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {

            base.Draw(spriteBatch);
        }

        public void TryAttack(Character enemy)
        {
            if (this.position.X -base.frame.Width - range < enemy.position.X && this.position.X > enemy.position.X
                || this.position.X +base.frame.Width + range > enemy.position.X && this.position.X < enemy.position.X)
            {
                attacking = true;
                attackedEnemy = enemy;
            }
        }

        public enum Type
        {
            Enemy,
            Revolutionary,
        }
    }
}
