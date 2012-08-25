package game;

import java.awt.Point;
import java.util.LinkedList;

public class TesteDeAnimacao extends Animation
{
	private static final long serialVersionUID = 1L;

	public TesteDeAnimacao(LinkedList<Point> l)
	{	
		super(Facing.North, State.Stand,new Point(4, 7),l,  "/images/Sprite.png");
	}
}
