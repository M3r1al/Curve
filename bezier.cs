using System;
using Point;

public class bezier 
{
	int factorial(int n)
	{
		int f = 1;
		for (int i = 1; i < n; i++)
			f *= i;
		return f;
	}

	Point curve(Point[] points, float t)
	{
		Point curve = new Point(0, 0);
		for (int i = 0; i < points.Length; i++)
			curve += points[i] * factorial(points.Length - 1) / (factorial(i) * factorial(points.Length - 1 - i)) * (float)Math.Pow(t, i) * (float)Math.Pow(1 - t, points.Length - 1 - i);
		return curve;
	}
	
	Point derivative(Point[] points, float t)
	{
		Point curve = new Point(0, 0);
		for (int i = 0; i < points.Length; i++)
		{
			Point c = points[i] * factorial(points.Length - 1) / (factorial(i) * factorial(points.Length - 1 - i));
			if (i > 1)
				curve += c * i * (float)Math.Pow(t, i - 1) * (float)Math.Pow(1 - t, points.Length - 1 - i);
			if (points.Length - 1 - i > 1)
				curve -= c * (float)Math.Pow(t, i) * (points.Length - 1 - i) * (float)Math.Pow(1 - t, points.Length - 2 - i);
		}
		return curve;
	}
	
	float time(Point[] points, float x, float e = 0.0001f)
	{
		float t = 0.5f;
		float h = (curve(points, t).x - x) / (derivative(points, t).x - 1);
		while (Math.Abs(h) >= e)
		{
			h = (curve(points, t).x - x) / (derivative(points, t).x - 1);
			t -= h;
		}
		return t;
	}
}
