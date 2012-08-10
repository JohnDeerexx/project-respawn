using System;
namespace D3Core.Classes
{
	public struct Vector2 : IEquatable<Vector2>
	{
		private static Vector2 vector2_0;
		private static Vector2 vector2_1;
		public float float_0;
		public float float_1;
		public static Vector2 Zero
		{
			get
			{
				return Vector2.vector2_0;
			}
		}
		public static Vector2 One
		{
			get
			{
				return Vector2.vector2_1;
			}
		}
		static Vector2()
		{
			Vector2.vector2_0 = default(Vector2);
			Vector2.vector2_1 = new Vector2(1f, 1f);
		}
		public Vector2(float x, float y)
		{
			this.float_0 = x;
			this.float_1 = y;
		}
		public Vector2(float value)
		{
			this.float_1 = value;
			this.float_0 = value;
		}
		public static Vector2 operator -(Vector2 value)
		{
			Vector2 result;
			result.float_0 = -value.float_0;
			result.float_1 = -value.float_1;
			return result;
		}
		public static bool operator ==(Vector2 value1, Vector2 value2)
		{
			return (double)value1.float_0 == (double)value2.float_0 && (double)value1.float_1 == (double)value2.float_1;
		}
		public static bool operator !=(Vector2 value1, Vector2 value2)
		{
			return (double)value1.float_0 != (double)value2.float_0 || (double)value1.float_1 != (double)value2.float_1;
		}
		public static Vector2 operator +(Vector2 value1, Vector2 value2)
		{
			Vector2 result;
			result.float_0 = value1.float_0 + value2.float_0;
			result.float_1 = value1.float_1 + value2.float_1;
			return result;
		}
		public static Vector2 operator -(Vector2 value1, Vector2 value2)
		{
			Vector2 result;
			result.float_0 = value1.float_0 - value2.float_0;
			result.float_1 = value1.float_1 - value2.float_1;
			return result;
		}
		public static Vector2 operator *(Vector2 value1, Vector2 value2)
		{
			Vector2 result;
			result.float_0 = value1.float_0 * value2.float_0;
			result.float_1 = value1.float_1 * value2.float_1;
			return result;
		}
		public static Vector2 operator *(Vector2 value, float scaleFactor)
		{
			Vector2 result;
			result.float_0 = value.float_0 * scaleFactor;
			result.float_1 = value.float_1 * scaleFactor;
			return result;
		}
		public static Vector2 operator *(float scaleFactor, Vector2 value)
		{
			Vector2 result;
			result.float_0 = value.float_0 * scaleFactor;
			result.float_1 = value.float_1 * scaleFactor;
			return result;
		}
		public static Vector2 operator /(Vector2 value1, Vector2 value2)
		{
			Vector2 result;
			result.float_0 = value1.float_0 / value2.float_0;
			result.float_1 = value1.float_1 / value2.float_1;
			return result;
		}
		public static Vector2 operator /(Vector2 value, float divider)
		{
			float num = 1f / divider;
			Vector2 result;
			result.float_0 = value.float_0 * num;
			result.float_1 = value.float_1 * num;
			return result;
		}
		public override string ToString()
		{
			return string.Format("v2({0:0.0} {1:0.0})", this.float_0, this.float_1);
		}
		public bool Equals(Vector2 other)
		{
			return (double)this.float_0 == (double)other.float_0 && (double)this.float_1 == (double)other.float_1;
		}
		public override bool Equals(object obj)
		{
			bool result = false;
			if (obj is Vector2)
			{
				result = this.Equals((Vector2)obj);
			}
			return result;
		}
		public override int GetHashCode()
		{
			return this.float_0.GetHashCode() + this.float_1.GetHashCode();
		}
		public float Length()
		{
			return (float)Math.Sqrt((double)this.float_0 * (double)this.float_0 + (double)this.float_1 * (double)this.float_1);
		}
		public float LengthSquared()
		{
			return (float)((double)this.float_0 * (double)this.float_0 + (double)this.float_1 * (double)this.float_1);
		}
		public static float Distance(Vector2 value1, Vector2 value2)
		{
			float num = value1.float_0 - value2.float_0;
			float num2 = value1.float_1 - value2.float_1;
			return (float)Math.Sqrt((double)num * (double)num + (double)num2 * (double)num2);
		}
		public static void Distance(ref Vector2 value1, ref Vector2 value2, out float result)
		{
			float num = value1.float_0 - value2.float_0;
			float num2 = value1.float_1 - value2.float_1;
			float num3 = (float)((double)num * (double)num + (double)num2 * (double)num2);
			result = (float)Math.Sqrt((double)num3);
		}
		public static float DistanceSquared(Vector2 value1, Vector2 value2)
		{
			float num = value1.float_0 - value2.float_0;
			float num2 = value1.float_1 - value2.float_1;
			return (float)((double)num * (double)num + (double)num2 * (double)num2);
		}
		public static void DistanceSquared(ref Vector2 value1, ref Vector2 value2, out float result)
		{
			float num = value1.float_0 - value2.float_0;
			float num2 = value1.float_1 - value2.float_1;
			result = (float)((double)num * (double)num + (double)num2 * (double)num2);
		}
		public static float Dot(Vector2 vector1, Vector2 vector2)
		{
			return (float)((double)vector1.float_0 * (double)vector2.float_0 + (double)vector1.float_1 * (double)vector2.float_1);
		}
		public static void Dot(ref Vector2 vector1, ref Vector2 vector2, out float result)
		{
			result = (float)((double)vector1.float_0 * (double)vector2.float_0 + (double)vector1.float_1 * (double)vector2.float_1);
		}
		public void Normalize()
		{
			float num = 1f / (float)Math.Sqrt((double)this.float_0 * (double)this.float_0 + (double)this.float_1 * (double)this.float_1);
			this.float_0 *= num;
			this.float_1 *= num;
		}
		public static Vector2 Normalize(Vector2 value)
		{
			float num = 1f / (float)Math.Sqrt((double)value.float_0 * (double)value.float_0 + (double)value.float_1 * (double)value.float_1);
			Vector2 result;
			result.float_0 = value.float_0 * num;
			result.float_1 = value.float_1 * num;
			return result;
		}
		public static void Normalize(ref Vector2 value, out Vector2 result)
		{
			float num = 1f / (float)Math.Sqrt((double)value.float_0 * (double)value.float_0 + (double)value.float_1 * (double)value.float_1);
			result.float_0 = value.float_0 * num;
			result.float_1 = value.float_1 * num;
		}
	}
}
