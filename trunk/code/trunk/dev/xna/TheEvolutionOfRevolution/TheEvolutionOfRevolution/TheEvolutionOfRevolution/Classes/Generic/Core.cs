using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Foxpaw.Game;
using TheEvolutionOfRevolution;

namespace Foxpaw.Game
{
    class Core : FrameRate
    {
        ContentManager content;

        GenericCharacter genericCharacter;

        public Core(ContentManager content, GraphicsDevice graphicsDevice, GameWindow window) : base(window)
        {
            this.content = content;
            
            Initialiaze();
        }

        public void Initialiaze()
        {
            genericCharacter = new GenericCharacter(content.Load<Texture2D>("Sprite"), Vector2.Zero);
            SceneManager.Setup();
            SceneManager.LoadContent(content);
        }

        public void Update(GameTime gameTime) 
        {
            genericCharacter.Update();

            SceneManager.Update(gameTime);
            base.Verify(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch) 
        {
            genericCharacter.Draw(spriteBatch);

            SceneManager.Draw(spriteBatch);
            base.Show();
        }
    }
}
