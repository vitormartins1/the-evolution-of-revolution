using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Foxpaw.Game2D;

namespace TheEvolutionOfRevolution
{
    class Background : StaticGameObject
    {
        public Background(Vector2 position, Texture2D image, Point size)
            : base(position, image, size)
        {
        }
    }
}
