using D3Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace ns1
{
	[JsonObject(MemberSerialization.OptIn)]
	internal class Class71 : IDisposable
	{
		private const string string_0 = "o34f57heaniow8qq";
		private const string string_1 = "aniow8qqaniow8qqaniow8qqaniow8qq";
		internal const string string_2 = ".settings";
		private FileStream fileStream_0;
		internal static readonly string string_3;
		[CompilerGenerated]
		private bool bool_0;
		[CompilerGenerated]
		private string string_4;
		[CompilerGenerated]
		private int int_0;
		[CompilerGenerated]
		private bool bool_1;
		[CompilerGenerated]
		private Dictionary<D3Attribute, float> dictionary_0;
		[CompilerGenerated]
		private float float_0;
		[CompilerGenerated]
		private float float_1;
		[CompilerGenerated]
		private int int_1;
		[CompilerGenerated]
		private bool bool_2;
		[CompilerGenerated]
		private bool bool_3;
		[CompilerGenerated]
		private bool bool_4;
		[CompilerGenerated]
		private bool bool_5;
		[CompilerGenerated]
		private int int_2;
		[CompilerGenerated]
		private bool bool_6;
		[CompilerGenerated]
		private int int_3;
		[CompilerGenerated]
		private bool bool_7;
		[CompilerGenerated]
		private bool bool_8;
		[CompilerGenerated]
		private int int_4;
		[CompilerGenerated]
		private int int_5;
		[CompilerGenerated]
		private Rectangle rectangle_0;
		[CompilerGenerated]
		private int int_6;
		[CompilerGenerated]
		private bool bool_9;
		[CompilerGenerated]
		private string string_5;
		[JsonProperty]
		public bool ShowAdvancedOptions
		{
			get;
			set;
		}
		[JsonProperty]
		public string StartScriptFileName
		{
			get;
			set;
		}
		[JsonProperty]
		public int StartupAction
		{
			get;
			set;
		}
		[JsonProperty]
		public bool UseCustomItemFactors
		{
			get;
			set;
		}
		[JsonProperty]
		public Dictionary<D3Attribute, float> CustomItemFactors
		{
			get;
			set;
		}
		[JsonProperty]
		public float CustomItemFactors_MinimumValue
		{
			get;
			set;
		}
		[JsonProperty]
		public float CustomItemFactors_MaximumValue
		{
			get;
			set;
		}
		[JsonProperty]
		public int MinimumItemRarity
		{
			get;
			set;
		}
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		public bool ChangeSpells
		{
			get;
			set;
		}
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		public bool ChangeEquip
		{
			get;
			set;
		}
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
		public bool SellInsteadOfSalvage
		{
			get;
			set;
		}
		[JsonProperty]
		public bool AllowToTakeOutStashItems
		{
			get;
			set;
		}
		[JsonProperty, DefaultValue(true)]
		public int MaximumSellOrSalvageValue
		{
			get;
			set;
		}
		[JsonProperty]
		public bool HideWindowWhenGameIsntFocussed
		{
			get;
			set;
		}
		[JsonProperty]
		public int RestartOnXDeaths
		{
			get;
			set;
		}
		[JsonProperty]
		public bool AutoSnapToD3Window
		{
			get;
			set;
		}
		[JsonProperty]
		public bool DisableWatchDog
		{
			get;
			set;
		}
		[JsonProperty]
		public int WatchDogTimeout
		{
			get;
			set;
		}
		[JsonProperty]
		public int MinimumItemQualityToStash
		{
			get;
			set;
		}
		[JsonProperty]
		public Rectangle D3Rectangle
		{
			get;
			set;
		}
		[JsonProperty]
		public int MinimumGoldToLoot
		{
			get;
			set;
		}
		[JsonProperty]
		public bool DontPickupPotions
		{
			get;
			set;
		}
		internal string LoadedFromFileName
		{
			get;
			private set;
		}
		static Class71()
		{
			Class71.string_3 = Path.Combine(Path.GetTempPath(), "HellBuddy\\Profiles\\");
			if (!Directory.Exists(Class71.string_3))
			{
				Directory.CreateDirectory(Class71.string_3);
			}
		}
		[JsonConstructor]
		internal Class71()
		{
			this.CustomItemFactors = new Dictionary<D3Attribute, float>();
			this.HideWindowWhenGameIsntFocussed = true;
		}
		internal static Class71 smethod_0(string string_6)
		{
			string_6 = Path.GetFileNameWithoutExtension(string_6) + ".settings";
			string_6 = Path.Combine(Class71.string_3, string_6);
			if (!File.Exists(string_6) || new FileInfo(string_6).Length == 0L)
			{
				new Class71
				{
					LoadedFromFileName = string_6
				}.method_0();
			}
			FileStream fileStream = null;
			Class71 result;
			try
			{
				fileStream = new FileStream(string_6, FileMode.Open);
				Rijndael rijndael = Rijndael.Create();
				ICryptoTransform transform = rijndael.CreateDecryptor(Encoding.ASCII.GetBytes("aniow8qqaniow8qqaniow8qqaniow8qq"), Encoding.ASCII.GetBytes("o34f57heaniow8qq"));
				using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Read))
				{
					using (Stream stream = new GZipStream(cryptoStream, CompressionMode.Decompress))
					{
						using (StreamReader streamReader = new StreamReader(stream, new UTF8Encoding()))
						{
							string value = streamReader.ReadToEnd();
							Class71 @class = JsonConvert.DeserializeObject<Class71>(value);
							@class.LoadedFromFileName = string_6;
							@class.fileStream_0 = fileStream;
							result = @class;
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Profile: " + ex.Message + "\r\nA new profile will be created and the old one will be overwritten when you click ok. So backup your profile now if you need.", "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Class71 class2 = new Class71();
				class2.LoadedFromFileName = string_6;
				class2.method_0();
				result = class2;
			}
			finally
			{
				fileStream.Close();
			}
			return result;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		internal void method_0()
		{
			string text = Path.Combine(Class71.string_3, Path.GetFileNameWithoutExtension(this.LoadedFromFileName) + ".settings");
			if (text == null)
			{
				MessageBox.Show("Profile cannot be saved because it has an invalid name!", "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				throw new Exception();
			}
			try
			{
				if (this.LoadedFromFileName != null)
				{
					string path = Path.Combine(Class71.string_3, this.LoadedFromFileName);
					if (text != this.LoadedFromFileName && File.Exists(path))
					{
						File.Delete(path);
					}
				}
				this.LoadedFromFileName = text;
				using (FileStream fileStream = new FileStream(Path.Combine(Class71.string_3, text), FileMode.Create))
				{
					Rijndael rijndael = Rijndael.Create();
					ICryptoTransform transform = rijndael.CreateEncryptor(Encoding.ASCII.GetBytes("aniow8qqaniow8qqaniow8qqaniow8qq"), Encoding.ASCII.GetBytes("o34f57heaniow8qq"));
					using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write))
					{
						using (Stream stream = new GZipStream(cryptoStream, CompressionMode.Compress))
						{
							using (StreamWriter streamWriter = new StreamWriter(stream, new UTF8Encoding()))
							{
								string value = JsonConvert.SerializeObject(this, Formatting.None);
								streamWriter.Write(value);
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving Profile: \"" + this.LoadedFromFileName + "\": " + ex.Message, "HellBuddy Bot", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}
		public void Dispose()
		{
			if (this.fileStream_0 != null)
			{
				this.fileStream_0.Close();
				this.fileStream_0.Dispose();
			}
		}
	}
}
