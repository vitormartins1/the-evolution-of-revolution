package game;

import java.awt.*;
import java.applet.*;
import java.net.*;

abstract class GameObject extends Applet
{
	private static final long serialVersionUID = 1L;
	private Image image;
	public Point position;
	public Point dimension;
	
	public GameObject(Point position, Point size)
	{
		this.position  = position;
		this.dimension = size;
	}

	public Image getImage() {
		return image;
	}

	public void setImage(Image image) {
		this.image = image;
	}

	protected URL getURL(String filename)
	{
		URL url = null;
		try
		{
			url = this.getClass().getResource(filename);
		}
		catch (Exception e) { }
		return url;
	}

	public void load(String filename)
	{
		Toolkit tk = Toolkit.getDefaultToolkit();

		image = tk.getImage(getURL(filename));
	}

	public  void update()
	{
	
	}

	public void draw(Graphics g)
	{
		g.drawImage(image, (int)this.position.getX(), (int)this.position.getY(), 
				(int)this.dimension.getX(), (int)this.dimension.getY(), this);
	}
}
