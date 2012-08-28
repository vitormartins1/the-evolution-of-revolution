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
    class Menu : Scene
    {
        Background background;

        Button btJogar;
        Button btinstructions;
        Button btCreditos;

        public Menu()
        {
        }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            this.background = new Background(new Vector2(0, 0), content.Load<Texture2D>("Images//bastilha"), new Point(800, 600));

            this.btJogar = new Button(new Vector2(1300/2 - 200/2, 250+115), new Point(200, 50), content.Load<Texture2D>("Botoes//bt_jogar"), content.Load<Texture2D>("Botoes//bthover_jogar"));
            this.btinstructions = new Button(new Vector2(1300 / 2 - 200 / 2, 320+115), new Point(200, 50), content.Load<Texture2D>("Botoes//bt_instrucoes"), content.Load<Texture2D>("Botoes//bthover_instrucoes"));
            this.btCreditos = new Button(new Vector2(1300 / 2 - 200 / 2, 390+115), new Point(200, 50), content.Load<Texture2D>("Botoes//bt_creditos"), content.Load<Texture2D>("Botoes//bthover_creditos"));
            btCreditos.drawImg = false;
            btinstructions.drawImg = false;
            btJogar.drawImg = false;
        }

        public override void Update(GameTime gameTime)
        {
            btCreditos.Update();
            btinstructions.Update();
            btJogar.Update();

            if (btJogar.btBehavior.PRESSED)
                SceneManager.changeScene(1);

            if (btinstructions.btBehavior.PRESSED)
                SceneManager.changeScene(4);

            if (btCreditos.btBehavior.PRESSED)
                SceneManager.changeScene(5);

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            if (background != null)
                background.Draw(spritebatch);

            btJogar.Draw(spritebatch);
            btinstructions.Draw(spritebatch);
            btCreditos.Draw(spritebatch);

            base.Draw(spritebatch);
        }
    }
}
