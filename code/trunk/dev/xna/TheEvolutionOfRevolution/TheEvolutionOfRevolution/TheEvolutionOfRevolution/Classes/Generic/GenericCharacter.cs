#region Microsoft
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
#endregion

using Foxpaw.Game2D;

namespace TheEvolutionOfRevolution
{
    class GenericCharacter : GameObject
    {
        public GenericCharacter(Texture2D texture, Vector2 position) 
            : base(position, Facing.East, State.Walking)
        {
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
            if (Keyboard.GetState().IsKeyDown(Keys.Right)) { position.X++; state = State.Walking; facing = Facing.East; }
            else { state = State.Walking; }

            base.Update();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
