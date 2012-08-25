package game;

import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.ArrayList;
import java.util.List;

public class Keyboard implements KeyListener
{
	static private Keyboard instance = null;
	
	private List<Integer> keyCode = new ArrayList<Integer>();
	
	//private Keyboard(){}
	
	static public Keyboard getInstance()
	{
		if (instance == null)
		{
			instance = new Keyboard();
		}
		
		return instance;
	}

	@Override
	public void keyPressed(KeyEvent k) 
	{
		int aux = k.getKeyCode();
		
		for (int i : keyCode)
			if (i == aux)
				return;
		
		this.keyCode.add(aux);		
	}

	@Override
	public void keyReleased(KeyEvent k)
	{
		int aux = k.getKeyCode();
		
		for (int i = 0; i < keyCode.size(); i++)
		{
			if (keyCode.get(i) == aux)
			{
				this.keyCode.remove(i);		
			}
		}
	}

	@Override
	public void keyTyped(KeyEvent k) 
	{
		
	}
	
	public void clear()
	{
		this.keyCode.clear();
	}
	
	public boolean isKeyPressed(int k)
	{
		for (int i: keyCode)
		{
			if (i == k)
			{
				return true;
			}
		}
		
		return false;
	}
}
