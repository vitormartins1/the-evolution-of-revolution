using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TheEvolutionOfRevolution
{
    class InfoDisplayer
    {
        string info;
        Color color;
        SpriteFont font;
        Vector2 displayPosition;

        public InfoDisplayer(SpriteFont font, Vector2 displayPosition, Color color, string name, int delay, int attack, int speed)
        {
            this.font = font;
            this.color = color;
            this.displayPosition = displayPosition;
            info = string.Format("Name: {0}/n Delay: {1}/n Attack: {2}/n Speed: {3}", name, delay, attack, speed);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, info, displayPosition, color);
        }
    }
}
