﻿using System;
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
    class GameLevel : Scene
    {
        Background background;

        Button btMariaAntonieta;
        Button btLuizXVI;

        public GameLevel() { }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            this.background = new Background(new Vector2(0, 0), content.Load<Texture2D>("Images//russia"), new Point(800,600));

            btMariaAntonieta = new Button(new Vector2(28, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_mantonieta"),
                content.Load<Texture2D>("Botoes//bthover_mantonieta"));

            btLuizXVI = new Button(new Vector2(78, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_luizxvi"),
                content.Load<Texture2D>("Botoes//bthover_luizxvi"));
        }

        public override void Update(GameTime gameTime)
        {
            CheckButtons();

            CharacterManager.Update();

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            if (background != null)
                background.Draw(spritebatch);

            CharacterManager.Draw(spritebatch);
            
            btMariaAntonieta.Draw(spritebatch);
            btLuizXVI.Draw(spritebatch);

            base.Draw(spritebatch);
        }

        public void CheckButtons()
        {
            btMariaAntonieta.Update();
            if (btMariaAntonieta.GetBehavior().PRESSED)
                CharacterManager.AddCharacter(new MariaAntonieta(SceneManager.content.Load<Texture2D>("Images//sprite_4")));

            btLuizXVI.Update();
            if (btLuizXVI.GetBehavior().PRESSED)
                CharacterManager.AddCharacter(new LuizXVI(SceneManager.content.Load<Texture2D>("SpriteT")));
        }
    }
}
