using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace TheEvolutionOfRevolution
{
    class Bar
    {
        static LoadingBar bar;
        public static int barValue;

        public static void Initialize()
        {
            bar = new LoadingBar(new Vector2(200, 200));
            barValue = bar.size.X / 2;
        }

        public static void Update() 
        {
            bar.barSize.X = barValue;

            if (bar.barSize.X <= 0) { System.Console.WriteLine("WIN"); }
            else if (bar.barSize.X >= bar.size.X) { System.Console.WriteLine("LOSE"); }
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            bar.Draw(spriteBatch);
        }
    }
}
