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

        public Core(ContentManager content, GraphicsDevice graphicsDevice, GameWindow window) : base(window)
        {
            this.content = content;
            
            Initialiaze();
        }

        public void Initialiaze()
        {
            SceneManager.Setup();
            SceneManager.LoadContent(content);
        }


        public void Update(GameTime gameTime) 
        {
            if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.D))
            {
            CharacterManager.AddCharacter(new RevolutionaryTest(content.Load<Texture2D>("Sprite")));

            }
            if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.A))
            {
                CharacterManager.AddCharacter(new TesteEnemy(content.Load<Texture2D>("Sprite")));
            }


            CharacterManager.Update();
            SceneManager.Update(gameTime);
            base.Verify(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch) 
        {
            SceneManager.Draw(spriteBatch);
            CharacterManager.Draw(spriteBatch);

            base.Show();
        }
    }
}
