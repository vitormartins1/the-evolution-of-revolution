package game;

import java.awt.Graphics2D;
import java.awt.Point;

public class Core 
{
	Player player;
	
	public Core()
	{	
		player = new Player(new Point(300, 400), new Point(100, 125));
		player.load( "/images/cat_1.png" );
	}

	public void update()
	{
        player.update();
    }

	public void draw(Graphics2D graphics)
	{
		graphics.clearRect(0, 0, 800, 600);
		
		player.draw(graphics);
	}
}