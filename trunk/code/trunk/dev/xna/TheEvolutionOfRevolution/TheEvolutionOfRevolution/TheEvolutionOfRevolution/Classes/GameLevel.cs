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
    class GameLevel : Scene
    {
 //Background background;

        public GameLevel() { }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            //this.background = new Background(new Vector2(0, 0), content.Load<Texture2D>("images/background_opening"));
        }

        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            //if (background != null)
            //    background.Draw(spritebatch);

            base.Draw(spritebatch);
        }
    }
}
