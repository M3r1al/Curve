using System;

namespace Point
{
	[Serializable]
	public struct Point
	{
		public float x, y;
		public Point(float x, float y)
		{
			this.x = x;
			this.y = y;
		}
		public static Point operator +(Point a, Point b) => new Point(a.x + b.x, a.y + b.x);
		public static Point operator -(Point a, float d) => new Point(a.x - d, a.y - d);
		public static Point operator -(Point a, Point b) => new Point(a.x - b.x, a.y - b.y);
		public static Point operator *(float d, Point a) => new Point(a.x * d, a.y * d);
		public static Point operator *(Point a, float d) => new Point(a.x * d, a.y * d);
		public static Point operator *(Point a, Point b) => new Point(a.x * b.x, a.x * b.y);
		public static Point operator /(Point a, float d) => new Point(a.x / d, a.y / d);
		public static Point operator /(Point a, Point b) => new Point(a.x / b.x, a.y / b.y);
		public static bool operator ==(Point lhs, Point rhs) => lhs.x == rhs.x && lhs.y == rhs.y;
		public static bool operator !=(Point lhs, Point rhs) => lhs.x != rhs.x || lhs.y != rhs.y;
	}
}