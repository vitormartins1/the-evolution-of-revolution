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

        public Button(Vector2 position, Point size, Texture2D bt, Texture2D btHover)
            : base(position, bt, size)
        {
            this.position = position;
            this.size = size;

            this.bt = bt;
            this.btHover = btHover;
            btBehavior = new ButtonBehavior();
        }

        public void Update()
        {
            btBehavior.CheckButton(new Rectangle((int)position.X, (int)position.Y, size.X, size.Y));
        }
    }
}
