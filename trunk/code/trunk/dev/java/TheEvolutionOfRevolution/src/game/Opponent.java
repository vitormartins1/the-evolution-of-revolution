package game;

import java.awt.Point;

public abstract class Opponent extends GameObject
{
	public STATE state;
	
	public Opponent(Point position, Point size, String filename)
	{
		super(position, size, filename);
		state = STATE.WALKING;
	}
	
	private static final long serialVersionUID = 1L;
	
	public enum STATE
	{
		WALKING,
		FIGHTING,
		DEAD,
	}
}