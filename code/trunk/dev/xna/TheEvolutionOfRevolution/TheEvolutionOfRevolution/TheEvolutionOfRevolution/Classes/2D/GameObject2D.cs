/*
|--------------------------------------------------------------------|
|Programado por Willian Silva (Kipip) - williansilva.nave@gmail.com  |
|--------------------------------------------------------------------|
*/

#region Microsoft
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

using Foxpaw.Game2D.Graphics;
using Foxpaw.Game.Xml.GenericPackage;

namespace Foxpaw.Game2D
{
    class GameObject : Animation
    {
        public Rigidbody rigidbody { get; private set; }
        public Vector2 position;
        protected Point size { get; private set; }

        public GameObject (Vector2 position, Facing direction, State state)
            : base(direction, state)
        {
            this.position = position;
        }

        public void Initialize(Texture2D texture, Point frameCount, List<Point> loopList)
        {
            this.size = new Point(texture.Width, texture.Height);
            base.ChangeTexture(texture, frameCount, loopList);
        }

        public override void Update()
        {
            base.Update();
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(ref position, spriteBatch);
        }

        protected void SetInterval(float speed) { this.interval -= TimeSpan.FromMilliseconds(speed * 15); }

        private void SetupRigidbody(bool isKinematic)
        {
            rigidbody = new Rigidbody(position, size, isKinematic);
        }
    }
}
