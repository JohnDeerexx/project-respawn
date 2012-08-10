using ns0;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace D3Core.Classes.Navigation
{
	public sealed class Navi
	{
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate IntPtr Delegate13(int id);
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate IntPtr GetNavZoneContainerDelegate(IntPtr thisser, IntPtr navMesh, int i);
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate IntPtr Delegate12(IntPtr manager, ref int index, out IntPtr scene);
		private sealed class Class13
		{
			public Vector3 vector3_0;
			public Vector3 vector3_1;
			public int int_0;
			public List<Vector3> list_0;
		}
		private sealed class Class12
		{
			public Vector3 vector3_0;
			public Vector3 vector3_1;
			public int int_0;
			public bool bool_0;
		}
		[CompilerGenerated]
		private sealed class Class27
		{
			private sealed class Class28
			{
				public Navi.Class27 class27_0;
				public Cell cell_0;
				public bool method_0(Cell cell_1)
				{
					return cell_1.AllowWalk && cell_1 != this.cell_0;
				}
			}
			public Cell cell_0;
			public SortedList<double, Cell> sortedList_0;
			public Action<Cell> action_0;
			public Cell cell_1;
			public void method_0(Cell cell_2)
			{
				Navi.Class27.Class28 @class = new Navi.Class27.Class28();
				@class.class27_0 = this;
				@class.cell_0 = cell_2;
				if (@class.cell_0 == this.cell_1)
				{
					this.cell_0 = @class.cell_0;
				}
				else
				{
					foreach (Cell current in @class.cell_0.AdjacentCells.Where(new Func<Cell, bool>(@class.method_0)))
					{
						double num = @class.cell_0.CurrentDistance + (double)@class.cell_0.DistanceTo(current);
						if (current.CurrentDistance == -1.0 || current.CurrentDistance > num)
						{
							current.CurrentDistance = num;
							current.FromCell = @class.cell_0;
							if (!this.sortedList_0.ContainsKey(current.CurrentDistance))
							{
								this.sortedList_0.Add(current.CurrentDistance, current);
							}
							else
							{
								this.action_0(current);
							}
						}
					}
				}
			}
		}
		[CompilerGenerated]
		private sealed class Class29
		{
			public Vector3 vector3_0;
			public float method_0(Cell cell_0)
			{
				return Vector3.DistanceSquared(this.vector3_0, cell_0.Center);
			}
		}
		[CompilerGenerated]
		private sealed class Class9
		{
			public List<Vector3> list_0;
			public float float_0;
			public void method_0(Vector3 vector3_0)
			{
				if (this.list_0.Count > 0)
				{
					while (Vector3.Distance(this.list_0.Last<Vector3>(), vector3_0) > this.float_0)
					{
						Vector3 vector = vector3_0 - this.list_0.Last<Vector3>();
						vector.Normalize();
						vector *= this.float_0;
						this.list_0.Add(this.list_0.Last<Vector3>() + vector);
					}
				}
				this.list_0.Add(vector3_0);
			}
		}
		[CompilerGenerated]
		private sealed class Class26
		{
			public Vector3 vector3_0;
			public bool method_0(Cell cell_0)
			{
				return cell_0.XMax >= this.vector3_0.float_0 && cell_0.XMin <= this.vector3_0.float_0 && cell_0.YMin <= this.vector3_0.float_1 && cell_0.YMax >= this.vector3_0.float_1;
			}
		}
		[CompilerGenerated]
		private sealed class Class25
		{
			public Vector2 vector2_0;
			public bool method_0(Cell cell_0)
			{
				return cell_0.XMax >= this.vector2_0.float_0 && cell_0.XMin <= this.vector2_0.float_0 && cell_0.YMin <= this.vector2_0.float_1 && cell_0.YMax >= this.vector2_0.float_1;
			}
		}
		[CompilerGenerated]
		private sealed class Class23
		{
			public Navi navi_0;
			public Scene scene_0;
		}
		[CompilerGenerated]
		private sealed class Class24
		{
			public Navi.Class23 class23_0;
			public float float_0;
			public float float_1;
			public float float_2;
			public void method_0(Class15 class15_0)
			{
				Cell cell_ = new Cell(class15_0.method_0() + this.float_0, class15_0.method_1() + this.float_1, class15_0.method_3() + this.float_0, class15_0.method_4() + this.float_1, this.float_2 + class15_0.method_2(), this.float_2 + class15_0.method_5(), class15_0.method_6().HasFlag(Class16.Enum1.flag_0), class15_0.method_6().HasFlag(Class16.Enum1.flag_10), this.class23_0.scene_0);
				this.class23_0.navi_0.method_8(cell_);
			}
		}
		[CompilerGenerated]
		private sealed class Class14
		{
			public Cell cell_0;
			public bool method_0(Cell cell_1)
			{
				return (Math.Abs(cell_1.YMax - this.cell_0.YMin) < 0.1f && cell_1.XMin < this.cell_0.XMax && cell_1.XMax > this.cell_0.XMin) || (Math.Abs(cell_1.YMin - this.cell_0.YMax) < 0.1f && cell_1.XMin < this.cell_0.XMax && cell_1.XMax > this.cell_0.XMin) || (Math.Abs(cell_1.XMax - this.cell_0.XMin) < 0.1f && cell_1.YMin < this.cell_0.YMax && cell_1.YMax > this.cell_0.YMin) || (Math.Abs(cell_1.XMin - this.cell_0.XMax) < 0.1f && cell_1.YMin < this.cell_0.YMax && cell_1.YMax > this.cell_0.YMin);
			}
		}
		private const int int_0 = 500;
		private const int int_1 = 200;
		private const float float_0 = 9f;
		private const int int_2 = 1000;
		private const int int_3 = 500;
		private static Navi.Delegate13 delegate13_0;
		public static Navi.GetNavZoneContainerDelegate GetNavZone;
		private static Navi.Delegate12 delegate12_0;
		private HashSet<int> hashSet_0 = new HashSet<int>();
		public List<Scene> LoadedScenes = new List<Scene>();
		private string string_0;
		private List<Cell> list_0 = new List<Cell>();
		public bool NavCellsUpdated = false;
		private int int_4 = 0;
		private string string_1 = string.Empty;
		private List<Navi.Class13> list_1 = new List<Navi.Class13>();
		public List<Cell> lastRayTraceErrorCells = new List<Cell>();
		public Vector3 lastRayTraceErrorStart = default(Vector3);
		public Vector3 lastRayTraceErrorEnd = default(Vector3);
		private int int_5 = 0;
		private Dictionary<Vector3, Dictionary<Vector3, Navi.Class12>> dictionary_0 = new Dictionary<Vector3, Dictionary<Vector3, Navi.Class12>>();
		private List<Vector3> list_2 = new List<Vector3>();
		[CompilerGenerated]
		private static Action<Cell> action_0;
		[CompilerGenerated]
		private static Func<List<Vector3>, Vector3> func_0;
		[CompilerGenerated]
		private static Func<Cell, bool> func_1;
		[CompilerGenerated]
		private static Func<Cell, bool> func_2;
		public List<Cell> AllCells
		{
			get
			{
				return this.list_0;
			}
		}
		public string World
		{
			get
			{
				string result;
				if (Environment.TickCount - this.int_4 < 500)
				{
					result = this.string_1;
				}
				else
				{
					this.int_4 = Environment.TickCount;
					try
					{
						uint num = Helper.smethod_1(Helper.smethod_1(22522396u) + 1912u);
						ushort num2 = (ushort)Helper.smethod_0(num + 52u);
						if (num2 == 65535)
						{
							result = string.Empty;
						}
						else
						{
							uint num3 = Helper.smethod_1(Helper.smethod_1(Helper.smethod_1(22522396u) + 2348u) + 328u);
							if (num3 == 0u)
							{
								result = string.Empty;
							}
							else
							{
								uint num4 = Helper.smethod_1(num3 + (uint)(72 * num2) + 4u);
								if (num4 == 0u)
								{
									result = string.Empty;
								}
								else
								{
									ContainerStruct containerStruct = default(ContainerStruct);
									Framework.GetSnoName(ref containerStruct, 48, num4, 0);
									uint fuckingAddress = containerStruct.FuckingAddress;
									if (fuckingAddress == 0u)
									{
										result = string.Empty;
									}
									else
									{
										string text = Helper.ReadString(fuckingAddress, null);
										this.string_1 = text;
										result = text;
									}
								}
							}
						}
					}
					catch
					{
						result = string.Empty;
					}
				}
				return result;
			}
		}
		public List<Vector3> OpenEnds
		{
			get
			{
				return this.method_5().ToList<Vector3>();
			}
		}
		public Navi()
		{
			Navi.delegate13_0 = Helper.RegisterDelegate<Navi.Delegate13>(new IntPtr(9053296));
			Navi.GetNavZone = Helper.RegisterDelegate<Navi.GetNavZoneContainerDelegate>(new IntPtr(8995696));
			Navi.delegate12_0 = Helper.RegisterDelegate<Navi.Delegate12>(8473120u);
		}
		public void Pulse()
		{
			try
			{
				this.NavCellsUpdated = false;
				string world = this.string_0;
				try
				{
					world = this.World;
				}
				catch
				{
				}
				if (this.string_0 != world)
				{
					this.hashSet_0.Clear();
					this.LoadedScenes.Clear();
					this.list_0.Clear();
					this.string_0 = world;
				}
				IntPtr intPtr = Marshal.ReadIntPtr(new IntPtr(22522396));
				intPtr = Marshal.ReadIntPtr(intPtr, 2292);
				int num = -1;
				IntPtr zero = IntPtr.Zero;
				HashSet<int> hashSet = new HashSet<int>();
				while (Navi.delegate12_0(intPtr, ref num, out zero) != IntPtr.Zero)
				{
					Scene scene = new Scene(zero + 4);
					hashSet.Add(scene.SceneId);
					if (!this.hashSet_0.Contains(scene.SceneId) && scene.NavMesh.Ptr != IntPtr.Zero)
					{
						this.method_7(scene);
						this.hashSet_0.Add(scene.SceneId);
						this.NavCellsUpdated = true;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("MapData Exception: " + ex.Message);
			}
		}
		private List<Cell> method_0(Cell cell_0, Cell cell_1)
		{
			Navi.Class27 @class = new Navi.Class27();
			@class.cell_1 = cell_1;
			List<Cell> result;
			if (cell_0 == @class.cell_1)
			{
				result = new List<Cell>();
			}
			else
			{
				@class.cell_0 = null;
				List<Cell> arg_50_0 = this.list_0;
				if (Navi.action_0 == null)
				{
					Navi.action_0 = new Action<Cell>(Navi.smethod_0);
				}
				arg_50_0.ForEach(Navi.action_0);
				@class.sortedList_0 = new SortedList<double, Cell>();
				cell_0.CurrentDistance = 0.0;
				@class.sortedList_0.Add(0.0, cell_0);
				KeyValuePair<double, Cell> keyValuePair = default(KeyValuePair<double, Cell>);
				@class.action_0 = null;
				@class.action_0 = new Action<Cell>(@class.method_0);
				while (@class.sortedList_0.Count > 0 && @class.cell_0 == null)
				{
					keyValuePair = @class.sortedList_0.First<KeyValuePair<double, Cell>>();
					@class.action_0(keyValuePair.Value);
					@class.sortedList_0.Remove(keyValuePair.Key);
				}
				List<Cell> list = new List<Cell>();
				if (@class.cell_0 != null)
				{
					list.Add(@class.cell_0);
					while (@class.cell_0.FromCell != null)
					{
						@class.cell_0 = @class.cell_0.FromCell;
						list.Insert(0, @class.cell_0);
					}
				}
				result = list;
			}
			return result;
		}
		public List<Vector3> GetPath(Vector3 from, Vector3 to, float maximumSegmentLength = 10f, float removeNearLimit = 20f)
		{
			return this.GetPath_Internal(from, to, maximumSegmentLength, removeNearLimit);
		}
		public List<Vector3> GetPath_Internal(Vector3 from, Vector3 to, float maximumSegmentLength, float removeNearLimit)
		{
			List<Vector3> list = new List<Vector3>();
			Cell cellByPoint = this.GetCellByPoint(from);
			List<Vector3> result;
			if (cellByPoint == null)
			{
				result = list;
			}
			else
			{
				Cell cell = this.GetCellByPoint(to);
				if (cell == null)
				{
					Navi.Class29 @class = new Navi.Class29();
					@class.vector3_0 = Framework.Hero.Position;
					cell = this.list_0.OrderBy(new Func<Cell, float>(@class.method_0)).FirstOrDefault<Cell>();
					if (cell == null)
					{
						Debug.Write("Strange things happening inside path calculator...");
						result = list;
						return result;
					}
				}
				if (cellByPoint == cell)
				{
					list.Add(from);
					list.Add(to);
					list = this.ChopPath(list, maximumSegmentLength);
					while (list.Count > 0 && (from - list[0]).LengthSquared() < 25f)
					{
						list.RemoveAt(0);
					}
					result = list;
				}
				else
				{
					List<Cell> list2 = this.method_0(cellByPoint, cell);
					if (list2.Count == 0)
					{
						result = list;
					}
					else
					{
						list.Add(from);
						for (int i = 0; i < list2.Count; i++)
						{
							if (i < list2.Count - 1)
							{
								Vector3 item = this.method_1(list2[i], list2[i + 1]);
								list.Add(item);
							}
						}
						list.Add(to);
						list = this.OptimizePath(list);
						list = this.ChopPath(list, maximumSegmentLength);
						while (list.Count > 0 && (from - list[0]).Length() < removeNearLimit)
						{
							list.RemoveAt(0);
						}
						result = list;
					}
				}
			}
			return result;
		}
		private Vector3 method_1(Cell cell_0, Cell cell_1)
		{
			Vector3 result;
			if (Math.Abs(cell_0.XMin - cell_1.XMax) < 0.1f)
			{
				float num = 0.5f * (cell_1.YMin + cell_1.YMax);
				if (num < cell_0.YMin)
				{
					num = cell_0.YMin;
				}
				if (num > cell_0.YMax)
				{
					num = cell_0.YMax;
				}
				result = new Vector3(cell_1.XMax, num, cell_1.Single_2);
			}
			else
			{
				if (Math.Abs(cell_0.XMax - cell_1.XMin) < 0.1f)
				{
					float num = 0.5f * (cell_1.YMin + cell_1.YMax);
					if (num < cell_0.YMin)
					{
						num = cell_0.YMin;
					}
					if (num > cell_0.YMax)
					{
						num = cell_0.YMax;
					}
					result = new Vector3(cell_1.XMin, num, cell_1.Single_2);
				}
				else
				{
					if (Math.Abs(cell_0.YMax - cell_1.YMin) < 0.1f)
					{
						float num2 = 0.5f * (cell_1.XMin + cell_1.XMax);
						if (num2 < cell_0.XMin)
						{
							num2 = cell_0.XMin;
						}
						if (num2 > cell_0.XMax)
						{
							num2 = cell_0.XMax;
						}
						result = new Vector3(num2, cell_1.YMin, cell_1.Single_2);
					}
					else
					{
						if (Math.Abs(cell_0.YMin - cell_1.YMax) < 0.1f)
						{
							float num2 = 0.5f * (cell_1.XMin + cell_1.XMax);
							if (num2 < cell_0.XMin)
							{
								num2 = cell_0.XMin;
							}
							if (num2 > cell_0.XMax)
							{
								num2 = cell_0.XMax;
							}
							result = new Vector3(num2, cell_1.YMax, cell_1.Single_2);
						}
						else
						{
							result = new Vector3(cell_1.Single_0, cell_1.Single_1, cell_1.Single_2);
						}
					}
				}
			}
			return result;
		}
		public List<Vector3> ChopPath(List<Vector3> path, float maximumLength)
		{
			Navi.Class9 @class = new Navi.Class9();
			@class.float_0 = maximumLength;
			List<Vector3> result;
			if (path.Count < 2)
			{
				result = path;
			}
			else
			{
				@class.list_0 = new List<Vector3>();
				Action<Vector3> action = new Action<Vector3>(@class.method_0);
				foreach (Vector3 current in path)
				{
					action(current);
				}
				result = @class.list_0;
			}
			return result;
		}
		public List<Vector3> OptimizePath(List<Vector3> vectors)
		{
			vectors = this.ChopPath(vectors, 8f);
			List<Vector3> result;
			if (vectors.Count <= 2)
			{
				result = vectors;
			}
			else
			{
				int i = 0;
				IL_7B:
				while (i < vectors.Count)
				{
					for (int j = vectors.Count - 1; j >= 0; j--)
					{
						if (this.TraceRay_Walkable_CanPass(vectors[i], vectors[j]))
						{
							int num = j - i - 1;
							for (int k = i; k < num; k++)
							{
								vectors.RemoveAt(i + 1);
							}
							
							i++;
							goto IL_7B;
						}
					}
					
				}
				result = vectors;
			}
			return result;
		}
		private bool method_2(Vector3 vector3_0, Vector3 vector3_1, float float_1)
		{
			Cell cellByPoint = this.GetCellByPoint(vector3_0);
			Cell cellByPoint2 = this.GetCellByPoint(vector3_1);
			bool result;
			if (cellByPoint == cellByPoint2)
			{
				result = true;
			}
			else
			{
				Vector3 value = vector3_1 - vector3_0;
				float num = value.Length();
				value /= float_1;
				int num2 = (int)Math.Round((double)(num / float_1)) - 1;
				Vector3 vect = vector3_0;
				for (int i = 1; i < num2; i++)
				{
					Cell cellByPoint3 = this.GetCellByPoint(vect);
					if (cellByPoint3 == null)
					{
						result = false;
						return result;
					}
					if (!cellByPoint3.AllowWalk)
					{
						result = false;
						return result;
					}
					vect = vector3_0 + (float)i * value;
				}
				result = true;
			}
			return result;
		}
		public bool TraceRay_Walkable_CanPass(Vector3 from, Vector3 to)
		{
			if (this.dictionary_0.Count > 1000)
			{
				this.dictionary_0.Clear();
			}
			Dictionary<Vector3, Navi.Class12> dictionary = new Dictionary<Vector3, Navi.Class12>();
			bool result;
			if (this.dictionary_0.TryGetValue(from, out dictionary))
			{
				Navi.Class12 @class = null;
				if (dictionary.TryGetValue(to, out @class))
				{
					result = @class.bool_0;
					return result;
				}
			}
			bool flag = this.method_3(from, to);
			Navi.Class12 class2 = new Navi.Class12();
			class2.vector3_0 = from;
			class2.vector3_1 = to;
			class2.bool_0 = flag;
			class2.int_0 = Environment.TickCount + 500;
			if (this.dictionary_0.TryGetValue(from, out dictionary))
			{
				dictionary[to] = class2;
			}
			else
			{
				dictionary = new Dictionary<Vector3, Navi.Class12>();
				dictionary[to] = class2;
				this.dictionary_0[from] = dictionary;
			}
			result = flag;
			return result;
		}
		private bool method_3(Vector3 vector3_0, Vector3 vector3_1)
		{
			Cell cellByPoint = this.GetCellByPoint(vector3_0);
			Cell cellByPoint2 = this.GetCellByPoint(vector3_1);
			bool result;
			if (cellByPoint2 == null || cellByPoint == null)
			{
				result = false;
			}
			else
			{
				if (cellByPoint2 == cellByPoint)
				{
					result = true;
				}
				else
				{
					if (!cellByPoint.AllowWalk || !cellByPoint2.AllowWalk)
					{
						result = false;
					}
					else
					{
						LineSegment lineSegment_ = new LineSegment(vector3_0.ToVector2(), vector3_1.ToVector2());
						Cell cell = cellByPoint;
						int num = 0;
						this.lastRayTraceErrorStart = vector3_0;
						this.lastRayTraceErrorEnd = vector3_1;
						List<Cell> list = new List<Cell>();
						list.Add(cellByPoint);
						while (cell != cellByPoint2)
						{
							this.lastRayTraceErrorCells = list;
							if (++num >= 40)
							{
								int count = this.lastRayTraceErrorCells.Count;
								int num2 = this.lastRayTraceErrorCells.Distinct<Cell>().Count<Cell>();
								if (Math.Abs(num2 - count) > 40 || num >= 100)
								{
									if (this.int_5 <= Environment.TickCount)
									{
										Framework.smethod_0(string.Concat(new object[]
										{
											"RayTracer: Aborting... i>100 or more than 10 same elements: c1/c2 = ",
											count,
											"/",
											num2
										}));
										this.int_5 = Environment.TickCount + 500;
									}
									result = false;
									return result;
								}
							}
							cell = cell.method_0(lineSegment_);
							if (cell == null)
							{
								result = false;
								return result;
							}
							if (!cell.AllowWalk)
							{
								result = false;
								return result;
							}
							list.Add(cell);
						}
						result = true;
					}
				}
			}
			return result;
		}
		public bool TraceRay_Projectile_CanPass(Vector3 from, Vector3 to)
		{
			Cell cellByPoint = this.GetCellByPoint(from);
			Cell cellByPoint2 = this.GetCellByPoint(to);
			bool result;
			if (cellByPoint2 == null || cellByPoint == null)
			{
				result = false;
			}
			else
			{
				if (cellByPoint2 == cellByPoint)
				{
					result = true;
				}
				else
				{
					if (!cellByPoint.AllowWalk || !cellByPoint2.AllowWalk)
					{
						result = false;
					}
					else
					{
						LineSegment lineSegment_ = new LineSegment(from.ToVector2(), to.ToVector2());
						Cell cell = cellByPoint;
						int num = 0;
						List<Cell> list = new List<Cell>();
						list.Add(cellByPoint);
						while (cell != cellByPoint2)
						{
							if (++num >= 15)
							{
								result = false;
								return result;
							}
							cell = cell.method_0(lineSegment_);
							if (cell == null)
							{
								result = false;
								return result;
							}
							if (!cell.AllowWalk)
							{
								result = false;
								return result;
							}
							list.Add(cell);
						}
						result = true;
					}
				}
			}
			return result;
		}
		public Cell GetCellByPoint(Vector3 vect)
		{
			Navi.Class26 @class = new Navi.Class26();
			@class.vector3_0 = vect;
			Cell result;
			if (this.list_0 == null)
			{
				result = null;
			}
			else
			{
				result = this.list_0.FirstOrDefault(new Func<Cell, bool>(@class.method_0));
			}
			return result;
		}
		private Cell method_4(Vector2 vector2_0)
		{
			Navi.Class25 @class = new Navi.Class25();
			@class.vector2_0 = vector2_0;
			return this.list_0.FirstOrDefault(new Func<Cell, bool>(@class.method_0));
		}
		private List<Vector3> method_5()
		{
			List<Vector3> list = new List<Vector3>();
			foreach (Cell current in this.list_0)
			{
				if (current.AllowWalk)
				{
					if (current.XMin == current.ParentScene.XMin)
					{
						Scene scene = this.method_6(new Vector3(current.ParentScene.XMin - 5f, current.ParentScene.Center.float_1, 0f));
						if (scene == null)
						{
							list.Add(new Vector3(current.XMin, current.Single_1, 0f));
							continue;
						}
					}
					if (current.XMax == current.ParentScene.XMax)
					{
						Scene scene = this.method_6(new Vector3(current.ParentScene.XMax + 5f, current.ParentScene.Center.float_1, 0f));
						if (scene == null)
						{
							list.Add(new Vector3(current.XMax, current.Single_1, 0f));
							continue;
						}
					}
					if (current.YMax == current.ParentScene.YMax)
					{
						Scene scene = this.method_6(new Vector3(current.ParentScene.Center.float_0, current.ParentScene.YMax + 5f, 0f));
						if (scene == null)
						{
							list.Add(new Vector3(current.Single_0, current.YMax, 0f));
							continue;
						}
					}
					if (current.YMin == current.ParentScene.YMin)
					{
						Scene scene = this.method_6(new Vector3(current.ParentScene.Center.float_0, current.ParentScene.YMin - 5f, 0f));
						if (scene == null)
						{
							list.Add(new Vector3(current.Single_0, current.YMin, 0f));
						}
					}
				}
			}
			List<Vector3> result;
			if (list.Count < 2)
			{
				this.list_2 = list;
				result = list;
			}
			else
			{
				List<List<Vector3>> list2 = new List<List<Vector3>>();
				list2.Add(new List<Vector3>());
				list2[0].Add(list[0]);
				if (Navi.func_0 == null)
				{
					Navi.func_0 = new Func<List<Vector3>, Vector3>(Navi.smethod_1);
				}
				Func<List<Vector3>, Vector3> func = Navi.func_0;
				foreach (Vector3 current2 in list)
				{
					bool flag = false;
					foreach (List<Vector3> current3 in list2)
					{
						if ((func(current3) - current2).Length() < 80f)
						{
							flag = true;
							current3.Add(current2);
						}
					}
					if (!flag)
					{
						list2.Add(new List<Vector3>
						{
							current2
						});
					}
				}
				List<Vector3> list3 = new List<Vector3>();
				foreach (List<Vector3> current4 in list2)
				{
					list3.Add(func(current4));
				}
				this.list_2 = list;
				result = list3;
			}
			return result;
		}
		private Scene method_6(Vector3 vector3_0)
		{
			Scene result;
			foreach (Scene current in this.LoadedScenes)
			{
				if (vector3_0.float_0 >= current.XMin && vector3_0.float_0 <= current.XMax && vector3_0.float_1 >= current.YMin && vector3_0.float_1 <= current.YMax)
				{
					result = current;
					return result;
				}
			}
			result = null;
			return result;
		}
		private void method_7(Scene scene_0)
		{
			Navi.Class23 @class = new Navi.Class23();
			@class.scene_0 = scene_0;
			@class.navi_0 = this;
			try
			{
				Navi.Class24 class2 = new Navi.Class24();
				class2.class23_0 = @class;
				class2.float_0 = @class.scene_0.XMin;
				class2.float_1 = @class.scene_0.YMin;
				class2.float_2 = @class.scene_0.ZMin;
				float arg_6B_0 = @class.scene_0.XMax - @class.scene_0.XMin;
				new List<Scene>(4);
				this.LoadedScenes.Add(@class.scene_0);
				Action<Class15> action = new Action<Class15>(class2.method_0);
				NavMesh navMesh = @class.scene_0.NavMesh;
				NavCellContainer navCellContainer = navMesh.NavZone.NavCellContainer;
				int cellCount = navCellContainer.CellCount;
				Class15 class3 = new Class15(navCellContainer.FirstCell);
				if (cellCount != 0)
				{
					for (int i = 0; i < cellCount; i++)
					{
						action(class3);
						class3 = new Class15(new IntPtr((int)class3.Ptr + 32));
					}
					action(class3);
					IEnumerable<Cell> arg_133_0 = this.list_0;
					if (Navi.func_1 == null)
					{
						Navi.func_1 = new Func<Cell, bool>(Navi.smethod_2);
					}
					Cell[] array = arg_133_0.Where(Navi.func_1).ToArray<Cell>();
					for (int j = 0; j < array.Length; j++)
					{
						Cell cell = array[j];
						IEnumerable<Cell> arg_16F_0 = cell.AdjacentCells;
						if (Navi.func_2 == null)
						{
							Navi.func_2 = new Func<Cell, bool>(Navi.smethod_3);
						}
						if (arg_16F_0.FirstOrDefault(Navi.func_2) == null)
						{
							this.list_0.Remove(cell);
						}
					}
				}
			}
			catch (Exception)
			{
			}
		}
		private void method_8(Cell cell_0)
		{
			foreach (Cell current in this.method_9(cell_0))
			{
				current.AdjacentCells.Add(cell_0);
				cell_0.AdjacentCells.Add(current);
			}
			this.list_0.Add(cell_0);
		}
		private List<Cell> method_9(Cell cell_0)
		{
			Navi.Class14 @class = new Navi.Class14();
			@class.cell_0 = cell_0;
			List<Cell> list = new List<Cell>();
			foreach (Cell current in this.list_0.Where(new Func<Cell, bool>(@class.method_0)))
			{
				list.Add(current);
			}
			return list;
		}
		internal void method_10()
		{
		}
		[CompilerGenerated]
		private static void smethod_0(Cell cell_0)
		{
			cell_0.CurrentDistance = -1.0;
			cell_0.FromCell = null;
		}
		[CompilerGenerated]
		private static Vector3 smethod_1(List<Vector3> list_3)
		{
			Vector3 vector = default(Vector3);
			foreach (Vector3 current in list_3)
			{
				vector += current;
			}
			return vector /= (float)list_3.Count;
		}
		[CompilerGenerated]
		private static bool smethod_2(Cell cell_0)
		{
			return !cell_0.AllowWalk;
		}
		[CompilerGenerated]
		private static bool smethod_3(Cell cell_0)
		{
			return cell_0.AllowWalk;
		}
	}
}
