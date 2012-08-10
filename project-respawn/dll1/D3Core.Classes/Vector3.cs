using System;
namespace D3Core.Classes
{
	[Serializable]
	public struct Vector3 : IEquatable<Vector3>
	{
		private static Vector3 _zero;
		private static Vector3 _one;
		public float float_0;
		public float float_1;
		public float float_2;
		public static Vector3 Zero
		{
			get
			{
				return Vector3._zero;
			}
		}
		public static Vector3 One
		{
			get
			{
				return Vector3._one;
			}
		}
		static Vector3()
		{
			Vector3._zero = default(Vector3);
			Vector3._one = new Vector3(1f, 1f, 1f);
		}
		public Vector3(float x, float y, float z)
		{
			this.float_0 = x;
			this.float_1 = y;
			this.float_2 = z;
		}
		public Vector3(float value)
		{
			this.float_2 = value;
			this.float_1 = value;
			this.float_0 = value;
		}
		public static Vector3 operator -(Vector3 value)
		{
			Vector3 result;
			result.float_0 = -value.float_0;
			result.float_1 = -value.float_1;
			result.float_2 = -value.float_2;
			return result;
		}
		public static bool operator ==(Vector3 value1, Vector3 value2)
		{
			return (double)value1.float_0 == (double)value2.float_0 && (double)value1.float_1 == (double)value2.float_1 && (double)value1.float_2 == (double)value2.float_2;
		}
		public static bool operator !=(Vector3 value1, Vector3 value2)
		{
			return (double)value1.float_0 != (double)value2.float_0 || (double)value1.float_1 != (double)value2.float_1 || (double)value1.float_2 != (double)value2.float_2;
		}
		public static Vector3 operator +(Vector3 value1, Vector3 value2)
		{
			Vector3 result;
			result.float_0 = value1.float_0 + value2.float_0;
			result.float_1 = value1.float_1 + value2.float_1;
			result.float_2 = value1.float_2 + value2.float_2;
			return result;
		}
		public static Vector3 operator -(Vector3 value1, Vector3 value2)
		{
			Vector3 result;
			result.float_0 = value1.float_0 - value2.float_0;
			result.float_1 = value1.float_1 - value2.float_1;
			result.float_2 = value1.float_2 - value2.float_2;
			return result;
		}
		public static Vector3 operator *(Vector3 value1, Vector3 value2)
		{
			Vector3 result;
			result.float_0 = value1.float_0 * value2.float_0;
			result.float_1 = value1.float_1 * value2.float_1;
			result.float_2 = value1.float_2 * value2.float_2;
			return result;
		}
		public static Vector3 operator *(Vector3 value, float scaleFactor)
		{
			Vector3 result;
			result.float_0 = value.float_0 * scaleFactor;
			result.float_1 = value.float_1 * scaleFactor;
			result.float_2 = value.float_2 * scaleFactor;
			return result;
		}
		public static Vector3 operator *(float scaleFactor, Vector3 value)
		{
			Vector3 result;
			result.float_0 = value.float_0 * scaleFactor;
			result.float_1 = value.float_1 * scaleFactor;
			result.float_2 = value.float_2 * scaleFactor;
			return result;
		}
		public static Vector3 operator /(Vector3 value1, Vector3 value2)
		{
			Vector3 result;
			result.float_0 = value1.float_0 / value2.float_0;
			result.float_1 = value1.float_1 / value2.float_1;
			result.float_2 = value1.float_2 / value2.float_2;
			return result;
		}
		public static Vector3 operator /(Vector3 value, float divider)
		{
			float num = 1f / divider;
			Vector3 result;
			result.float_0 = value.float_0 * num;
			result.float_1 = value.float_1 * num;
			result.float_2 = value.float_2 * num;
			return result;
		}
		public override string ToString()
		{
			return string.Format("({0:0.0} {1:0.0} {2:0.0})", this.float_0, this.float_1, this.float_2);
		}
		public bool Equals(Vector3 other)
		{
			return (double)this.float_0 == (double)other.float_0 && (double)this.float_1 == (double)other.float_1 && (double)this.float_2 == (double)other.float_2;
		}
		public override bool Equals(object obj)
		{
			bool result = false;
			if (obj is Vector3)
			{
				result = this.Equals((Vector3)obj);
			}
			return result;
		}
		public override int GetHashCode()
		{
			return this.float_0.GetHashCode() + this.float_1.GetHashCode() + this.float_2.GetHashCode();
		}
		public float Length()
		{
			return (float)Math.Sqrt((double)this.float_0 * (double)this.float_0 + (double)this.float_1 * (double)this.float_1 + (double)this.float_2 * (double)this.float_2);
		}
		public float LengthSquared()
		{
			return (float)((double)this.float_0 * (double)this.float_0 + (double)this.float_1 * (double)this.float_1 + (double)this.float_2 * (double)this.float_2);
		}
		public static float Distance(Vector3 value1, Vector3 value2)
		{
			float num = value1.float_0 - value2.float_0;
			float num2 = value1.float_1 - value2.float_1;
			float num3 = value1.float_2 - value2.float_2;
			return (float)Math.Sqrt((double)num * (double)num + (double)num2 * (double)num2 + (double)num3 * (double)num3);
		}
		public static void Distance(ref Vector3 value1, ref Vector3 value2, out float result)
		{
			float num = value1.float_0 - value2.float_0;
			float num2 = value1.float_1 - value2.float_1;
			float num3 = value1.float_2 - value2.float_2;
			float num4 = (float)((double)num * (double)num + (double)num2 * (double)num2 + (double)num3 * (double)num3);
			result = (float)Math.Sqrt((double)num4);
		}
		public static float DistanceSquared(Vector3 value1, Vector3 value2)
		{
			float num = value1.float_0 - value2.float_0;
			float num2 = value1.float_1 - value2.float_1;
			float num3 = value1.float_2 - value2.float_2;
			return (float)((double)num * (double)num + (double)num2 * (double)num2 + (double)num3 * (double)num3);
		}
		public static void DistanceSquared(ref Vector3 value1, ref Vector3 value2, out float result)
		{
			float num = value1.float_0 - value2.float_0;
			float num2 = value1.float_1 - value2.float_1;
			float num3 = value1.float_2 - value2.float_2;
			result = (float)((double)num * (double)num + (double)num2 * (double)num2 + (double)num3 * (double)num3);
		}
		public static float Dot(Vector3 vector1, Vector3 vector2)
		{
			return (float)((double)vector1.float_0 * (double)vector2.float_0 + (double)vector1.float_1 * (double)vector2.float_1 + (double)vector1.float_2 * (double)vector2.float_2);
		}
		public static void Dot(ref Vector3 vector1, ref Vector3 vector2, out float result)
		{
			result = (float)((double)vector1.float_0 * (double)vector2.float_0 + (double)vector1.float_1 * (double)vector2.float_1 + (double)vector1.float_2 * (double)vector2.float_2);
		}
		public void Normalize()
		{
			if (this.float_0 != this.float_1 || this.float_1 != this.float_2 || this.float_2 != 0f)
			{
				float num = 1f / (float)Math.Sqrt((double)this.float_0 * (double)this.float_0 + (double)this.float_1 * (double)this.float_1 + (double)this.float_2 * (double)this.float_2);
				this.float_0 *= num;
				this.float_1 *= num;
				this.float_2 *= num;
			}
		}
		public static Vector3 Normalize(Vector3 value)
		{
			Vector3 result;
			if (value.float_0 == value.float_1 && value.float_1 == value.float_2 && value.float_2 == 0f)
			{
				result = Vector3.Zero;
			}
			else
			{
				float num = 1f / (float)Math.Sqrt((double)value.float_0 * (double)value.float_0 + (double)value.float_1 * (double)value.float_1 + (double)value.float_2 * (double)value.float_2);
				Vector3 vector;
				vector.float_0 = value.float_0 * num;
				vector.float_1 = value.float_1 * num;
				vector.float_2 = value.float_2 * num;
				result = vector;
			}
			return result;
		}
		public static void Normalize(ref Vector3 value, out Vector3 result)
		{
			if (value.float_0 == value.float_1 && value.float_1 == value.float_2 && value.float_2 == 0f)
			{
				result = Vector3.Zero;
			}
			else
			{
				float num = 1f / (float)Math.Sqrt((double)value.float_0 * (double)value.float_0 + (double)value.float_1 * (double)value.float_1 + (double)value.float_2 * (double)value.float_2);
				result.float_0 = value.float_0 * num;
				result.float_1 = value.float_1 * num;
				result.float_2 = value.float_2 * num;
			}
		}
		internal Vector2 ToVector2()
		{
			return new Vector2(this.float_0, this.float_1);
		}
		public static implicit operator Vector2(Vector3 v)
		{
			return v.ToVector2();
		}
	}
}
