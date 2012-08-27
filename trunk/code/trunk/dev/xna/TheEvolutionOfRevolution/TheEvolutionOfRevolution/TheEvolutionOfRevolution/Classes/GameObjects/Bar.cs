using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace TheEvolutionOfRevolution
{
    class Bar
    {
        static LoadingBar bar;
        public static Vector2 barValue;

        public static void Initialize()
        {
            bar = new LoadingBar(new Vector2(200, 100));
            
            bar.size = new Point(250, 30);
            barValue = new Vector2(bar.size.X / 2, bar.size.Y);
            bar.position = new Vector2(800 / 2 - bar.size.X / 2, 10);
        }

        public static void Update() 
        {
            bar.barSize = barValue;

            if (bar.barSize.X <= 0) { System.Console.WriteLine("WIN"); }
            else if (bar.barSize.X >= bar.size.X) { System.Console.WriteLine("LOSE"); }
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            bar.Draw(spriteBatch);
        }
    }
}
