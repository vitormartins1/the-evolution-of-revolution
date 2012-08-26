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

namespace TheEvolutionOfRevolution
{
    class GameLevel : Scene
    {
        Background background;

        Button btMariaAntonieta;
        Button btLuizXVI;

        Button btRobespierre;
        Button btJeanPaulMarat;
        Button btGeorgesDanton;

        LoadingBar barUser;

        public GameLevel() { }

        public override void LoadContent(ContentManager content)
        {
            base.LoadContent(content);
            this.background = new Background(new Vector2(0, 0), content.Load<Texture2D>("Images//russia"), new Point(800,600));

            barUser = new LoadingBar(new Vector2(10, 60));

            btMariaAntonieta = new Button(new Vector2(28, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_mantonieta"),
                content.Load<Texture2D>("Botoes//bthover_mantonieta"));

            btLuizXVI = new Button(new Vector2(78, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_luizxvi"),
                content.Load<Texture2D>("Botoes//bthover_luizxvi"));

            btGeorgesDanton = new Button(new Vector2(128, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_danton"),
                content.Load<Texture2D>("Botoes//bthover_danton"));

            btJeanPaulMarat = new Button(new Vector2(178, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_marat"),
                content.Load<Texture2D>("Botoes//bthover_marat"));

            btRobespierre = new Button(new Vector2(228, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_robespierre"),
                content.Load<Texture2D>("Botoes//bthover_robespierre"));
        }

        public override void Update(GameTime gameTime)
        {
            CheckButtons();

            barUser.Update();

            CharacterManager.Update();

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spritebatch)
        {
            if (background != null)
                background.Draw(spritebatch);

            CharacterManager.Draw(spritebatch);

            barUser.Draw(spritebatch);

            btMariaAntonieta.Draw(spritebatch);
            btLuizXVI.Draw(spritebatch);

            btGeorgesDanton.Draw(spritebatch);
            btJeanPaulMarat.Draw(spritebatch);
            btRobespierre.Draw(spritebatch);

            base.Draw(spritebatch);
        }

        public void CheckButtons()
        {
            btMariaAntonieta.Update();
            if (btMariaAntonieta.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            {
                barUser.SetLoading(0.7f, 1);
            }
            if (barUser.loadead && barUser.ID == 1)
            {
                CharacterManager.AddCharacter(new MariaAntonieta(SceneManager.content.Load<Texture2D>("Images//sprite_4")));
                barUser.ResetBar();
            }

            btLuizXVI.Update();
            if (btLuizXVI.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            {
                barUser.SetLoading(100, 2);
            }
            if (barUser.loadead && barUser.ID == 2)
            {
                CharacterManager.AddCharacter(new LuizXVI(SceneManager.content.Load<Texture2D>("SpriteT")));
                barUser.ResetBar();
            }

            btGeorgesDanton.Update();
            if (btGeorgesDanton.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            {
                barUser.SetLoading(0.9f, 3);
            }
            if (barUser.loadead && barUser.ID == 3)
            {
                CharacterManager.AddCharacter(new GeorgesDanton(SceneManager.content.Load<Texture2D>("SpriteT")));
                barUser.ResetBar();
            }

            btJeanPaulMarat.Update();
            if (btJeanPaulMarat.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            {
                barUser.SetLoading(1.0f, 4);
            }
            if (barUser.loadead && barUser.ID == 4)
            {
                CharacterManager.AddCharacter(new JeanPaulMarat(SceneManager.content.Load<Texture2D>("SpriteT")));
                barUser.ResetBar();
            }

            btRobespierre.Update();
            if (btRobespierre.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            {
                barUser.SetLoading(100, 5);
            }
            if (barUser.loadead && barUser.ID == 5)
            {
                CharacterManager.AddCharacter(new Robespierre(SceneManager.content.Load<Texture2D>("SpriteT")));
                barUser.ResetBar();
            }
        }
    }
}
