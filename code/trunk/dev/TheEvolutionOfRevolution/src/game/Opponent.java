package game;

import java.awt.Point;

public abstract class Opponent extends GameObject
{
	public boolean fighting;
	
	public Opponent(Point position, Point size, String filename)
	{
		super(position, size, filename);
	}
	
	private static final long serialVersionUID = 1L;
}