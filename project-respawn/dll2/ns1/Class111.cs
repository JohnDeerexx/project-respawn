using D3Core;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
namespace ns1
{
	internal static class Class111
	{
		[JsonObject(MemberSerialization = MemberSerialization.OptOut)]
		[Serializable]
		internal class Values
		{
			public DateTime RecordingStarted;
			public DateTime LastSaved;
			public float TotalLootedGold;
			public int TotalDeaths;
			public int TotalLootedItems;
			public int TotalExperience;
		}
		[CompilerGenerated]
		private sealed class Class112
		{
			public float float_0;
			public int int_0;
			public int int_1;
			public bool bool_0;
			public void method_0()
			{
				if (Framework.IsIngame)
				{
					this.float_0 = (float)Framework.Hero.GetGold();
					this.int_0 = Framework.Hero.Inventory.Count;
					this.int_1 = Framework.Hero.GetInt((D3Attribute)4294963255u);
					this.bool_0 = true;
				}
			}
		}
		internal static Class111.Values values_0 = null;
		private static int int_0 = 0;
		private static string string_0;
		private static int int_1 = 0;
		private static float float_0 = 0f;
		private static int int_2 = 0;
		private static int int_3 = 0;
		internal static TimeSpan smethod_0()
		{
			return DateTime.Now - Class111.values_0.RecordingStarted + TimeSpan.FromSeconds(1.0);
		}
		internal static void smethod_1()
		{
			if (Class111.values_0 == null)
			{
				Class111.smethod_4();
			}
			else
			{
				if (Environment.TickCount - Class111.int_0 > 3000)
				{
					Class111.int_0 = Environment.TickCount;
					try
					{
						Class111.smethod_3();
					}
					catch (Exception ex)
					{
						GClass0.smethod_0().method_4("STATS: Autosave failed: " + ex.Message);
					}
				}
				Class111.smethod_2();
			}
		}
		private static void smethod_2()
		{
			Class111.Class112 @class = new Class111.Class112();
			if (GClass0.smethod_0().method_10() != null && Class111.int_1 != GClass0.smethod_0().method_10().DeathCounter)
			{
				Class111.int_1 = GClass0.smethod_0().method_10().DeathCounter;
				Class111.values_0.TotalDeaths++;
			}
			@class.float_0 = 0f;
			@class.int_0 = 0;
			@class.int_1 = 0;
			@class.bool_0 = true;
			Framework.RunInD3ContextSynced(new Action(@class.method_0));
			if (@class.bool_0)
			{
				float num = @class.float_0 - Class111.float_0;
				if (num > 0f)
				{
					if (Math.Abs(num) > 5000f)
					{
						num = 0f;
					}
					Class111.values_0.TotalLootedGold += num;
				}
				int num2 = @class.int_0 - Class111.int_2;
				if (num2 < 0)
				{
					num2 = 0;
				}
				if (Class111.int_2 != 0)
				{
					Class111.values_0.TotalLootedItems += num2;
				}
				int value = Class111.int_3 - @class.int_1;
				if (Class111.int_3 != 0)
				{
					int num3 = Math.Abs(value);
					if (num3 > 10000)
					{
						num3 = 0;
					}
					Class111.values_0.TotalExperience += num3;
				}
				Class111.int_2 = @class.int_0;
				Class111.float_0 = @class.float_0;
				Class111.int_3 = @class.int_1;
			}
		}
		private static void smethod_3()
		{
			if (Class111.values_0 != null)
			{
				Class111.values_0.LastSaved = DateTime.Now;
				JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();
				jsonSerializerSettings.TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple;
				string contents = JsonConvert.SerializeObject(Class111.values_0, Formatting.Indented, jsonSerializerSettings);
				File.WriteAllText(Class111.string_0, contents);
			}
		}
		private static void smethod_4()
		{
			Class111.string_0 = Path.Combine(Class71.string_3, Path.GetFileNameWithoutExtension(InjectedWindow.Instance.class71_0.LoadedFromFileName) + ".stats");
			if (File.Exists(Class111.string_0))
			{
				try
				{
					string value = File.ReadAllText(Class111.string_0);
					Class111.values_0 = JsonConvert.DeserializeObject<Class111.Values>(value, new JsonSerializerSettings
					{
						TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
					});
					if (!(DateTime.Now - Class111.values_0.LastSaved > TimeSpan.FromHours(3.0)))
					{
						return;
					}
					Class111.values_0 = null;
				}
				catch (Exception ex)
				{
					GClass0.smethod_0().method_4("STATS: Error loading old file: " + ex.Message);
				}
			}
			if (Class111.values_0 == null)
			{
				Class111.values_0 = new Class111.Values();
				Class111.values_0.LastSaved = DateTime.Now;
				Class111.values_0.RecordingStarted = DateTime.Now;
			}
		}
		internal static void smethod_5()
		{
			try
			{
				File.Delete(Class111.string_0);
			}
			catch
			{
			}
			Class111.values_0 = null;
		}
	}
}
