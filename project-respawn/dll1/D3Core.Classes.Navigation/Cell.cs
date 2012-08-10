using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace D3Core.Classes.Navigation
{
	public sealed class Cell
	{
		private enum Enum0
		{
			const_0,
			const_1,
			const_2,
			const_3,
			const_4
		}
		[CompilerGenerated]
		private sealed class Class11
		{
			public Vector2 vector2_0;
			public Cell cell_0;
			public bool method_0(Cell cell_1)
			{
				return cell_1.YMin == this.cell_0.YMax && cell_1.XMin <= this.vector2_0.float_0 && cell_1.XMax >= this.vector2_0.float_0;
			}
			public bool method_1(Cell cell_1)
			{
				return cell_1.YMax == this.cell_0.YMin && cell_1.XMin <= this.vector2_0.float_0 && cell_1.XMax >= this.vector2_0.float_0;
			}
			public bool method_2(Cell cell_1)
			{
				return cell_1.XMax == this.cell_0.XMin && cell_1.YMin <= this.vector2_0.float_1 && cell_1.YMax >= this.vector2_0.float_1;
			}
			public bool method_3(Cell cell_1)
			{
				return cell_1.XMin == this.cell_0.XMax && cell_1.YMin <= this.vector2_0.float_1 && cell_1.YMax >= this.vector2_0.float_1;
			}
		}
		[CompilerGenerated]
		private sealed class Class10
		{
			public Vector2 vector2_0;
			public bool method_0(Cell cell_0)
			{
				return this.vector2_0.float_0 < cell_0.XMax && cell_0.XMin < this.vector2_0.float_0 && this.vector2_0.float_1 < cell_0.YMax && cell_0.YMin < this.vector2_0.float_1;
			}
		}
		private static uint uint_0 = 0u;
		public uint id;
		public double CurrentDistance;
		public Cell FromCell;
		private LineSegment lineSegment_0;
		private LineSegment lineSegment_1;
		private LineSegment lineSegment_2;
		private LineSegment lineSegment_3;
		[CompilerGenerated]
		private Scene scene_0;
		[CompilerGenerated]
		private List<Cell> list_0;
		[CompilerGenerated]
		private float float_0;
		[CompilerGenerated]
		private float float_1;
		[CompilerGenerated]
		private float float_2;
		[CompilerGenerated]
		private float float_3;
		[CompilerGenerated]
		private float float_4;
		[CompilerGenerated]
		private float float_5;
		[CompilerGenerated]
		private float float_6;
		[CompilerGenerated]
		private float float_7;
		[CompilerGenerated]
		private float float_8;
		[CompilerGenerated]
		private bool bool_0;
		[CompilerGenerated]
		private bool bool_1;
		public Scene ParentScene
		{
			get;
			private set;
		}
		public LineSegment TopBorder
		{
			get
			{
				if (this.lineSegment_0 == null)
				{
					this.lineSegment_0 = new LineSegment(new Vector2(this.XMin, this.YMax), new Vector2(this.XMax, this.YMax));
				}
				return this.lineSegment_0;
			}
		}
		public LineSegment BottomBorder
		{
			get
			{
				if (this.lineSegment_1 == null)
				{
					this.lineSegment_1 = new LineSegment(new Vector2(this.XMin, this.YMin), new Vector2(this.XMax, this.YMin));
				}
				return this.lineSegment_1;
			}
		}
		public LineSegment LeftBorder
		{
			get
			{
				if (this.lineSegment_2 == null)
				{
					this.lineSegment_2 = new LineSegment(new Vector2(this.XMin, this.YMin), new Vector2(this.XMin, this.YMax));
				}
				return this.lineSegment_2;
			}
		}
		public LineSegment RightBorder
		{
			get
			{
				if (this.lineSegment_3 == null)
				{
					this.lineSegment_3 = new LineSegment(new Vector2(this.XMax, this.YMin), new Vector2(this.XMax, this.YMax));
				}
				return this.lineSegment_3;
			}
		}
		public List<Cell> AdjacentCells
		{
			get;
			private set;
		}
		public float Single_0
		{
			get;
			private set;
		}
		public float Single_1
		{
			get;
			private set;
		}
		public float Single_2
		{
			get;
			private set;
		}
		public float XMin
		{
			get;
			private set;
		}
		public float YMin
		{
			get;
			private set;
		}
		public float XMax
		{
			get;
			private set;
		}
		public float YMax
		{
			get;
			private set;
		}
		public float ZMin
		{
			get;
			private set;
		}
		public float ZMax
		{
			get;
			private set;
		}
		public bool AllowWalk
		{
			get;
			set;
		}
		public bool AllowProjectile
		{
			get;
			set;
		}
		public Vector3 Center
		{
			get
			{
				return new Vector3(this.Single_0, this.Single_1, this.Single_2);
			}
		}
		public Cell(float xmin, float yMin, float xMax, float yMax, float zMin, float zMax, bool allowWalk, bool allowProjectile, Scene parentScene)
		{
			this.ParentScene = parentScene;
			this.id = Cell.uint_0++;
			this.XMin = xmin;
			this.YMin = yMin;
			this.XMax = xMax;
			this.YMax = yMax;
			this.ZMax = zMax;
			this.ZMin = zMin;
			this.Single_0 = (this.XMin + this.XMax) / 2f;
			this.Single_1 = (this.YMin + this.YMax) / 2f;
			this.Single_2 = (this.ZMin + this.ZMax) / 2f;
			this.AllowWalk = allowWalk;
			this.AllowProjectile = allowProjectile;
			this.AdjacentCells = new List<Cell>();
		}
		public override string ToString()
		{
			return this.id.ToString("x");
		}
		public float DistanceTo(Cell cell)
		{
			float num = cell.Single_0 - this.Single_0;
			float num2 = cell.Single_1 - this.Single_1;
			return (float)Math.Sqrt(Math.Pow((double)num, 2.0) + Math.Pow((double)num2, 2.0));
		}
		internal Cell method_0(LineSegment lineSegment_4)
		{
			Func<Cell, bool> func = null;
			Func<Cell, bool> func2 = null;
			Func<Cell, bool> func3 = null;
			Func<Cell, bool> func4 = null;
			Cell.Class11 @class = new Cell.Class11();
			@class.cell_0 = this;
			double num = 0.0;
			Cell.Enum0 @enum = Cell.Enum0.const_4;
			@class.vector2_0 = Vector2.Zero;
			Vector2 zero = Vector2.Zero;
			if (LineSegment.Intersection(this.TopBorder, lineSegment_4, out zero))
			{
				num = (double)(zero - lineSegment_4.P1).Length();
				@class.vector2_0 = zero;
				@enum = Cell.Enum0.const_0;
			}
			if (LineSegment.Intersection(this.BottomBorder, lineSegment_4, out zero))
			{
				double num2 = (double)(zero - lineSegment_4.P1).Length();
				if (num2 > num)
				{
					@class.vector2_0 = zero;
					num = num2;
					@enum = Cell.Enum0.const_1;
				}
			}
			if (LineSegment.Intersection(this.LeftBorder, lineSegment_4, out zero))
			{
				double num2 = (double)(zero - lineSegment_4.P1).Length();
				if (num2 > num)
				{
					@class.vector2_0 = zero;
					num = num2;
					@enum = Cell.Enum0.const_2;
				}
			}
			if (LineSegment.Intersection(this.RightBorder, lineSegment_4, out zero))
			{
				double num2 = (double)(zero - lineSegment_4.P1).Length();
				if (num2 > num)
				{
					@class.vector2_0 = zero;
					@enum = Cell.Enum0.const_3;
				}
			}
			Cell result;
			switch (@enum)
			{
			case Cell.Enum0.const_0:
			{
				IEnumerable<Cell> arg_187_0 = this.AdjacentCells;
				if (func == null)
				{
					func = new Func<Cell, bool>(@class.method_0);
				}
				result = arg_187_0.FirstOrDefault(func);
				break;
			}
			case Cell.Enum0.const_1:
			{
				IEnumerable<Cell> arg_1A8_0 = this.AdjacentCells;
				if (func2 == null)
				{
					func2 = new Func<Cell, bool>(@class.method_1);
				}
				result = arg_1A8_0.FirstOrDefault(func2);
				break;
			}
			case Cell.Enum0.const_2:
			{
				IEnumerable<Cell> arg_1C9_0 = this.AdjacentCells;
				if (func3 == null)
				{
					func3 = new Func<Cell, bool>(@class.method_2);
				}
				result = arg_1C9_0.FirstOrDefault(func3);
				break;
			}
			case Cell.Enum0.const_3:
			{
				IEnumerable<Cell> arg_1EA_0 = this.AdjacentCells;
				if (func4 == null)
				{
					func4 = new Func<Cell, bool>(@class.method_3);
				}
				result = arg_1EA_0.FirstOrDefault(func4);
				break;
			}
			case Cell.Enum0.const_4:
				result = null;
				break;
			default:
				throw new NotImplementedException("The current cell does not contain a next cell for that line. Cell.GetNextCell()");
			}
			return result;
		}
		internal Cell method_1(LineSegment lineSegment_4)
		{
			Cell.Class10 @class = new Cell.Class10();
			Vector2? vector = null;
			Vector2? vector2 = null;
			Vector2? vector3 = null;
			Vector2? vector4 = null;
			float num = lineSegment_4.P2.float_0 - lineSegment_4.P1.float_0;
			float num2 = lineSegment_4.P2.float_1 - lineSegment_4.P1.float_1;
			float arg_6A_0 = (float)Math.Sqrt((double)(num * num + num2 * num2));
			float num3 = num2 / num;
			float num4 = lineSegment_4.P1.float_1 - num3 * lineSegment_4.P1.float_0;
			float num5 = this.TopBorder.P1.float_1;
			float num6 = (num5 - num4) / num3;
			if (num6 < this.TopBorder.P2.float_0 && num6 > this.TopBorder.P1.float_0)
			{
				vector = new Vector2?(new Vector2(num6, num5));
			}
			num5 = this.BottomBorder.P1.float_1;
			num6 = (num5 - num4) / num3;
			if (num6 < this.BottomBorder.P2.float_0 && num6 > this.BottomBorder.P1.float_0)
			{
				vector4 = new Vector2?(new Vector2(num6, num5));
			}
			num6 = this.LeftBorder.P1.float_0;
			num5 = num3 * num6 + num4;
			if (num5 < this.TopBorder.P1.float_1 && num5 > this.BottomBorder.P1.float_1)
			{
				vector2 = new Vector2?(new Vector2(num6, num5));
			}
			num6 = this.RightBorder.P1.float_0;
			num5 = num3 * num6 + num4;
			if (num5 < this.TopBorder.P1.float_1 && num5 > this.BottomBorder.P1.float_1)
			{
				vector3 = new Vector2?(new Vector2(num6, num5));
			}
			@class.vector2_0 = Vector2.Zero;
			float num7 = 0f;
			if (vector.HasValue)
			{
				float num8 = (lineSegment_4.P1 - vector.Value).Length();
				if (num8 > num7)
				{
					@class.vector2_0 = vector.Value;
					num7 = num8;
				}
			}
			if (vector2.HasValue)
			{
				float num8 = (lineSegment_4.P1 - vector2.Value).Length();
				if (num8 > num7)
				{
					@class.vector2_0 = vector2.Value;
					num7 = num8;
				}
			}
			if (vector4.HasValue)
			{
				float num8 = (lineSegment_4.P1 - vector4.Value).Length();
				if (num8 > num7)
				{
					@class.vector2_0 = vector4.Value;
					num7 = num8;
				}
			}
			if (vector3.HasValue)
			{
				float num8 = (lineSegment_4.P1 - vector3.Value).Length();
				if (num8 > num7)
				{
					@class.vector2_0 = vector3.Value;
				}
			}
			Cell result;
			if (@class.vector2_0 == Vector2.Zero)
			{
				result = null;
			}
			else
			{
				result = this.AdjacentCells.FirstOrDefault(new Func<Cell, bool>(@class.method_0));
			}
			return result;
		}
		internal LineSegment method_2(LineSegment lineSegment_4)
		{
			double num = 0.0;
			Cell.Enum0 @enum = Cell.Enum0.const_3;
			Vector2 zero = Vector2.Zero;
			if (LineSegment.Intersection(this.TopBorder, lineSegment_4, out zero))
			{
				num = (double)(zero - lineSegment_4.P1).Length();
				@enum = Cell.Enum0.const_0;
			}
			if (LineSegment.Intersection(this.BottomBorder, lineSegment_4, out zero))
			{
				double num2 = (double)(zero - lineSegment_4.P1).Length();
				if (num2 < num)
				{
					num = num2;
					@enum = Cell.Enum0.const_1;
				}
			}
			if (LineSegment.Intersection(this.LeftBorder, lineSegment_4, out zero))
			{
				double num2 = (double)(zero - lineSegment_4.P1).Length();
				if (num2 < num)
				{
					num = num2;
					@enum = Cell.Enum0.const_2;
				}
			}
			if (LineSegment.Intersection(this.RightBorder, lineSegment_4, out zero))
			{
				double num2 = (double)(zero - lineSegment_4.P1).Length();
				if (num2 < num)
				{
					@enum = Cell.Enum0.const_3;
				}
			}
			LineSegment result;
			switch (@enum)
			{
			case Cell.Enum0.const_0:
				result = new LineSegment(new Vector2(this.XMin, this.YMin), new Vector2(this.XMax, this.YMin));
				break;
			case Cell.Enum0.const_1:
				result = new LineSegment(new Vector2(this.XMin, this.YMax), new Vector2(this.XMax, this.YMax));
				break;
			case Cell.Enum0.const_2:
				result = new LineSegment(new Vector2(this.XMin, this.YMin), new Vector2(this.XMin, this.YMax));
				break;
			case Cell.Enum0.const_3:
				result = new LineSegment(new Vector2(this.XMax, this.YMin), new Vector2(this.XMax, this.YMax));
				break;
			default:
				throw new NotImplementedException("The current cell does not contain a next cell for that line. Cell.GetNextCell()");
			}
			return result;
		}
		internal LineSegment method_3(LineSegment lineSegment_4)
		{
			double num = 0.0;
			Cell.Enum0 @enum = Cell.Enum0.const_3;
			Vector2 zero = Vector2.Zero;
			if (LineSegment.Intersection(this.TopBorder, lineSegment_4, out zero))
			{
				num = (double)(zero - lineSegment_4.P1).Length();
				@enum = Cell.Enum0.const_0;
			}
			if (LineSegment.Intersection(this.BottomBorder, lineSegment_4, out zero))
			{
				double num2 = (double)(zero - lineSegment_4.P1).Length();
				if (num2 > num)
				{
					num = num2;
					@enum = Cell.Enum0.const_1;
				}
			}
			if (LineSegment.Intersection(this.LeftBorder, lineSegment_4, out zero))
			{
				double num2 = (double)(zero - lineSegment_4.P1).Length();
				if (num2 > num)
				{
					num = num2;
					@enum = Cell.Enum0.const_2;
				}
			}
			if (LineSegment.Intersection(this.RightBorder, lineSegment_4, out zero))
			{
				double num2 = (double)(zero - lineSegment_4.P1).Length();
				if (num2 > num)
				{
					@enum = Cell.Enum0.const_3;
				}
			}
			LineSegment result;
			switch (@enum)
			{
			case Cell.Enum0.const_0:
				result = new LineSegment(new Vector2(this.XMin, this.YMin), new Vector2(this.XMax, this.YMin));
				break;
			case Cell.Enum0.const_1:
				result = new LineSegment(new Vector2(this.XMin, this.YMax), new Vector2(this.XMax, this.YMax));
				break;
			case Cell.Enum0.const_2:
				result = new LineSegment(new Vector2(this.XMin, this.YMin), new Vector2(this.XMin, this.YMax));
				break;
			case Cell.Enum0.const_3:
				result = new LineSegment(new Vector2(this.XMax, this.YMin), new Vector2(this.XMax, this.YMax));
				break;
			default:
				throw new NotImplementedException("The current cell does not contain a next cell for that line. Cell.GetNextCell()");
			}
			return result;
		}
		internal Vector2 method_4(Vector2 vector2_0)
		{
			double num = (double)Vector2.Distance(new Vector2(this.XMin, this.YMin), vector2_0);
			Vector2 result = new Vector2(this.XMin, this.YMin);
			if ((double)Vector2.Distance(new Vector2(this.XMax, this.YMin), vector2_0) < num)
			{
				result = new Vector2(this.XMax, this.YMin);
			}
			if ((double)Vector2.DistanceSquared(new Vector2(this.XMin, this.YMax), vector2_0) < num)
			{
				result = new Vector2(this.XMin, this.YMax);
			}
			if ((double)Vector2.DistanceSquared(new Vector2(this.XMax, this.YMax), vector2_0) < num)
			{
				result = new Vector2(this.XMax, this.YMax);
			}
			return result;
		}
	}
}
