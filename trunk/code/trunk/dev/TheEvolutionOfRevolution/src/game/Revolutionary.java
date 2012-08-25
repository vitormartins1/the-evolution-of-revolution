package game;

import game.Opponent.STATE;

import java.awt.Point;

public abstract class Revolutionary extends GameObject
{
	public STATE state;
	
	public Revolutionary(Point position, Point size, String filename)
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