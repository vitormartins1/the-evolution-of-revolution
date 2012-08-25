package game;

import java.awt.Point;
import java.util.LinkedList;

public class TesteDeAnimacao extends Animation
{
	private static final long serialVersionUID = 1L;

	public TesteDeAnimacao()
	{
		super(Facing.North, State.Stand);
		
		LinkedList<Point> l = new LinkedList<Point>();
		l.add(new Point(0,0));
		l.add(new Point(1,2));
		l.add(new Point(3,7));
		super.ChangeTexture(super.Load("/images/cat_1.png"), new Point(4,7), l);
	}
}
