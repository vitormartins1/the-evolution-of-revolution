﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace TheEvolutionOfRevolution
{
    class InfoDisplayer
    {
        string info;
        string aux;
        Color color;
        SpriteFont font;
        Vector2 displayPosition;
        Texture2D bg;

        public InfoDisplayer(SpriteFont font, Vector2 displayPosition, Color color)//, string name, float delay, float attack, float speed, float hp)
        {
            this.font = font;
            this.color = color;
            this.displayPosition = displayPosition;
            //info = string.Format("Name: {0}\nHP: {1}\nDelay: {2}\nAttack: {3}\nSpeed: {4}", hp, name, delay, attack, speed);
            info = "void";
            aux = "void";
            this.bg = SceneManager.content.Load<Texture2D>("Bar//bg_display");
        }

        public void SetString(string name, float attack, float speed, float hp)
        {
            info = string.Format("Name: {0}\nHP: {1}\nAttack: {2}\nSpeed: {3}", name, hp, attack, speed);
            aux = "Name:" + name;
            //info = string.Format("Name: {0}\nDelay: {1}\nAttack: {2}\nSpeed: {3}", name, delay, attack, speed);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bg, new Rectangle((int)displayPosition.X - 5, (int)displayPosition.Y-5, aux.Length*12/*235*/+5, 100+5), Color.White);
            spriteBatch.DrawString(font, info, displayPosition, color);
        }
    }
}
