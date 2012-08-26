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

        public InfoDisplayer(SpriteFont font, Vector2 displayPosition, Color color)//, string name, float delay, float attack, float speed, float hp)
        {
            this.font = font;
            this.color = color;
            this.displayPosition = displayPosition;
            //info = string.Format("Name: {0}\nHP: {1}\nDelay: {2}\nAttack: {3}\nSpeed: {4}", hp, name, delay, attack, speed);
            info = "void";
        }

        public void SetString(string name, float attack, float speed, float hp)
        {
            info = string.Format("Name: {0}\nHP: {1}\nAttack: {2}\nSpeed: {3}", name, hp, attack, speed);
            //info = string.Format("Name: {0}\nDelay: {1}\nAttack: {2}\nSpeed: {3}", name, delay, attack, speed);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, info, displayPosition, color);
        }
    }
}
