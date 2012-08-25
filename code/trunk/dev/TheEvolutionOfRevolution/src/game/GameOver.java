package game;

import java.awt.Graphics2D;
import java.awt.Point;

public class GameOver extends Scene
{
	Background background;
	
	public GameOver()
	{
		background = new Background(new Point(0,0), new Point(800,600), "/images/bg_gameover.png");
	}
	
	@Override
	public void Update()
	{	
	}

	@Override
	public void Draw(Graphics2D graphics)
	{
		background.draw(graphics);
	}
}
