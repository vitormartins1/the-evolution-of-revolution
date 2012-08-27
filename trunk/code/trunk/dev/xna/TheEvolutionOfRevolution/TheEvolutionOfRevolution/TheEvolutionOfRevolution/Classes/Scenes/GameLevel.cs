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
        Button btSoldado_01;

        Button btRobespierre;
        Button btJeanPaulMarat;
        Button btGeorgesDanton;

        LoadingBar barUser;

        //
        ComputerBehavior COMPUTER;
        //

        public GameLevel() { }

        public override void LoadContent(ContentManager content)
        {
            COMPUTER = new ComputerBehavior(content);

            Bar.Initialize();

            base.LoadContent(content);
            this.background = new Background(new Vector2(0, 0), content.Load<Texture2D>("Images//russia"), new Point(800,600));

            barUser = new LoadingBar(new Vector2(648, 55));

            btMariaAntonieta = new Button(new Vector2(28 - 17, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_mantonieta"),
                content.Load<Texture2D>("Botoes//bthover_mantonieta"));
            btMariaAntonieta.displayer.SetString("Maria Antonieta", CharacterBalance.mariaAttack, CharacterBalance.mariaVelocity, CharacterBalance.mariaHP);

            btLuizXVI = new Button(new Vector2(78 - 17, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_luizxvi"),
                content.Load<Texture2D>("Botoes//bthover_luizxvi"));
            btLuizXVI.displayer.SetString("Luiz XVI", CharacterBalance.luizAttack, CharacterBalance.luizVelocity, CharacterBalance.luizHP);

            btSoldado_01 = new Button(new Vector2(128 - 17, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_soldado_01"),
                content.Load<Texture2D>("Botoes//bthover_soldado_01"));
            btSoldado_01.displayer.SetString("Soldado", CharacterBalance.soldado_01Attack, CharacterBalance.soldado_01Velocity, CharacterBalance.soldado_01HP);

            btGeorgesDanton = new Button(new Vector2(178+470, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_danton"),
                content.Load<Texture2D>("Botoes//bthover_danton"));
            btGeorgesDanton.displayer.SetString("Georges Danton", CharacterBalance.dantonAttack, CharacterBalance.dantonVelocity, CharacterBalance.dantonHP);

            btJeanPaulMarat = new Button(new Vector2(228+470, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_marat"),
                content.Load<Texture2D>("Botoes//bthover_marat"));
            btJeanPaulMarat.displayer.SetString("Marat", CharacterBalance.maratAttack, CharacterBalance.maratVelocity, CharacterBalance.maratHP);

            btRobespierre = new Button(new Vector2(278 + 470, 9), new Point(40, 40),
                content.Load<Texture2D>("Botoes//bt_robespierre"),
                content.Load<Texture2D>("Botoes//bthover_robespierre"));
            btRobespierre.displayer.SetString("Robespierre", CharacterBalance.robespierreAttack, CharacterBalance.robespierreVelocity, CharacterBalance.robespierreHP);
            
        }

        public override void Update(GameTime gameTime)
        {
            Bar.Update();

            COMPUTER.Update();

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
            btSoldado_01.Draw(spritebatch);

            btGeorgesDanton.Draw(spritebatch);
            btJeanPaulMarat.Draw(spritebatch);
            btRobespierre.Draw(spritebatch);

            COMPUTER.Draw(spritebatch);

            Bar.Draw(spritebatch);

            base.Draw(spritebatch);
        }

        public void CheckButtons()
        {
            btMariaAntonieta.Update();
            //if (btMariaAntonieta.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            //{
            //    barUser.SetLoading(CharacterBalance.mariaDelay, 1);
            //}
            //if (barUser.loadead && barUser.ID == 1)
            //{
            //    CharacterManager.AddCharacter(new MariaAntonieta(SceneManager.content.Load<Texture2D>("Images//mantonieta")));
            //    barUser.ResetBar();
            //}

            btLuizXVI.Update();
            //if (btLuizXVI.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            //{
            //    barUser.SetLoading(CharacterBalance.luizDelay, 2);
            //}
            //if (barUser.loadead && barUser.ID == 2)
            //{
            //    CharacterManager.AddCharacter(new LuizXVI(SceneManager.content.Load<Texture2D>("SpriteT")));
            //    barUser.ResetBar();
            //}

            btSoldado_01.Update();
            //if (btSoldado_01.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            //{
            //    barUser.SetLoading(CharacterBalance.soldado_01Delay, 6);
            //}
            //if (barUser.loadead && barUser.ID == 6)
            //{
            //    CharacterManager.AddCharacter(new Soldado_01(SceneManager.content.Load<Texture2D>("SpriteT")));
            //    barUser.ResetBar();
            //}

            btGeorgesDanton.Update();
            if (btGeorgesDanton.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            {
                barUser.SetLoading(CharacterBalance.dantonDelay, 3);
            }
            if (barUser.loadead && barUser.ID == 3)
            {
                CharacterManager.AddCharacter(new GeorgesDanton(SceneManager.content.Load<Texture2D>("SpriteT")));
                barUser.ResetBar();
            }

            btJeanPaulMarat.Update();
            if (btJeanPaulMarat.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            {
                barUser.SetLoading(CharacterBalance.maratDelay, 4);
            }
            if (barUser.loadead && barUser.ID == 4)
            {
                CharacterManager.AddCharacter(new JeanPaulMarat(SceneManager.content.Load<Texture2D>("SpriteT")));
                barUser.ResetBar();
            }

            btRobespierre.Update();
            if (btRobespierre.GetBehavior().PRESSED && !barUser.loading && barUser.ID == 0)
            {
                barUser.SetLoading(CharacterBalance.robespierreDelay, 5);
            }
            if (barUser.loadead && barUser.ID == 5)
            {
                CharacterManager.AddCharacter(new Robespierre(SceneManager.content.Load<Texture2D>("SpriteT")));
                barUser.ResetBar();
            }
        }
    }
}
