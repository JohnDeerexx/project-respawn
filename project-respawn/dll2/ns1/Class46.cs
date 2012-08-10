using D3Core;
using D3Core.Classes;
using D3Core.Classes.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
namespace ns1
{
	internal class Class46 : Class44
	{
		private enum FinderState
		{
			SearchForTargetScene,
			MoveToTargetScene,
			SearchForUnit,
			MoveToUnit
		}
		private Class46.FinderState finderState_0;
		private string string_0;
		private string string_1;
		private Scene scene_0;
		private D3Actor d3Actor_0;
		private Vector3? vector3_0;
		private static Random random_0 = new Random(Environment.TickCount);
		private bool bool_0;
		private bool bool_1;
		private Cell cell_0;
		private List<Vector3> list_0;
		private int int_0;
		private List<Vector3> list_1;
		private IEnumerable<Cell> ienumerable_0;
		private Cell cell_1;
		private List<Vector3> list_2;
		private int int_1;
		private List<Vector3> list_3;
		private int int_2;
		private int int_3;
		[CompilerGenerated]
		private static Func<Scene, bool> func_0;
		[CompilerGenerated]
		private static Func<Vector3, float> func_1;
		public Class46(string string_2, string string_3)
		{
			Func<Cell, bool> func = null;
			this.scene_0 = null;
			this.d3Actor_0 = null;
			this.vector3_0 = null;
			this.bool_1 = false;
			this.cell_0 = null;
			this.list_0 = null;
			this.int_0 = 0;
			this.list_1 = null;
			this.ienumerable_0 = null;
			this.cell_1 = null;
			this.list_2 = null;
			this.int_1 = 0;
			this.list_3 = new List<Vector3>();
			this.int_2 = 0;
			this.int_3 = 0;
			//base..ctor();
			this.finderState_0 = Class46.FinderState.SearchForTargetScene;
			if (string.IsNullOrWhiteSpace(string_2))
			{
				IEnumerable<Scene> arg_B3_0 = Framework.Navigator.LoadedScenes;
				if (Class46.func_0 == null)
				{
					Class46.func_0 = new Func<Scene, bool>(Class46.smethod_1);
				}
				Scene scene = arg_B3_0.First(Class46.func_0);
				IEnumerable<Cell> arg_D5_0 = Framework.Navigator.AllCells;
				if (func == null)
				{
					func = new Func<Cell, bool>(this.method_3);
				}
				this.ienumerable_0 = arg_D5_0.Where(func);
				this.scene_0 = scene;
				this.string_0 = scene.SNOName;
				this.finderState_0 = Class46.FinderState.SearchForUnit;
			}
			else
			{
				this.string_0 = string_2;
			}
			if (string.IsNullOrWhiteSpace(string_3))
			{
				this.bool_0 = true;
				this.string_1 = "";
			}
			else
			{
				this.bool_0 = false;
				this.string_1 = string_3;
			}
		}
		internal override int vmethod_2()
		{
			return 99999;
		}
		internal override string vmethod_3()
		{
			return "State: " + this.finderState_0.ToString() + ", P({0}, {1})".smethod_1(this.string_0, this.string_1);
		}
		internal override bool vmethod_0()
		{
			bool result;
			if (this.bool_0)
			{
				if (Framework.Scene.Contains(this.string_0))
				{
					Movement.HoldPosition();
					result = false;
				}
				else
				{
					result = true;
				}
			}
			else
			{
				if (this.d3Actor_0 == null)
				{
					result = true;
				}
				else
				{
					if (this.list_0 == null)
					{
						result = true;
					}
					else
					{
						if (this.list_0.Count > 0)
						{
							result = true;
						}
						else
						{
							if (this.bool_1)
							{
								this.bool_1 = false;
								Movement.HoldPosition();
							}
							result = false;
						}
					}
				}
			}
			return result;
		}
		internal override void vmethod_1()
		{
			Func<D3Actor, bool> func = null;
			Func<Cell, float> func2 = null;
			this.bool_1 = true;
			if (this.int_0 > 0)
			{
				this.int_0--;
			}
			else
			{
				this.int_0 = 5;
				switch (this.finderState_0)
				{
				case Class46.FinderState.SearchForTargetScene:
					this.method_1();
					break;
				case Class46.FinderState.MoveToTargetScene:
					if (Framework.Scene.Contains(this.string_0))
					{
						if (this.bool_0)
						{
							GClass0.smethod_0().method_5("Maze: Complete");
						}
						else
						{
							this.finderState_0 = Class46.FinderState.SearchForUnit;
							GClass0.smethod_0().method_5("Maze: found target scene, now looking for: " + this.string_1);
						}
					}
					else
					{
						if (this.list_1 == null || this.int_2 != Class45.LastRan || this.int_3 != Class48.LastRan)
						{
							this.int_2 = Class45.LastRan;
							this.int_3 = Class48.LastRan;
							this.list_1 = Framework.Navigator.GetPath(Framework.Hero.Position, this.cell_1.Center, 10f, 20f);
						}
						while (this.list_1.Count > 0 && Framework.Hero.DistanceTo(this.list_1[0]) < 20f)
						{
							this.list_1.RemoveAt(0);
						}
						if (this.list_1.Count > 0)
						{
							Movement.MoveTo(this.list_1[0]);
						}
						else
						{
							this.finderState_0 = Class46.FinderState.SearchForTargetScene;
						}
					}
					break;
				case Class46.FinderState.SearchForUnit:
				{
					IEnumerable<D3Actor> arg_1BA_0 = Framework.Actors;
					if (func == null)
					{
						func = new Func<D3Actor, bool>(this.method_4);
					}
					this.d3Actor_0 = arg_1BA_0.FirstOrDefault(func);
					if (this.d3Actor_0 != null)
					{
						this.finderState_0 = Class46.FinderState.MoveToUnit;
						GClass0.smethod_0().method_5("Maze: Target found: " + this.string_1);
					}
					else
					{
						if (this.cell_0 != null && Framework.Hero.DistanceTo(this.cell_0.Center) < 30f)
						{
							this.cell_0 = null;
						}
						if (this.cell_0 == null)
						{
							this.cell_0 = this.ienumerable_0.ElementAtOrDefault(Class46.random_0.Next(this.ienumerable_0.Count<Cell>()));
						}
						if (this.cell_0 != null)
						{
							Movement.MoveTo(this.cell_0.Center);
						}
					}
					break;
				}
				case Class46.FinderState.MoveToUnit:
					if (this.cell_0 == null)
					{
						IEnumerable<Cell> arg_2A5_0 = this.ienumerable_0;
						if (func2 == null)
						{
							func2 = new Func<Cell, float>(this.method_5);
						}
						this.cell_0 = arg_2A5_0.OrderBy(func2).FirstOrDefault<Cell>();
					}
					if (this.cell_0 != null)
					{
						this.list_0 = Framework.Navigator.GetPath(Framework.Hero.Position, this.cell_0.Center, 10f, 20f);
						while (this.list_0.Count > 0 && Framework.Hero.DistanceTo(this.list_0[0]) < 20f)
						{
							this.list_0.RemoveAt(0);
						}
						if (this.list_0.Count > 0)
						{
							Movement.MoveTo(this.list_0[0]);
						}
					}
					break;
				default:
					throw new InvalidOperationException("Maze internal state corrupted");
				}
			}
		}
		private void method_1()
		{
			Func<Scene, bool> func = null;
			Func<Cell, bool> func2 = null;
			Func<Cell, float> func3 = null;
			Func<Vector3, float> func4 = null;
			if (Framework.Navigator.LoadedScenes.Count != this.int_1 || Class45.LastRan != this.int_2 || Class48.LastRan != this.int_3)
			{
				this.int_3 = Class48.LastRan;
				this.int_2 = Class45.LastRan;
				this.int_1 = Framework.Navigator.LoadedScenes.Count;
				this.list_3.Clear();
			}
			if (this.scene_0 == null)
			{
				IEnumerable<Scene> arg_9E_0 = Framework.Navigator.LoadedScenes;
				if (func == null)
				{
					func = new Func<Scene, bool>(this.method_6);
				}
				this.scene_0 = arg_9E_0.FirstOrDefault(func);
			}
			else
			{
				if (this.ienumerable_0 == null)
				{
					IEnumerable<Cell> arg_D7_0 = Framework.Navigator.AllCells;
					if (func2 == null)
					{
						func2 = new Func<Cell, bool>(this.method_7);
					}
					this.ienumerable_0 = arg_D7_0.Where(func2);
				}
				if (this.cell_1 == null)
				{
					IEnumerable<Cell> arg_107_0 = this.ienumerable_0;
					if (func3 == null)
					{
						func3 = new Func<Cell, float>(this.method_8);
					}
					this.cell_1 = arg_107_0.OrderBy(func3).First<Cell>();
				}
				this.list_2 = Framework.Navigator.GetPath(Framework.Hero.Position, this.cell_1.Center, 10f, 20f);
				if (this.list_2.Count > 0)
				{
					this.finderState_0 = Class46.FinderState.MoveToTargetScene;
					this.vector3_0 = new Vector3?(this.list_2.Last<Vector3>());
					return;
				}
			}
			List<Vector3> openEnds = Framework.Navigator.OpenEnds;
			if (this.scene_0 == null && openEnds.Count == 0)
			{
				GClass0.smethod_0().method_4("Explorer: Target was not found!");
			}
			else
			{
				if (this.list_3 != null && this.list_3.Count > 0)
				{
					while (this.list_3.Count > 0 && Framework.Hero.DistanceTo(this.list_3[0]) < 20f)
					{
						this.list_3.RemoveAt(0);
					}
					if (this.list_3.Count > 0)
					{
						Movement.MoveTo(this.list_3[0]);
					}
				}
				else
				{
					if (this.scene_0 != null)
					{
						IEnumerable<Vector3> arg_261_0 = openEnds;
						if (func4 == null)
						{
							func4 = new Func<Vector3, float>(this.method_9);
						}
						IOrderedEnumerable<Vector3> orderedEnumerable = arg_261_0.OrderBy(func4);
						foreach (Vector3 current in orderedEnumerable)
						{
							List<Vector3> path = Framework.Navigator.GetPath(Framework.Hero.Position, current, 10f, 20f);
							if (path.Count > 0)
							{
								this.list_3 = path;
								return;
							}
						}
						GClass0.smethod_0().method_4("Explorer: Cannot progress....");
					}
					else
					{
						IOrderedEnumerable<Vector3> orderedEnumerable2;
						if (this.vector3_0.HasValue)
						{
							orderedEnumerable2 = openEnds.OrderBy(new Func<Vector3, float>(this.method_10));
						}
						else
						{
							IEnumerable<Vector3> arg_332_0 = openEnds;
							if (Class46.func_1 == null)
							{
								Class46.func_1 = new Func<Vector3, float>(Class46.smethod_2);
							}
							orderedEnumerable2 = arg_332_0.OrderBy(Class46.func_1);
						}
						foreach (Vector3 current in orderedEnumerable2)
						{
							this.list_3 = Framework.Navigator.GetPath(Framework.Hero.Position, current, 10f, 20f);
							while (this.list_3.Count > 0 && Framework.Hero.DistanceTo(this.list_3[0]) < 20f)
							{
								this.list_3.RemoveAt(0);
							}
							if (this.list_3.Count > 0)
							{
								Movement.MoveTo(this.list_3[0]);
								return;
							}
						}
						GClass0.smethod_0().method_5("Cannot find a path to explore");
					}
				}
			}
		}
		public void method_2()
		{
			this.int_2 = -1;
			this.finderState_0 = Class46.FinderState.SearchForTargetScene;
			this.cell_0 = null;
			this.list_0 = null;
			this.list_1 = null;
			this.d3Actor_0 = null;
			this.scene_0 = null;
			this.ienumerable_0 = null;
			this.cell_1 = null;
		}
		[CompilerGenerated]
		private static bool smethod_1(Scene scene_1)
		{
			return scene_1.SceneId == Framework.Hero.CurrentSceneId;
		}
		[CompilerGenerated]
		private bool method_3(Cell cell_2)
		{
			return cell_2.AllowWalk && cell_2.ParentScene == this.scene_0;
		}
		[CompilerGenerated]
		private bool method_4(D3Actor d3Actor_1)
		{
			return d3Actor_1.Modelname.Contains(this.string_1);
		}
		[CompilerGenerated]
		private float method_5(Cell cell_2)
		{
			return (cell_2.Center - this.d3Actor_0.Position).LengthSquared();
		}
		[CompilerGenerated]
		private bool method_6(Scene scene_1)
		{
			return scene_1.SNOName.Contains(this.string_0);
		}
		[CompilerGenerated]
		private bool method_7(Cell cell_2)
		{
			return cell_2.AllowWalk && cell_2.ParentScene == this.scene_0;
		}
		[CompilerGenerated]
		private float method_8(Cell cell_2)
		{
			return (this.scene_0.Center - cell_2.Center).LengthSquared();
		}
		[CompilerGenerated]
		private float method_9(Vector3 vector3_1)
		{
			return (this.scene_0.Center - vector3_1).LengthSquared();
		}
		[CompilerGenerated]
		private float method_10(Vector3 vector3_1)
		{
			return Vector3.DistanceSquared(vector3_1, this.vector3_0.Value);
		}
		[CompilerGenerated]
		private static float smethod_2(Vector3 vector3_1)
		{
			return Framework.Hero.DistanceTo(vector3_1);
		}
	}
}
