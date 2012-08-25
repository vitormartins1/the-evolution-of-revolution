package game;

import java.awt.Graphics2D;
import java.awt.Point;

public class Opening extends Scene
{
	Background background; 
	
	public Opening()
	{
		background = new Background(new Point(0,0), new Point(800,600), "/images/cat_1.png");
	}
	
	@Override
	public void Update()
	{
	}

	@Override
	public void Draw(Graphics2D g2d)
	{
	}
}
