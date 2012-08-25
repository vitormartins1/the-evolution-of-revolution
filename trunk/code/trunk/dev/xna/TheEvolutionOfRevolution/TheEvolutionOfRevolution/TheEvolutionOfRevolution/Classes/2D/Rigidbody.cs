/*
|--------------------------------------------------------------------|
|Programado por Willian Silva (Kipip) - williansilva.nave@gmail.com  |
|--------------------------------------------------------------------|
*/

#region Microsoft
using Microsoft.Xna.Framework;
using System.Collections.Generic;
#endregion

namespace Foxpaw.Game2D
{
    class Rigidbody
    {
        //public enum Density { Solid, Soft } //Maybe later

        public bool kinematic; // Causar, mas não receber efeitos de física.
        public Rectangle bounding; // Retângulo de colisão.

        public Rigidbody(Vector2 position, Point size, bool isKinematic)
        {
            this.kinematic = isKinematic;
            UpdateRectangle(position, size);
        }

        public void CheckCollision(List<GameObject> gameObjectList)
        {
            if (kinematic == false)
            {
                foreach (GameObject gameObject in gameObjectList)
                {
                    if (gameObject.rigidbody.kinematic == false && 
                        gameObject.rigidbody.bounding.Intersects(this.bounding))
                    {
                        //Colisão
                    }
                }
            }
        }

        protected void UpdateRigidbody(Vector2 position)
        {
            bounding.X = (int)position.X;
            bounding.Y = (int)position.Y;
        }

        protected void UpdateRectangle(Vector2 position, Point size)
        {
            bounding = new Rectangle((int)position.X, (int)position.Y, size.X, size.Y);
        }
    }
}
