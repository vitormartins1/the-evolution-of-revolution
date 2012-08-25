package game;

import java.awt.*;

class Rect extends GameObject
{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	static Image rectImg;

	public Rect(Point position, Point size, int id)
	{
		super(position, size);
	}

	@Override
	public void load(String filename)
	{
		load(filename, 0);
	}

	public void load(String filename, int id)
	{
		Toolkit tk = Toolkit.getDefaultToolkit();

		rectImg = tk.getImage(getURL(filename));
	}

	@Override
	public void draw(Graphics g)
	{
		g.drawImage(rectImg, super.position.x, super.position.y, null);
	}
}
