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

namespace Foxpaw.Game
{
    class FrameRate
    {
        int frameRate;
        int frameCounter;
        TimeSpan elapsedTime;
        GameWindow gameWindow;

        public FrameRate(GameWindow window) 
        {
            gameWindow = window;
            elapsedTime = TimeSpan.Zero;
        }

        public void Verify(GameTime gameTime)
        {
            elapsedTime += gameTime.ElapsedGameTime;

            if (elapsedTime > TimeSpan.FromSeconds(1))
            {
                elapsedTime -= TimeSpan.FromSeconds(1);
                frameRate = frameCounter;
                frameCounter = 0;
            }
        }

        public void Show()
        {
            frameCounter++;

            string fps = string.Format("FPS: {0}", frameRate);

            gameWindow.Title = fps;
        }
    }
}