package game;

import java.awt.Graphics2D;
import java.awt.Point;
import java.awt.event.KeyEvent;
import java.util.LinkedList;

public class Opening extends Scene
{
	Background background;
	TesteDeAnimacao t;
	
	public Opening()
	{
		background = new Background(new Point(0,0), new Point(800,600), "/images/bg_opening.png");
		
		LinkedList<Point> l = new LinkedList<Point>();
		l.add(new Point(0,7));
		t = new TesteDeAnimacao(l);
	}
	
	@Override
	public void Update()
	{
		if (Keyboard.getInstance().isKeyPressed(KeyEvent.VK_ENTER))
			SceneManager.ChangeScene(1);
		t.Update();
	}

	@Override
	public void Draw(Graphics2D graphics)
	{
		background.Draw(graphics);
		t.Draw(graphics);
	}
}
