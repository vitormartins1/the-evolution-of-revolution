package game;

import java.awt.*;
import java.applet.*;

abstract class GameObject extends Applet
{
	private static final long serialVersionUID = 1L;
	private Image image;
	public Point position;
	public Point dimension;
	
	public GameObject(  ){  };
	public GameObject(Point position, Point size, String filename)
	{
		this.position  = position;
		this.dimension = size;
		Load(filename);
	}

	public void Load(String filename)
	{
		Toolkit tk = Toolkit.getDefaultToolkit();

		image = tk.getImage(getClass().getResource(filename));
	}
	
	public void SetImage(Image image){ this.image = image; }

	public void Update() { }

	public void Draw(Graphics graphics)
	{
		graphics.drawImage(image, position.x, position.y, dimension.x, dimension.y, null);
	}
}