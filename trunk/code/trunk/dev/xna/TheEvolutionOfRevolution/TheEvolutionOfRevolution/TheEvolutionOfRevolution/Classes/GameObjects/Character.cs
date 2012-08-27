#region Microsoft
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

using Foxpaw.Game2D;

namespace TheEvolutionOfRevolution
{
    abstract class Character : GameObject
    {
        public float range;
        public float hp;
        public float attack;
        public int ID;
        public float velocity;
        public bool attacking;
        public bool dead = false;
        public bool beingAttacked = false;

        protected Character attackedEnemy;

        protected Character(int ID, Type type, Vector2 position, Facing facing, State state)
            : base(position, facing, state)
        {
            this.ID = ID;

            System.Random random = new System.Random();

            if (ID == 0)
                base.position = new Vector2(0, 300 + random.Next(0, 250));
            else
                base.position = new Vector2(800, 300 + random.Next(0, 250));
        }

        int i = 0;
        public override void Update()
        {
            if (hp > 0)
            {
                if (this.position.X < 0) { Bar.barValue.X -= 10; hp = 0; }
                else if (this.position.X > 800) { Bar.barValue.X += 10; hp = 0; }

                if (attackedEnemy != null)
                {
                    if (attackedEnemy.position.Y - 5 > position.Y) { position.Y+=1.5f; }
                    else if (attackedEnemy.position.Y + 5 < position.Y) { position.Y -= 1.5f; }

                    attackedEnemy.hp -= attack;
                    state = State.Attacking;
                    if (attackedEnemy.hp <= 0) { attackedEnemy = null; beingAttacked = false; }
                }
                else { attacking = false; beingAttacked = false; state = State.Walking; }
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
            if (!enemy.beingAttacked && attacking == false)
            {
                if (this.position.X - base.frame.Width - range < enemy.position.X && this.position.X > enemy.position.X
                    || this.position.X + base.frame.Width + range > enemy.position.X && this.position.X < enemy.position.X)
                {
                    attacking = true;
                    attackedEnemy = enemy;
                    attackedEnemy.beingAttacked = true;
                }
            }
        }

        public enum Type
        {
            Enemy,
            Revolutionary,
        }
    }
}
