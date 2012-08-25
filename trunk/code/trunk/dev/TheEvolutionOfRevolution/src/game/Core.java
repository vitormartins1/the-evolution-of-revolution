package game;

import java.awt.Graphics2D;

public class Core 
{	
	public Core()
	{
		SceneManager.Setup();
	}

	public void update()
	{
        SceneManager.scene.Update();
    }

	public void draw(Graphics2D graphics)
	{
		graphics.clearRect(0, 0, 800, 600);
		
		SceneManager.scene.Draw(graphics);
	}
}