using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Foxpaw.Game;

namespace Foxpaw.Game
{
    class Core : FrameRate
    {
        ContentManager content;



        public Core(ContentManager content, GraphicsDevice graphicsDevice, GameWindow window) : base(window)
        {
            this.content = content;

            Initialiaze();
        }

        public void Initialiaze()
        {

        }

        public void Update(GameTime gameTime) 
        {

            base.Verify(gameTime);
        }

        public void Draw() 
        {

            base.Show();
        }
    }
}
