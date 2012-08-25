package game;

import java.awt.Point;

public class Revolutionary extends GameObject
{
	public Revolutionary(Point position, Point size, String filename)
	{
		super(position, size, filename);
	}
	
	@Override
	public void Update()
	{
		position.x -= 1;
	}
	
	private static final long serialVersionUID = 1L;
}
