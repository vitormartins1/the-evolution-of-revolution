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

        static public void Setup()
        {
            //SceneManager.scene = new Opening();
            SceneManager.scene = new Opening();
            actualScene = SCENE.OPENING;
        }

        public static void LoadContent(ContentManager content)
        {
            scene.LoadContent(content);
            SceneManager.content = content;
        }

        public static void Update(GameTime gameTime)
        {
            keyboard = Keyboard.GetState();

            scene.Update(gameTime);
        }

        static public void Draw(SpriteBatch spriteBatch)
        {
            scene.Draw(spriteBatch);
        }

        static public void changeScene(int level)
        {
            switch (level)
            {
                case 0:
                    {
                        SceneManager.scene = new Opening();
                        scene.LoadContent(content);
                        actualScene = SCENE.OPENING;
                    }
                    break;
                case 1:
                    {
                        SceneManager.scene = new GameLevel();
                        scene.LoadContent(content);
                        actualScene = SCENE.LEVEL_01;
                    }
                    break;
                case 2:
                    {
                        SceneManager.scene = new GameOver();
                        scene.LoadContent(content);
                        actualScene = SCENE.GAMEOVER;
                    }
                    break;
                case 3:
                    {
                        SceneManager.scene = new Menu();
                        scene.LoadContent(content);
                        actualScene = SCENE.MENU;
                    }
                    break;
                case 4:
                    {
                        SceneManager.scene = new Instructions();
                        scene.LoadContent(content);
                        actualScene = SCENE.INSTRUCTIONS;
                    }
                    break;
                case 5:
                    {
                        SceneManager.scene = new Creditos();
                        scene.LoadContent(content);
                        actualScene = SCENE.CREDITOS;
                    }
                    break;
                case 6:
                    {
                        SceneManager.scene = new Congrats();
                        scene.LoadContent(content);
                        actualScene = SCENE.CONGRATS;
                    }
                    break;
                case 7:
                    {
                        SceneManager.scene = new GameOver();
                        scene.LoadContent(content);
                        actualScene = SCENE.GAMEOVER;
                    }
                    break;
            }
        }

        public enum SCENE
        {
            OPENING,
            LEVEL_01,
            GAMEOVER,
            MENU,
            INSTRUCTIONS,
            CREDITOS,
            CONGRATS,
        }
    }
}
