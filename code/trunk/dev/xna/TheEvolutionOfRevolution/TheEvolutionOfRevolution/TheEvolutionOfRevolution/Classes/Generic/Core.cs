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

        int i = 0;
        public void Update(GameTime gameTime) 
        {
            i++;

            if (Microsoft.Xna.Framework.Input.Keyboard.GetState().IsKeyDown(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                if (i > 60)
                {
                    CharacterManager.AddCharacter(new JeanPaulMarat(content.Load<Texture2D>("Images//soldier_1")));
                    CharacterManager.AddCharacter(new LuizXVI(content.Load<Texture2D>("Sprite")));
                    i = 0;
                }
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
