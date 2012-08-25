using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

using Foxpaw.Game3D.Generic;
using Foxpaw.Game3D.Test;
using Foxpaw.Game;
using Foxpaw.Game3D;

namespace Foxpaw.Game
{
    class Core : FrameRate
    {
        ContentManager content;
        BasicEffect basicEffect;
        GraphicsDevice graphicsDevice;

        Camera3D camera;

        System.Collections.Generic.List<HeightMapClass> heightMap = new System.Collections.Generic.List<HeightMapClass>();

        //GameObject3D obj;

        public Core(ContentManager content, GraphicsDevice graphicsDevice, GameWindow window) : base(window)
        {
            this.content = content;
            this.graphicsDevice = graphicsDevice;

            //obj = new GameObject3D(content.Load<Texture2D>("Textures/Raposa"), Vector3.Zero, content.Load<Model>("Raposa"));

            basicEffect = new BasicEffect(graphicsDevice);
            basicEffect.TextureEnabled = true;
            basicEffect.EnableDefaultLighting();

            camera = new Camera3D(window, 0.1f, 1000, new Vector3(0, 0, 10));
            camera.Setup(basicEffect, graphicsDevice, CullMode.CullCounterClockwiseFace, FillMode.WireFrame, BlendState.AlphaBlend);

            Initialiaze();
        }

        public void Initialiaze()
        {
            heightMap.Add(new HeightMapClass(content.Load<Texture2D>("Textures/TTesteW"), content.Load<Texture2D>("Textures/Teste"), 0.01f, 0.5f, graphicsDevice));
            heightMap.Add(new HeightMapClass(content.Load<Texture2D>("Textures/TTesteR"), content.Load<Texture2D>("Textures/Teste"), 0.01f, 1, graphicsDevice));
        }

        public void Update(GameTime gameTime) 
        {
            camera.Update();

            //obj.Update();

            base.Verify(gameTime);
        }

        public void Draw() 
        {
            basicEffect.View = camera.view;
            basicEffect.Projection = camera.projection;

            //obj.Draw(basicEffect);
            foreach (HeightMapClass hmc in heightMap)
            {
                hmc.Draw(basicEffect, graphicsDevice);
            }

            base.Show();
        }
    }
}
