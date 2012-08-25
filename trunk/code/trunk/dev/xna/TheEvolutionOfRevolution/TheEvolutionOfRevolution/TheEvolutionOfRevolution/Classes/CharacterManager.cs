using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TheEvolutionOfRevolution
{
        static class CharacterManager
        {
            static List<Character> characterList = new List<Character>();

            public static void AddParticle(Character particle)
            {

                characterList.Add(particle);
            }

            public static void Update()
            {

                ////////////////
                for (int index = 0; index < characterList.Count; index++)
                {
                    Character character = characterList[index];

                    if (character.hp <= 0) { characterList.Remove(character); }
                }
            }

            public static void Draw(SpriteBatch spritebatch)
            {
                foreach (Character particle in characterList) { particle.Draw(spritebatch); }
            }
        }
    
}
