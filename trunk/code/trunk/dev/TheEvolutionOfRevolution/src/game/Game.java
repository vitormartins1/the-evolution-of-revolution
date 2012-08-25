package game;

import java.awt.*;
import java.awt.image.*;
import java.applet.*;
import java.util.*;

public class Game extends Applet implements Runnable
{
	private static final long serialVersionUID = 1L;
	
	public static final int screenWidth  = 800;
	public static final int screenHeigth = 600;
	
	BufferedImage bufferedImage;
	Graphics2D graphics2D;

	Thread gameLoop;
	Random rand = new Random();
	
	Core core = new Core();

	public void init()
	{
		this.bufferedImage = new BufferedImage(screenWidth, screenHeigth, BufferedImage.TYPE_INT_RGB);

		this.graphics2D = bufferedImage.createGraphics();
		
		addKeyListener(Keyboard.getInstance());
	}

	public void start()
	{
		this.gameLoop = new Thread(this);
		this.gameLoop.start();
	}

	public void stop()
	{
		this.gameLoop = null;
	}

	public void run()
	{
		Thread thread = Thread.currentThread();

		while (thread == this.gameLoop)
		{
			try { Thread.sleep(10); }
			catch (InterruptedException e) { e.printStackTrace(); }	
					
			repaint();
		}
	}

	public void update(Graphics graphics)
	{		
		core.update();
		
		paint(graphics);
	}

	public void paint(Graphics graphics)
	{	
		core.draw(graphics2D);
		
		graphics.drawImage(bufferedImage, 0, 0, this);
	}
}