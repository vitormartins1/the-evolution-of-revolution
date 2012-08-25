package Opponents;

import game.Opponent;

import java.awt.Point;

public class Hitler extends Opponent
{
	public Hitler(Point position, Point size, String filename)
	{
		super(position, size, filename);
	}

	@Override
	public void Update()
	{
		switch (state)
		{
		case WALKING:
			Walk();
			break;
		case FIGHTING:
			Fight();
			break;
		case DEAD:
			break;
		}
	}
	
	public void Walk()
	{
		position.x += 1;
	}
	
	public void Fight()
	{
		
	}
	
	private static final long serialVersionUID = 1L;
}
