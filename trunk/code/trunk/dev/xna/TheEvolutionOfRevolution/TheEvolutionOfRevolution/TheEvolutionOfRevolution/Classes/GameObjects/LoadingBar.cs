#region Microsoft
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

using Foxpaw.Game2D;

namespace TheEvolutionOfRevolution
{
    class LoadingBar
    {
        private Texture2D bgBar;
        private Texture2D upBar;
        public Texture2D bar;

        private Vector2 position;

        private Point size;
        private Vector2 barSize;

        public bool loading;
        public bool loadead;
        public float loadingVariation;

        public int ID;

        public LoadingBar(Vector2 position)
        {
            this.bgBar = SceneManager.content.Load<Texture2D>("Bar//bar3");
            this.bar = SceneManager.content.Load<Texture2D>("Bar//bar1");
            this.upBar = SceneManager.content.Load<Texture2D>("Bar//bar2");

            //size = new Point(upBar.Width, upBar.Height);
            //barSize = new Vector2(0, upBar.Height);

            size = new Point(140, 12);
            barSize = new Vector2(0, size.Y);

            this.position = position;

            loading = false;
        }

        public void Update()
        {
            OnLoadingBar();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(bgBar, new Rectangle((int)position.X, (int)position.Y, size.X, size.Y), Color.White);

            spriteBatch.Draw(bar, new Rectangle((int)position.X, (int)position.Y, (int)barSize.X, (int)barSize.Y), Color.White);

            spriteBatch.Draw(upBar, new Rectangle((int)position.X, (int)position.Y, size.X, size.Y), Color.White);
        }

        public void SetLoading(float variation, int ID)
        {
            loadingVariation = variation;
            loading = true;
            this.ID = ID;
        }

        public void OnLoadingBar()
        {
            if (loading)
            {
                barSize.X += loadingVariation;
                if (barSize.X >= size.X)
                {
                    loading = false;
                    loadead = true;
                    barSize.X = 0;
                }
            }
        }

        public void ResetBar()
        {
            loadead = false;
            ID = 0;
        }
    }
}
