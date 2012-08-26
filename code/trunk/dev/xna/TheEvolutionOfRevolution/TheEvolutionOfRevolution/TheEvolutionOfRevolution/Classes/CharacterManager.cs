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

            private static void BubbleSort()
            {
                for (int i = characterList.Count - 1; i > 0; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (characterList[i].position.Y > characterList[j].position.Y)
                        {
                            Character swap = characterList[i];
                            characterList[i] = characterList[j];
                            characterList[j] = swap;
                        }
                    }
                }
            }

            public static void Update()
            {
                BubbleSort();

                for (int index = 0; index < characterList.Count; index++)
                {
                    Character character = characterList[index];

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
                    character.Update();
                }
            }

            public static void Draw(SpriteBatch spritebatch)
            {
                foreach (Character character in characterList) { character.Draw(spritebatch); }
            }
        }
    
}
