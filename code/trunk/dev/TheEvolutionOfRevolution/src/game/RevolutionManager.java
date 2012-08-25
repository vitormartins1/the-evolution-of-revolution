package game;

import java.awt.Graphics2D;
import java.awt.Point;
import java.util.LinkedList;

public class RevolutionManager
{
	private LinkedList<Revolutionary> revolutionaries;
	private int initialRevolutionaries;
	
	public RevolutionManager()
	{
		initialRevolutionaries = 1;
		
		for (int i = 0; i < initialRevolutionaries; i++)
        {
            revolutionaries.add(new Revolutionary(new Point(700,10), new Point(10, 50), "/images/cat_1.png" ));
        }
	}
	
	public void Update()
	{
		for ( Revolutionary r : revolutionaries)
		{
			r.Update();
		}
	}
	
	public void Draw(Graphics2D graphics)
	{
		for ( Revolutionary r : revolutionaries)
		{
			r.Draw(graphics);
		}
	}
}
