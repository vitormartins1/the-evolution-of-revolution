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
using Foxpaw.Game2D;

namespace TheEvolutionOfRevolution
{
    class StaticGameObject
    {
        public Rigidbody rigidbody { get; private set; }
        public Vector2 position;
        public Texture2D image;
        protected Point size { get; private set; }

        public StaticGameObject(Vector2 position, Texture2D image, Point size)
        {
            this.image = image;
            this.position = position;
            this.size = size;
        }
        
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.image, new Rectangle((int)position.X, (int)position.Y, size.X, size.Y), Color.White);
        }

        private void SetupRigidbody(bool isKinematic)
        {
            rigidbody = new Rigidbody(position, size, isKinematic);
        }
    }
}
