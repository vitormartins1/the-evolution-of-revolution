package game;

import java.awt.Graphics2D;
import java.awt.Point;
import java.awt.event.KeyEvent;

public class Opening extends Scene
{
	Background background; 
	
	public Opening()
	{
		background = new Background(new Point(0,0), new Point(800,600), "/images/bg_opening.png");
	}
	
	@Override
	public void Update()
	{
		if (Keyboard.getInstance().isKeyPressed(KeyEvent.VK_ENTER))
		{
			SceneManager.scene = new GameLevel();
		}
	}

	@Override
	public void Draw(Graphics2D graphics)
	{
		background.draw(graphics);
	}
}
