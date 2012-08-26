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
        GenericCharacter genericCharacter;

        public GameLevel() { }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            this.background = new Background(new Vector2(0, 0), content.Load<Texture2D>("Images//russia"), new Point(800,600));
            //genericCharacter = new GenericCharacter(content.Load<Texture2D>("Sprite"), Vector2.Zero); genericCharacter = new GenericCharacter(content.Load<Texture2D>("Sprite"), Vector2.Zero);
        }

        public override void Update(GameTime gameTime)
        {
            //genericCharacter.Update();
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            if (background != null)
                background.Draw(spritebatch);

            //genericCharacter.Draw(spritebatch);

            base.Draw(spritebatch);
        }
    }
}
