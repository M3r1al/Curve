using System;
using Point;

public class lagrange 
{
	Point curveLagrange(Point points, float x)
	{    
		Vector2 curve = new Vector2(x, 0);
		for(int i = 0; i < points.Length; i++)
		{
			float dx = points[i].y;
			for (int k = 0; k < points.Length; k++)
				if (k != i)
					dx *= (x - points[k].x) / (points[i].x - points[k].x);
			curve.y += dx;
		}
		return curve;       
}
}