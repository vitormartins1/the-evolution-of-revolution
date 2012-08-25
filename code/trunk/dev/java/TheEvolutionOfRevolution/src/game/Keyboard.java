package game;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.ArrayList;
import java.util.List;

public class Keyboard implements KeyListener
{
	static private Keyboard instance = null;
	
	private List<Integer> keyCode = new ArrayList<Integer>();
	
	static public Keyboard getInstance()
	{
		if (instance == null){ instance = new Keyboard(); }
		
		return instance;
	}

	@Override
	public void keyPressed(KeyEvent keyEvent) 
	{
		int keyValue = keyEvent.getKeyCode();
		
		for (int i : keyCode){ if (i == keyValue) return; }
		
		this.keyCode.add(keyValue);		
	}

	@Override
	public void keyReleased(KeyEvent keyEvent)
	{
		int keyValue = keyEvent.getKeyCode();
		
		for (int i = 0; i < keyCode.size(); i++)
		{
			if (keyCode.get(i) == keyValue) { this.keyCode.remove(i); }
		}
	}

	@Override
	public void keyTyped(KeyEvent keyEvent) { }

	public boolean isKeyPressed(int keyValue)
	{
		for (int i: keyCode) if (i == keyValue) { return true; }
		
		return false;
	}
}
