package game;

import java.awt.Graphics2D;

public class SceneManager
{
	public static Scene scene;
	private static SCENE currentScene;
	
	private SceneManager()
	{
		
	}
	
	public static void Setup()
	{
		scene = new Opening();
		currentScene = SCENE.OPENING;
	}
	
	public static void ChangeScene(int scene)
	{
		
	}
	
	public static void Update()
	{
		scene.Update();
	}
	
	public static void Draw(Graphics2D g2d)
	{
		scene.Draw(g2d);
	}
	
	enum SCENE
	{
		OPENING,
		MENU,
		GAME,
		GAMEOVER,
	}
}
