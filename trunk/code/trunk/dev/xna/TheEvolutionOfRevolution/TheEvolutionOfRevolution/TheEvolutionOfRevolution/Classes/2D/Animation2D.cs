/*
|--------------------------------------------------------------------|
|Programado por Willian Silva (Kipip) - williansilva.nave@gmail.com  |
|--------------------------------------------------------------------|
*/

#region Microsoft
using System;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace Foxpaw.Game2D.Graphics
{
    abstract class Animation
    {
        #region Variáveis
        // Valores a serem multiplicados.
        public enum Facing { North, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest } // Y.
        public enum State { Stand, Sit, Dead, Pick, Walk, Fight, Hurt, Hit } // X. Também guarda o index a ser pego na lista de pontos.

        protected Color color; // Cor de filtro.
        protected State state, lastState; // Carrega o estado do personagem.
        protected Facing facing, lastFacing; // Carrega a direção do personagem.

        protected TimeSpan interval = TimeSpan.FromMilliseconds(200); // Intervalo em milésimos.

        private Point frameCount; // Contagem de frames.
        private List<Point> loopList; // Guarda os pontos de início e término de cada animação.
        private Texture2D texture; // Guarda a malha de Sprites.
        private Point currentFrame; // Ponto para multiplicação final.
        private Rectangle frame; // Recorte da textura mostrado na tela.
        private TimeSpan timer; // Contador de tempo.
        
        private int returningPoint; // Ponto de retorno quando chegar ao ponto final de animação.
        #endregion

        protected Animation(Facing facing, State state)
        {
            timer = TimeSpan.Zero;
            this.color = Color.White;
            this.state = state;
            this.facing = facing;
            this.loopList = new List<Point>();
        }
        /// <summary>Colocar uma nova textura e novos loops./// </summary>
        /// <param name="loops">Tamanho string[2]; Armazena inicio e término dos loops.</param>
        /// <param name="frameCount">Coluna e linha da matriz de frames.</param>
        protected void ChangeTexture(Texture2D texture, Point frameCount, List<Point> loopList)
        {
            this.texture = texture;

            this.frameCount = frameCount;
            this.loopList = loopList;

            //Calcula o tamanho do frame.
            frame = new Rectangle(0, 0, texture.Width / frameCount.X, texture.Height / frameCount.Y);

            SetPoints();
        }

        public virtual void Update()
        {
            timer += TimeSpan.FromMilliseconds(16); // Atualização de timer. * ~16 é 1000/60 *
            
            if (lastState != state || lastFacing != facing) { SetPoints(); } // Se alterar-se atualize-se.

            if (timer > interval) // Verificação de intervalo.
            {
                if (currentFrame.X < returningPoint) { currentFrame.X++; } // Passagem de frame.
                else { currentFrame.X = loopList[(int)state].X; } // Reseta o frame ao ponto inical do loop.

                timer -= interval; // Reseta o timer.
            }
        }

        public virtual void Draw(ref Vector2 position, SpriteBatch spriteBatch)
        {
            frame.X = currentFrame.X * frame.Width;
            frame.Y = currentFrame.Y * frame.Height;

            float myDepth = position.Y * 0.001f;

            spriteBatch.Draw(texture, position, frame, color, 0, Vector2.Zero, 1, SpriteEffects.None, myDepth);
        }

        //Mudar intervalo de frames.
        protected void SetFrameRate(int milliseconds) { interval = TimeSpan.FromMilliseconds(milliseconds); }

        private void SetPoints()
        {
            returningPoint = loopList[(int)state].Y; // Define ponto de retorno.

            currentFrame.Y = (int)facing; // Define a linha da matriz de frames.
            currentFrame.X = loopList[(int)state].X; // Reseta o frame ao ponto inical do loop.

            // Define os últimos estados. * Para verificação de atualização*
            lastState = state;
            lastFacing = facing;
        }
    }
}