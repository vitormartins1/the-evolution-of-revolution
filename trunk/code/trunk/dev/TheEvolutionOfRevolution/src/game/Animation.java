package game;

import java.awt.Image;
import java.awt.Point;
import java.awt.Rectangle;
import java.util.LinkedList;

/*
|--------------------------------------------------------------------|
|Programado por Willian Silva (Kipip) - williansilva.nave@gmail.com  |
|--------------------------------------------------------------------|
*/

    abstract class Animation extends GameObject
    {
	private static final long serialVersionUID = 1L;

		// Valores a serem multiplicados.
        public enum Facing { North, NorthEast, East, SouthEast, South, SouthWest, West, NorthWest } // Y.
        public enum State { Stand, Dead, Walk, Fight, Hit } // X. Também guarda o index a ser pego na lista de pontos.

        protected State state, lastState; // Carrega o estado do personagem.
        protected Facing facing, lastFacing; // Carrega a direção do personagem.

       ///// protected TimeSpan interval = TimeSpan.FromMilliseconds(200); // Intervalo em milésimos.

        private Point frameCount; // Contagem de frames.
        private LinkedList<Point> loopList; // Guarda os pontos de início e término de cada animação.
        private Image image; // Guarda a malha de Sprites.
        private Point currentFrame; // Ponto para multiplicação final.
        private Rectangle frame; // Recorte da textura mostrado na tela.
       ////// private TimeSpan timer; // Contador de tempo.
        
        private int returningPoint; // Ponto de retorno quando chegar ao ponto final de animação.

        protected Animation(Facing facing, State state)
        {
        	super(frameCount, size, filename)
            ////timer = TimeSpan.Zero;
            ////this.color = Color.White;
            this.state = state;
            this.facing = facing;
            this.loopList = new LinkedList<Point>();
        }
        /// <summary>Colocar uma nova textura e novos loops./// </summary>
        /// <param name="loops">Tamanho string[2]; Armazena inicio e término dos loops.</param>
        /// <param name="frameCount">Coluna e linha da matriz de frames.</param>
        protected void ChangeTexture(Image image)
        {
            this.image = image;

            /////this.frameCount = package.PointValue;
            /////this.loopList = package.PointList;

            //Calcula o tamanho do frame.
            frame = new Rectangle(
            		image.getWidth(null) / frameCount.x,
            		image.getHeight(null) / frameCount.y
            		);

            SetPoints();
        }

        public void Update()
        {
            //////timer += TimeSpan.FromMilliseconds(16); // Atualização de timer. * ~16 é 1000/60 *
            
            if (lastState != state || lastFacing != facing) { SetPoints(); } // Se alterar-se atualize-se.

            /*if (timer > interval) // Verificação de intervalo.
            {
                if (currentFrame.X < returningPoint) { currentFrame.X++; } // Passagem de frame.
                else { currentFrame.X = loopList[(int)state].X; } // Reseta o frame ao ponto inical do loop.

                timer -= interval; // Reseta o timer.
            }*/
        }

        public void Draw(Point position)
        {
            frame.x = currentFrame.x * frame.width;
            frame.y = currentFrame.y * frame.height;
            //////spriteBatch.Draw(image
        }

        //Mudar intervalo de frames.
        protected void SetFrameRate(int milliseconds) { interval = TimeSpan.FromMilliseconds(milliseconds); }

        private void SetPoints()
        {
        	Point PositionValues = EnumReturner(facing, state);
            returningPoint = loopList.get(PositionValues.x).y; // Define ponto de retorno.

            currentFrame.y = PositionValues.y; // Define a linha da matriz de frames.
            currentFrame.x = loopList.get(PositionValues.y).x; // Reseta o frame ao ponto inical do loop.

            // Define os últimos estados. * Para verificação de atualização*
            lastState = state;
            lastFacing = facing;
        }
        
        private Point EnumReturner(Facing facing, State state)
        {
        	Point tempValue = new Point();
        	
        	switch(facing)
        	{
        		case North    : tempValue.y = 0; break;
        		case NorthEast: tempValue.y = 1; break;
        		case East     : tempValue.y = 2; break;
        		case SouthEast: tempValue.y = 3; break;
        		case South    : tempValue.y = 4; break;
        		case SouthWest: tempValue.y = 5; break;
        		case West	  : tempValue.y = 6; break;
        		case NorthWest: tempValue.y = 7; break;
        	}
        	
        	switch(state)
        	{
        		case Stand: tempValue.x = 0; break;
        		case Walk : tempValue.x = 1; break;
        		case Dead : tempValue.x = 2; break;
        		case Fight: tempValue.x = 3; break;
        		case Hit  : tempValue.x = 4; break;
        	}
        	
        	return tempValue;
        }
    }