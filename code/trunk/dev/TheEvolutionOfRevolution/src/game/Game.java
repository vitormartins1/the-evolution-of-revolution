package game;

import java.awt.*;
import java.awt.image.*;
import java.applet.*;
import java.util.*;

public class Game extends Applet implements Runnable
{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	public static final int screenWidth  = 800;
	public static final int screenHeigth = 600;
	
	BufferedImage backbuffer;
	Graphics2D g2d;

	Thread gameLoop;
	Random rand = new Random();
	
	Core core = new Core();

	public void init()
	{
		this.backbuffer = new BufferedImage(screenWidth, screenHeigth, BufferedImage.TYPE_INT_RGB);

		this.g2d = backbuffer.createGraphics();
		
		addKeyListener(Keyboard.getInstance());
		setFocusable(true);

	//	SceneManager.setup();
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
		Thread t = Thread.currentThread();

		while (t == this.gameLoop)
		{
			try
			{
				Thread.sleep(10);				
			}
			catch (InterruptedException e)
			{
				e.printStackTrace();
			}	
			
			//Time.Update();	
			
			//SceneManager.scene.update();		
			repaint();
		}
	}

	public void update(Graphics g)
	{		
		//SceneManager.scene.update();	
		core.update();
		paint(g);
	}

	public void paint(Graphics g)
	{
		//SceneManager.scene.draw(g2d);		

		core.draw(g2d);
		
		g.drawImage(backbuffer, 0, 0, this);
	}
}