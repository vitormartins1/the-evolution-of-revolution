using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TheEvolutionOfRevolution
{
    class Button : StaticGameObject
    {
        private Texture2D bt;
        private Texture2D btHover;

        private Vector2 position;
        private Point size;

        public ButtonBehavior btBehavior;

        public InfoDisplayer displayer;

        public Button(Vector2 position, Point size, Texture2D bt, Texture2D btHover)
            : base(position, bt, size)
        {
            this.position = position;
            this.size = size;

            this.bt = bt;
            this.btHover = btHover;
            btBehavior = new ButtonBehavior();
            displayer = new InfoDisplayer(SceneManager.content.Load<SpriteFont>("Fonts//font_01"),
                new Vector2(base.position.X, base.position.Y + base.size.Y + 19),
                Color.Black);//, "Vitor", 76, 76, 45, 100);
        }

        public ButtonBehavior GetBehavior()
        {
            return btBehavior;
        }

        public void Update()
        {
            btBehavior.CheckButton(new Rectangle((int)position.X, (int)position.Y, size.X, size.Y));

            if (btBehavior.HOVERING)
            {
                base.image = btHover;
            }
            else
                base.image = bt;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (btBehavior.HOVERING)
            {
                displayer.Draw(spriteBatch);
            }
            base.Draw(spriteBatch);
        }
    }
}
