/*
|--------------------------------------------------------------------|
|Programado por Willian Silva (Kipip) - williansilva.nave@gmail.com  |
|--------------------------------------------------------------------|
*/

#region Microsoft
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace Foxpaw.Game2D.Particle
{
    abstract class Particle
    {
        Color color;
        Vector2 position;
        Vector2 direction;
        TimeSpan lifeTime;
        Texture2D texture;

        bool topAll;
        float speed;
        public bool finish;

        protected void CreateParticle(int lifeTime, float speed, bool topAll, Texture2D texture, Vector2 position, Vector2 direction, Color color)
        {
            this.color = color;
            this.speed = speed;
            this.topAll = topAll;
            this.texture = texture;
            this.position = position;
            this.lifeTime = TimeSpan.FromMilliseconds(lifeTime);
            this.direction = direction;
        }

        public virtual void Update()
        {
            if (lifeTime.Milliseconds < 0) { finish = true; return; }

            position += direction * speed;
            lifeTime -= TimeSpan.FromMilliseconds(16);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            float myDepth = position.Y * 0.001f;
            spriteBatch.Draw(texture, position, null, color, 0, Vector2.Zero, 1, SpriteEffects.None, myDepth);
        }


    }
}
