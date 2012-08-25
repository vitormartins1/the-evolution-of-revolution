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
	
	public static void ChangeScene(int indexScene)
	{
		switch (indexScene)
		{
		case 0:
			scene = new Opening();
			currentScene = SCENE.OPENING;
			break;
		case 1:
			scene = new GameLevel();
			currentScene = SCENE.GAME;
			break;
		case 2:
			scene = new GameOver();
			currentScene = SCENE.GAMEOVER;
			break;
		}
	}
	
	public static void Update()
	{
		scene.Update();
	}
	
	public static void Draw(Graphics2D graphics)
	{
		scene.Draw(graphics);
	}
	
	enum SCENE
	{
		OPENING,
		MENU,
		GAME,
		GAMEOVER,
	}
}
