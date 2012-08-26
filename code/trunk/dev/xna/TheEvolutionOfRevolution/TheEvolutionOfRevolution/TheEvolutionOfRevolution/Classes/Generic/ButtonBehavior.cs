using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace TheEvolutionOfRevolution
{
    class ButtonBehavior
    {
        public MouseState currentState;
        bool pressing = false;
        public bool PRESSED, DRAGGING, HOVERING;

        public void CheckButton(Rectangle rectangle)
        {
            PRESSED = false;
            DRAGGING = false;

            currentState = Mouse.GetState();

            if (rectangle.Contains(new Point(currentState.X, currentState.Y)))
            {
                HOVERING = true;
                if (currentState.LeftButton == ButtonState.Pressed)
                {
                    pressing = true;
                    DRAGGING = true;
                }
                else
                {
                    if (pressing) { PRESSED = true; }
                    pressing = false;
                }
            }
            else { pressing = false; HOVERING = false; }
        }
    }
}
