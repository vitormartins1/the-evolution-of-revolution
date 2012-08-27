using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace TheEvolutionOfRevolution
{
    class ComputerBehavior
    {
        LoadingBar loadingBar;
        ContentManager content;
        float[] delays;
        int callDelay;

        public ComputerBehavior(ContentManager content)
        {
            this.content = content;
            loadingBar = new LoadingBar(new Vector2(10,55));
            delays = new float[]
            {
                CharacterBalance.mariaDelay,
                CharacterBalance.luizDelay
            };
        }

        System.Random random = new System.Random();
        public void Update()
        {
            int i = random.Next(0, delays.Length);
            if (callDelay == 0) { callDelay = random.Next(60, 300); }

            callDelay--;

            loadingBar.Update();

            if (!loadingBar.loading && loadingBar.ID == 0 && callDelay == 0)
            {
                loadingBar.SetLoading(delays[i], i + 1);
            }

            if (loadingBar.loadead)
            {
                switch (loadingBar.ID)
                {
                    case 1: CharacterManager.AddCharacter(new MariaAntonieta(SceneManager.content.Load<Texture2D>("Images//mantonieta"))); break;
                    case 2: CharacterManager.AddCharacter(new LuizXVI(SceneManager.content.Load<Texture2D>("SpriteT"))); break;
                }

                loadingBar.ResetBar();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            loadingBar.Draw(spriteBatch);
        }
    }
}
