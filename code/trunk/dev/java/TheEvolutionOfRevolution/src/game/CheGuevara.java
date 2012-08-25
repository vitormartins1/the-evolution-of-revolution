package game;

import java.awt.Point;

public class CheGuevara extends Revolutionary
{

	public CheGuevara(Point position, Point size, String filename)
	{
		super(position, size, filename);
	}

	@Override
	public void Update()
	{
		if (!fighting)
			position.x -= 1;
	}
	
	private static final long serialVersionUID = 1L;

}
