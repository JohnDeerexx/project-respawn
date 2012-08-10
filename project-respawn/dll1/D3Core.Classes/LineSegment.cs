using System;
namespace D3Core.Classes
{
	public sealed class LineSegment : IEquatable<LineSegment>
	{
		public Vector2 P1;
		public Vector2 P2;
		public LineSegment(Vector2 StartPoint, Vector2 EndPoint)
		{
			this.P1 = StartPoint;
			this.P2 = EndPoint;
		}
		public static bool Intersection_Dont_Use(LineSegment a, LineSegment b, out Vector2 IntersectionPoint)
		{
			IntersectionPoint = default(Vector2);
			Vector2 vector = a.P2 - a.P1;
			Vector2 vector2 = b.P2 - b.P1;
			float num = Vector2.Dot(vector, vector2);
			bool result;
			if (num < 1E-06f)
			{
				result = false;
			}
			else
			{
				Vector2 vector3 = a.P1 - b.P1;
				float num2 = Vector2.Dot(vector2, vector3);
				if (num2 < 0f || num2 > num)
				{
					result = false;
				}
				else
				{
					float num3 = Vector2.Dot(vector, vector3);
					if (num3 < 0f || num3 > num)
					{
						result = false;
					}
					else
					{
						IntersectionPoint = a.P1 + vector * (num2 / num);
						result = true;
					}
				}
			}
			return result;
		}
		public static bool Intersection(LineSegment a, LineSegment b, out Vector2 IntersectionPoint)
		{
			IntersectionPoint = default(Vector2);
			double num = (double)((b.P2.float_1 - b.P1.float_1) * (a.P2.float_0 - a.P1.float_0) - (b.P2.float_0 - b.P1.float_0) * (a.P2.float_1 - a.P1.float_1));
			bool result;
			if (num == 0.0)
			{
				result = false;
			}
			else
			{
				double num2 = (double)((b.P2.float_0 - b.P1.float_0) * (a.P1.float_1 - b.P1.float_1) - (b.P2.float_1 - b.P1.float_1) * (a.P1.float_0 - b.P1.float_0));
				double num3 = num2 / num;
				if (num3 < 0.0 || num3 > 1.0)
				{
					result = false;
				}
				else
				{
					double num4 = (double)((a.P2.float_0 - a.P1.float_0) * (a.P1.float_1 - b.P1.float_1) - (a.P2.float_1 - a.P1.float_1) * (a.P1.float_0 - b.P1.float_0));
					double num5 = num4 / num;
					if (num5 < 0.0 || num5 > 1.0)
					{
						result = false;
					}
					else
					{
						IntersectionPoint.float_0 = (float)((double)a.P1.float_0 + num3 * (double)(a.P2.float_0 - a.P1.float_0));
						IntersectionPoint.float_1 = (float)((double)a.P1.float_1 + num3 * (double)(a.P2.float_1 - a.P1.float_1));
						result = true;
					}
				}
			}
			return result;
		}
		public bool Equals(LineSegment other)
		{
			return this.P1 == other.P1 && this.P2 == other.P2;
		}
	}
}
