#region Microsoft
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

using Foxpaw.Game.Xml.Database;

namespace Foxpaw.Game2D.Particle
{
    static class ParticleEmitter
    {
        static XmlDatabase database = new XmlDatabase("PATH");
        static List<Particle> particleList = new List<Particle>();
        static Particle[] recentParticles = new Particle[10]; // Últimas partículas usadas. Evita releitura de XML.

        public static void AddParticle(Particle particle) 
        {
 
            particleList.Add(particle); 
        }

        public static void Update()
        {
            for (int index = 0; index < particleList.Count; index++)
            {
                Particle particle = particleList[index];

                if (particle.finish) { particleList.Remove(particle); }
                else { particle.Update(); }
            }
        }

        public static void Draw(SpriteBatch spritebatch)
        {
            foreach (Particle particle in particleList) { particle.Draw(spritebatch); }
        }
    }
}
