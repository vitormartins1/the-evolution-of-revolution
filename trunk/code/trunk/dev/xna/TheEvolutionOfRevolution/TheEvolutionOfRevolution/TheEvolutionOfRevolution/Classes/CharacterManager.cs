using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace TheEvolutionOfRevolution
{
        static class CharacterManager
        {
            static List<Character> characterList = new List<Character>();

            public static void AddCharacter(Character character)
            {
                characterList.Add(character);
            }

            public static void Update()
            {
                for (int index = 0; index < characterList.Count; index++)
                {
                    Character character = characterList[index];

                    character.Update();

                    if (characterList.Count == 1) { character.attacking = false; }
                    else
                    {
                        bool b = false;
                        foreach (Character c in characterList)
                        {
                            if (character.ID != c.ID)
                            {
                                b = true;
                                character.TryAttack(c);
                            }
                        }
                        if (!b)
                        {
                            character.attacking = false;
                        }
                    }
                    if (character.hp <= 0) { characterList.Remove(character); }
                }
            }

            public static void Draw(SpriteBatch spritebatch)
            {
                foreach (Character character in characterList) { character.Draw(spritebatch); }
            }
        }
    
}
