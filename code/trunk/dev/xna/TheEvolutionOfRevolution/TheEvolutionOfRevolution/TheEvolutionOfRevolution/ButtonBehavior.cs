using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TheEvolutionOfRevolution
{
    class ButtonBehavior
    {
        MouseState currentState;
        bool pressing = false;
        public bool PRESSED = false;

        public void CheckButton(Rectangle rectangle)
        {
            currentState = Mouse.GetState();

            if (rectangle.Contains(new Point(currentState.X, currentState.Y)))
            {
                PRESSED = false;

                if (currentState.LeftButton == ButtonState.Pressed)
                {
                    pressing = true;
                }
                else
                {
                    if (pressing) { PRESSED = true; }
                    pressing = false;
                }
            }
            else
            {
                pressing = false;
                PRESSED = false;
            }
        }
    }
}
