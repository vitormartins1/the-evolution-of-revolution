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
		initialRevolutionaries = 5;
		
		revolutionaries = new LinkedList<Revolutionary>();
		
		for (int i = 0; i < initialRevolutionaries; i++)
        {
            revolutionaries.add(new Revolutionary(new Point(700,520), new Point(50, 60), "/images/megaman.gif" ));
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
