package game;

import java.awt.Point;
import java.awt.event.KeyEvent;

public class Player extends GameObject
{
	private static final long serialVersionUID = 1L;
	
	public Player(Point position, Point dimension, String filename) 
	{
		super(position, dimension, filename); 
	}

	@Override
    public void update()
    {	
		if (Keyboard.getInstance().isKeyPressed(KeyEvent.VK_LEFT))
		{
			super.position.x-=10;
		}
		else if (Keyboard.getInstance().isKeyPressed(KeyEvent.VK_RIGHT))
		{
			super.position.x+=10;
		}
		
        super.update();
    }
}