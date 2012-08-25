package game;

import java.awt.Graphics2D;
import java.awt.Point;
import java.util.LinkedList;

import Opponents.Hitler;

public class CounterforceManager
{
	public LinkedList<Opponent> opponents;
	private int initialRevolutionaries;
	
	public CounterforceManager()
	{
		initialRevolutionaries = 1;
		
		opponents = new LinkedList<Opponent>();
		
		for (int i = 0; i < initialRevolutionaries; i++)
        {
            opponents.add(new Hitler(new Point(70,520), new Point(50, 60), "/images/megaman.png" ));
        }
	}
	
	public void Update()
	{
		for ( Opponent o : opponents)
			o.Update();
	}
	
	public void Draw(Graphics2D graphics)
	{
		for ( Opponent o : opponents)
			o.Draw(graphics);
	}
}
