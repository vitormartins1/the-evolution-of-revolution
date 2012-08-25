package game;

import java.awt.Point;

public class GeorgeWashington extends Revolutionary
{

	public GeorgeWashington(Point position, Point size, String filename)
	{
		super(position, size, filename);
	}

	@Override
	public void Update()
	{
		position.x -= 2;
	}
	
	private static final long serialVersionUID = 1L;

}
