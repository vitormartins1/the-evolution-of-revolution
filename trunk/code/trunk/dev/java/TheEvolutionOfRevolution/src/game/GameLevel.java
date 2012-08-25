package game;

import java.awt.Graphics2D;
import java.awt.Point;

public class GameLevel extends Scene
{
	Background background;
	Player player;
	RevolutionManager revolution;
	CounterforceManager counterforce;
	
	public GameLevel()
	{
		background = new Background(new Point(0,0), new Point(800,600), "/images/bg_game.png");
		player = new Player(new Point(300, 400), new Point(100, 125), "/images/cat_1.png" );
		revolution = new RevolutionManager();
		counterforce = new CounterforceManager();
	}
	
	@Override
	public void Update()
	{
		player.Update();
		revolution.Update();
		counterforce.Update();
		
		for (int i = 0; i < revolution.revolutionaries.size(); i++)
        {
			for (int j = 0; j < counterforce.opponents.size(); j++)
	        {
				if (Collision.CheckCollision(revolution.revolutionaries.get(i), counterforce.opponents.get(j)))
				{
					revolution.revolutionaries.get(i).fighting = true;
					counterforce.opponents.get(j).fighting = true;
				}
	        }
        }
	}

	@Override
	public void Draw(Graphics2D graphics)
	{
		background.Draw(graphics);
		player.Draw(graphics);
		revolution.Draw(graphics);
		counterforce.Draw(graphics);
	}
}
