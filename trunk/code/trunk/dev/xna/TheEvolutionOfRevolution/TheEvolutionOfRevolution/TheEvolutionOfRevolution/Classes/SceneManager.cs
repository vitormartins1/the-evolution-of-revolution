using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace TheEvolutionOfRevolution
{
    static class SceneManager
    {
        static public Scene scene = null;

        static private SCENE actualScene;

        static KeyboardState keyboard = new KeyboardState();

        static public ContentManager content;

        static string text;

        static SpriteFont arial;

        static public void Setup()
        {
            text = "OPENING";
            SceneManager.scene = new Opening();
            actualScene = SCENE.OPENING;

        }

        public static void LoadContent(ContentManager content)
        {
            scene.LoadContent(content);
            SceneManager.content = content;
            arial = content.Load<SpriteFont>("Arial");
        }

        public static void Update(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();

            scene.Update(gameTime);
        }

        static public void Draw(SpriteBatch spriteBatch)
        {
            scene.Draw(spriteBatch);
            spriteBatch.DrawString(arial, text, Vector2.Zero, Color.White);
        }

        static public void changeScene(int level)
        {
            switch (level)
            {
                case 0:
                    {
                        SceneManager.scene = new Opening();
                        actualScene = SCENE.OPENING;
                    }
                    break;
                case 1:
                    {
                        SceneManager.scene = new GameLevel();
                        actualScene = SCENE.LEVEL_01;
                    }
                    break;
                case 2:
                    {
                        SceneManager.scene = new GameOver();
                        actualScene = SCENE.GAMEOVER;
                    }
                    break;
                default:
                    break;
            }
        }

        public enum SCENE
        {
            OPENING,
            LEVEL_01,
            GAMEOVER,
        }
    }
}
