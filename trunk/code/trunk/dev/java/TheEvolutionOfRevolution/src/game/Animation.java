package game;

import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Image;
import java.awt.Point;
import java.awt.Rectangle;
import java.awt.Toolkit;
import java.awt.image.BufferedImage;
import java.awt.image.ImageObserver;
import java.sql.Time;
import java.util.LinkedList;

/*
|--------------------------------------------------------------------|
|Programado por Willian Silva (Kipip) - williansilva.nave@gmail.com  |
|--------------------------------------------------------------------|
*/
    abstract class Animation
    {
	private static final long serialVersionUID = 1L;

		// Valores a serem multiplicados.
        public enum Facing { North, East, South, West} // Y.
        public enum State { Stand, Dead, Walk, Fight, Hit } // X. Também guarda o index a ser pego na lista de pontos.

        protected State state, lastState; // Carrega o estado do personagem.
        protected Facing facing, lastFacing; // Carrega a direção do personagem.

        protected int interval = 200; // Intervalo em milésimos.

        private Point positionValues;
        private LinkedList<Point> loopList; // Guarda os pontos de início e término de cada animação.
        private Image image, storedImage; // Guarda a malha de Sprites.
        private Point currentFrame; // Ponto para multiplicação final.
        private Rectangle frame; // Recorte da textura mostrado na tela.
        private int timer; // Contador de tempo.
        
        private int returningPoint; // Ponto de retorno quando chegar ao ponto final de animação.

        protected Animation(Facing facing, State state, Point frameCount,
        		LinkedList<Point> loopList, String filename)
        {
            timer = 0;
            
            this.currentFrame = new Point(0, 0);
            this.state = state;
            this.facing = facing;
            this.loopList = loopList;
            this.image = this.storedImage = Load(filename);
            frame = new Rectangle(
            		192 / frameCount.x,
            		256 / frameCount.y
            		);

            SetPoints();
        }

        protected Image Load(String filename)
        {
    		Toolkit tk = Toolkit.getDefaultToolkit();
    		
    		return image = tk.getImage(getClass().getResource(filename));
        }
        
      /*  protected void ChangeTexture(String filename, Point frameCount, )
        {
            this.image = this.storedImage = Load(filename);

            this.loopList = loopList;

            //Calcula o tamanho do frame.
            frame = new Rectangle(
            		image.getWidth(null) / frameCount.x,
            		image.getHeight(null) / frameCount.y
            		);

            SetPoints();
        }*/

        public void Update()
        {
        	
        	System.out.println(currentFrame.y);
            timer +=10; // Atualização de timer. * ~16 é 1000/60 *
            
            if (lastState != state || lastFacing != facing) { SetPoints(); } // Se alterar-se atualize-se.

            if (timer > interval) // Verificação de intervalo.
            {
                if (currentFrame.x < returningPoint) { currentFrame.x++; } // Passagem de frame.
                else { currentFrame.x = loopList.get(positionValues.y).x; } // Reseta o frame ao ponto inical do loop.

                timer-= interval; // Reseta o timer.
            }
        }
        
        public void Draw(Graphics graphics)
        {        	
            frame.x = currentFrame.x * frame.width;
            frame.y = currentFrame.y * frame.height;
            
            //Graphics test = this.image.getGraphics().create(frame.x, frame.y, frame.width, frame.height);
            //test.drawImage(image, 0, 0, 100, 100, frame.x, frame.y, frame.width, frame.height, null);
            BufferedImage img = new BufferedImage(frame.width, frame.height, BufferedImage.TYPE_INT_RGB);
            //img = image.getGraphics().getClip();
            	//image.getGraphics().clipRect(0, 0, 0, 0);
            graphics.drawImage(image, 0, 0, 192, 256, frame.x, frame.y, frame.width, frame.height, null);
        }

        //Mudar intervalo de frames.
        protected void SetFrameRate(int milliseconds) { interval = milliseconds; }

        private void SetPoints()
        {
        	positionValues = EnumReturner(facing, state);
        	
        	returningPoint = positionValues.y;
        	
            returningPoint = loopList.get(positionValues.x).y; // Define ponto de retorno.

            currentFrame.y = positionValues.y; // Define a linha da matriz de frames.
            currentFrame.x = loopList.get(positionValues.y).x; // Reseta o frame ao ponto inical do loop.

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
        		case East     : tempValue.y = 1; break;
        		case South    : tempValue.y = 2; break;
        		case West	  : tempValue.y = 3; break;
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