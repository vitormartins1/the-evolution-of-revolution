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
    class Instructions : Scene
    {
        Background background;

        Button btBackMenu;

        public Instructions()
        {
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            this.background = new Background(new Vector2(0, 0), content.Load<Texture2D>("Images//bg_instructions"), new Point(800, 600));

            this.btBackMenu = new Button(new Vector2(800/2 - 200/2, 200), new Point(200, 50), content.Load<Texture2D>("Botoes//bt_menu"), content.Load<Texture2D>("Botoes//bthover_menu"));
            
            btBackMenu.drawImg = false;
        }

        public override void Update(GameTime gameTime)
        {
            btBackMenu.Update();

            if (btBackMenu.btBehavior.PRESSED)
                SceneManager.changeScene(3);

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            if (background != null)
                background.Draw(spritebatch);

            btBackMenu.Draw(spritebatch);

            base.Draw(spritebatch);
        }
    }
}
