using Launcher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;


namespace ns0
{
	public sealed class LoginWindow : Form
	{
		private sealed class Class0
		{
			public string someFileName;
			public string checksum;
			public int capacity;
			public MemoryStream stream;
		}
		[CompilerGenerated]
		private sealed class Class19
		{
			public string string_0;
			public string string_1;
			public LoginWindow loginWindow_0;
			public void method_0()
			{
				this.loginWindow_0.statusLabel.Text = "Out of date:\n" + this.string_0;
			}
			public void method_1()
			{
				this.loginWindow_0.Hide();
				NewVersion newVersion = new NewVersion(this.string_1);
				newVersion.ShowDialog();
			}
		}
		[CompilerGenerated]
		private sealed class Class12
		{
			public Exception exception_0;
			public LoginWindow loginWindow_0;
			public void method_0()
			{
				this.loginWindow_0.statusLabel.Text = "Error: " + this.exception_0.Message;
			}
		}
		[CompilerGenerated]
		private sealed class Class13
		{
			private sealed class Class14
			{
				public LoginWindow.Class13 class13_0;
				public double double_0;
				public void method_0()
				{
					this.class13_0.loginWindow_0.statusLabel.Text = "{0}{1:0.0}%".smethod_1(this.class13_0.string_0, this.double_0);
				}
			}
			public LoginWindow.Class0 class0_0;
			public string string_0;
			public LoginWindow loginWindow_0;
			public void method_0(int int_0, int int_1, byte[] byte_0, int int_2)
			{
				LoginWindow.Class13.Class14 @class = new LoginWindow.Class13.Class14();
				@class.class13_0 = this;
				this.class0_0.stream.Write(byte_0, 0, int_2);
				@class.double_0 = (double)int_0 / (double)int_1;
				@class.double_0 *= 100.0;
				this.loginWindow_0.statusLabel.Invoke(new Action(@class.method_0));
			}
			public void method_1()
			{
				this.loginWindow_0.statusLabel.Text = this.string_0 + "Verifying file integrity...";
			}
		}
		[CompilerGenerated]
		private sealed class Class11
		{
			public LoginWindow loginWindow_0;
			public bool bool_0;
			public void method_0()
			{
				this.loginWindow_0.submitBtn.Enabled = !this.bool_0;
				this.loginWindow_0.LicenceKeyBox.Enabled = !this.bool_0;
			}
		}
		private const string string_0 = "NETLoader.dll";
		internal const string string_1 = "1";//"193.192.58.73";
		private const string string_2 = "7889083D.dll";
		private const string string_3 = "HellBuddy.ContainerA";
		private const string string_4 = "EntryPoint";
		internal const string string_5 = "v1.1.0";
		private const int int_0 = 2795;
		private IContainer icontainer_0;
		private TextBox LicenceKeyBox;
		private Button submitBtn;
		private Label label1;
        private GroupBox groupBox1;
		private Label LabelVersion;
		private Button BtnExtendLicenceBox;
		private Thread thread_0;
		private TcpClient tcpClient_0;
		private string sessionID;
		private int int_1;
		private int portNumber;
		private string workingDirectoryPath = "";
		private string stringThatIsObtainedFromServer = "";
		private int int_3;
		internal static string[] string_9;
		internal static string hbFolderPath = Path.Combine(Path.GetTempPath(), "HellBuddy\\");
		private List<LoginWindow.Class0> list_0;
        private Label statusLabel;
        private PictureBox pictureBox1;
		[CompilerGenerated]
		private static Func<string, bool> func_0;
		public LoginWindow()
		{
			this.InitializeComponent();
			Label expr_28 = this.LabelVersion;
			expr_28.Text += "Alpha 0.0.1";
			int width = TextRenderer.MeasureText("v1.1.0", this.LabelVersion.Font).Width;
			this.LabelVersion.Location = new Point(this.LabelVersion.Location.X - width, this.LabelVersion.Location.Y);
			Class4.smethod_0();
			Class4.saveSettingFile("LauncherPID", Process.GetCurrentProcess().Id.ToString());
			Settings.Default.Upgrade();
			this.LicenceKeyBox.Text = Settings.Default.LastUsedKeys;
			this.LicenceKeyBox.Focus();
			Directory.CreateDirectory(LoginWindow.hbFolderPath);
      
		}
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.LicenceKeyBox = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnExtendLicenceBox = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LicenceKeyBox
            // 
            this.LicenceKeyBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceKeyBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenceKeyBox.Location = new System.Drawing.Point(9, 41);
            this.LicenceKeyBox.Name = "LicenceKeyBox";
            this.LicenceKeyBox.Size = new System.Drawing.Size(233, 23);
            this.LicenceKeyBox.TabIndex = 0;
            this.LicenceKeyBox.Enter += new System.EventHandler(this.LicenceKeyBox_Enter);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.Location = new System.Drawing.Point(21, 105);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(262, 26);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Login";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Licence Key:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.BtnExtendLicenceBox);
            this.groupBox1.Controls.Add(this.statusLabel);
            this.groupBox1.Controls.Add(this.LicenceKeyBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(350, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(280, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // BtnExtendLicenceBox
            // 
            this.BtnExtendLicenceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExtendLicenceBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnExtendLicenceBox.Location = new System.Drawing.Point(245, 40);
            this.BtnExtendLicenceBox.Name = "BtnExtendLicenceBox";
            this.BtnExtendLicenceBox.Size = new System.Drawing.Size(26, 25);
            this.BtnExtendLicenceBox.TabIndex = 6;
            this.BtnExtendLicenceBox.Text = "+";
            this.BtnExtendLicenceBox.UseVisualStyleBackColor = true;
            this.BtnExtendLicenceBox.Click += new System.EventHandler(this.BtnExtendLicenceBox_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statusLabel.Location = new System.Drawing.Point(9, 77);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(2);
            this.statusLabel.Size = new System.Drawing.Size(262, 42);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Ready";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelVersion
            // 
            this.LabelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelVersion.AutoSize = true;
            this.LabelVersion.BackColor = System.Drawing.Color.Transparent;
            this.LabelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelVersion.Location = new System.Drawing.Point(223, 141);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(51, 12);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "Version: ";
            this.LabelVersion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelVersion_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 96);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginWindow
            // 
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(304, 162);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LabelVersion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.submitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.Shown += new System.EventHandler(this.LoginWindow_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private void submitBtn_Click(object sender, EventArgs e)
		{
			
				this.method_4(true);
				this.statusLabel.Text = "Connecting...";
				if (this.tcpClient_0 != null)
				{
					this.thread_0.Abort();
					this.tcpClient_0.Close();
					this.tcpClient_0 = null;
				}
				this.thread_0 = new Thread(new ThreadStart(this.method_0));
				this.thread_0.IsBackground = true;
				this.thread_0.Start();
				return;
			
		}
		private void method_0()
		{
			Action action = null;
			Action action2 = null;
			Action action3 = null;
			try
			{
				this.tcpClient_0 = new TcpClient();
        Int32 a = 1;
				/*if (!this.tcpClient_0.smethod_7("193.192.58.73", 2795, 2000))
				{
					this.method_4(false);
					this.statusLabel.saveSettingFile("Connection timed out...");
				}*/
        if (a!=1)
        {
        }
				else
				{
					this.tcpClient_0.ReceiveTimeout = 12000;
					Control arg_76_0 = this.statusLabel;
					if (action == null)
					{
          //authenticating label
						action = new Action(this.method_10);
					}
					arg_76_0.Invoke(action);
         
//           IPEndPoint ipe = new IPEndPoint(new IPAddress(123), 1);
//           Socket tempSocket =
//               new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);


					//NetworkStream stream = this.tcpClient_0.GetStream();
         // NetworkStream stream = new NetworkStream(tempSocket);

					//stream.smethod_3("v1.1.0");
					string[] array = this.LicenceKeyBox.Text.Split(new string[]
					{
						"\r\n"
					}, StringSplitOptions.RemoveEmptyEntries);
					if (a != 1) //(array.Length > 20)
					{
						MessageBox.Show("You cannot submit more than 20 keys");
						this.tcpClient_0.Close();
						this.method_4(false);
						this.statusLabel.smethod_1("Ready");
					}
					else
					{
						//stream.SaveSettingsFile2(array.Length);
						for (int i = 0; i < array.Length; i++)
						{
							//stream.smethod_3(array[i]);
						}
						int num = 5; // siehe abfrage unten ;stream.smethod_4();
						if (num == 3)
						{
							LoginWindow.Class19 @class = new LoginWindow.Class19();
							@class.loginWindow_0 = this;
							@class.string_0 = "hannes";//stream.smethod_2();
							@class.string_1 = "bannes";//stream.smethod_2();
							this.tcpClient_0.Close();
							this.statusLabel.Invoke(new Action(@class.method_0));
							base.Invoke(new MethodInvoker(@class.method_1));
						}
						else
						{
							if (num == 1)
							{
								/*int num2 = stream.smethod_4();
								string str = "";
								int num3 = 0;
								bool flag = false;
								for (int j = 0; j < num2; j++)
								{
									string text = stream.smethod_2();
									str = str + text + "\r\n";
									if (text.Contains(" InvalidKey"))
									{
										num3++;
									}
									if (text.Contains(" NotActivated"))
									{
										flag = true;
									}
								}
								this.tcpClient_0.Close();
								if (num3 > 0)
								{
									str += "\r\n\r\nTo prevent trying out keys, we ban people for entering wrong keys.\r\n\r\nA ban is 10 seconds for every wrong key\r\n";
									str += "You entered {0} wrong keys, so thats {1} seconds.".saveSettingFile(num3, num3 * 10);
								}
								if (flag)
								{
									str += "\r\n\r\nThere is one or more valid keys that are not active yet. You can activate them with the launcher.";
								}
								LoginFailedDialog loginFailedDialog = new LoginFailedDialog(str);
								loginFailedDialog.ShowDialog();
								this.method_4(false);
								this.statusLabel.saveSettingFile("Authentication failed");
                */
							}
							else
							{
								/*this.sessionID = stream.smethod_2();
								this.stringThatIsObtainedFromServer = stream.smethod_2();
								this.int_3 = stream.smethod_4();
								this.int_1 = stream.smethod_4();
								this.portNumber = stream.smethod_4();

               
                
								int num4 = stream.smethod_4();*/
								Control arg_2CB_0 = this.statusLabel;
								if (action2 == null)
								{
									action2 = new Action(this.method_11);
								}
								arg_2CB_0.Invoke(action2);
								List<LoginWindow.Class0> list = new List<LoginWindow.Class0>(1);
								this.list_0 = new List<LoginWindow.Class0>();
								for (int k = 0; k < 1 ; k++)
								{
                                    string string_ = "string";//stream.smethod_2();   //These strings are probably important
								    string checksum = "string2";//stream.smethod_2(); //
									int capacity = 10000000;//stream.smethod_4();
									LoginWindow.Class0 class2 = new LoginWindow.Class0();
									class2.someFileName = string_;
									class2.checksum = checksum;
									class2.capacity = capacity;
									class2.stream = new MemoryStream(capacity);
									this.list_0.Add(class2);
									if (!this.verifyFileIntegrity(string_, checksum))
									{
										list.Add(class2);
									}
								}
								/*IEnumerable<string> arg_382_0 = Environment.GetCommandLineArgs();
								if (LoginWindow.func_0 == null)
								{
									LoginWindow.func_0 = new Func<string, bool>(LoginWindow.saveSettingFile);
								}
								bool flag2;
								if (flag2 = (arg_382_0.FirstOrDefault(LoginWindow.func_0) != null))
								{
									MessageBox.Show("-noupdate is active, the launcher will not download updates!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								}
                 * */
								
                /*if (list.Count > 0 && list.Count < 6)
								{
									DialogResult dialogResult = MessageBox.Show("There is a new version available.\r\nYou should always use the latest version.\r\n\r\nDo you want to download the update now?", "UPDATE", MessageBoxButtons.YesNo);
									if (dialogResult == DialogResult.No)
									{
										flag2 = true;
									}
								}
                 * */
								if (a!=1) //(list.Count != 0 && !flag2)
								{
									this.tcpClient_0.Close();
									this.method_1(list);
								}
								else
								{
									LoginWindow.string_9 = array;
									if (action3 == null)
									{
										
                                       action3 = new Action(this.method_12);
									}
									base.Invoke(action3);
								}
							}
						}
					}
				}
			}
			catch (Exception exception_)
			{
				LoginWindow.Class12 class3 = new LoginWindow.Class12();
				class3.exception_0 = exception_;
				class3.loginWindow_0 = this;
				this.statusLabel.Invoke(new Action(class3.method_0));
				this.method_4(false);
			}
		}
		private void method_1(List<LoginWindow.Class0> list_1)
		{
			this.statusLabel.Invoke(new Action(this.method_13));
			for (int i = 0; i < list_1.Count; i++)
			{
				LoginWindow.Class13 @class = new LoginWindow.Class13();
				@class.loginWindow_0 = this;
				this.tcpClient_0 = new TcpClient();
				//this.tcpClient_0.Connect("193.192.58.73", this.int_1);
				this.tcpClient_0.ReceiveTimeout = 12000;
				NetworkStream stream = this.tcpClient_0.GetStream();
				stream.smethod_3(this.sessionID);
				@class.class0_0 = list_1[i];
				stream.smethod_3(@class.class0_0.someFileName);
				@class.string_0 = "File: {0}/{1}\n".smethod_1(i + 1, list_1.Count);
				stream.smethod_1(list_1[i].capacity, new Action<int, int, byte[], int>(@class.method_0), 500);
				Thread.Sleep(100);
				this.statusLabel.Invoke(new Action(@class.method_1));
				string path = Path.Combine(LoginWindow.hbFolderPath, @class.class0_0.someFileName);
				if (File.Exists(path))
				{
					File.SetAttributes(path, FileAttributes.Hidden);
					File.Delete(path);
				}
				File.WriteAllBytes(path, this.method_5(@class.class0_0.stream.ToArray()));
				File.SetAttributes(path, FileAttributes.Hidden);
				string a = Class7.smethod_0(path);
				if (a != @class.class0_0.checksum)
				{
					MessageBox.Show("Network error! The checksum of the downloaded file is not correct!", "Launcher", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					File.Delete(path);
					Environment.Exit(0);
				}
				this.tcpClient_0.Close();
				Thread.Sleep(100);
			}
			this.method_0();
		}
		private void method_2()
		{
			this.tcpClient_0.Close();
			Settings.Default.LastUsedKeys = this.LicenceKeyBox.Text;
			Settings.Default.Save();
			int num = 1;
			IEnumerable<string> enumerable = Directory.EnumerateDirectories(LoginWindow.hbFolderPath, "*", SearchOption.TopDirectoryOnly);
			foreach (string current in enumerable)
			{
				try
				{
					if (current.Contains("\\WorkingDir-"))
					{
						Directory.Delete(current, true);
					}
				}
				catch
				{
				}
			}
			do
			{
				this.workingDirectoryPath = Path.Combine(LoginWindow.hbFolderPath, "WorkingDir-" + num);
				num++;
			}
			while (Directory.Exists(this.workingDirectoryPath));
			Directory.CreateDirectory(this.workingDirectoryPath);
			File.SetAttributes(this.workingDirectoryPath, FileAttributes.Hidden | FileAttributes.System | FileAttributes.Directory);
			Class4.SaveSettingsFile2();
			Class4.saveSettingFile("SessionHost", "193.192.58.73");
			Class4.saveSettingFile("SessionPort", this.portNumber.ToString());
			Class4.saveSettingFile("SessionID", this.sessionID);
			foreach (LoginWindow.Class0 current2 in this.list_0)
			{
				string sourceFileName = Path.Combine(LoginWindow.hbFolderPath, current2.someFileName);
				if (current2.someFileName == "NETLoader.dll")
				{
                    byte[] array = File.ReadAllBytes(Path.Combine(LoginWindow.hbFolderPath, "NETLoader.dll"));
					this.method_3(array, "SELFSELFSELFSELFSELFSELF.dll", "NETLoader.dll");
					this.method_3(array, "TARGETTARGETTARGETTARGET.dll", "7889083D.dll");
					this.method_3(array, "NAMESPACECLASSCLASSCLASSCLASSCLASS", "HellBuddy.ContainerA");
					this.method_3(array, "MAINMAINMAINMAINMAIN", "EntryPoint");
					string path = Path.Combine(this.workingDirectoryPath, current2.someFileName);
					File.WriteAllBytes(path, array);
					File.SetAttributes(path, FileAttributes.Hidden);
				}
				else
				{
					if (current2.someFileName.EndsWith(".txt"))
					{
						string text = Path.Combine(LoginWindow.hbFolderPath, "Profiles");
						if (!Directory.Exists(text))
						{
							Directory.CreateDirectory(text);
						}
						string text2 = Path.Combine(text, current2.someFileName);
						if (File.Exists(text2))
						{
							File.Delete(text2);
						}
						File.Copy(sourceFileName, text2);
						File.SetAttributes(text2, FileAttributes.Normal);
					}
					else
					{
						string filename = Path.Combine(this.workingDirectoryPath, current2.someFileName);
						if (File.Exists(filename))
						{
							File.Delete(filename);
						}
                        if (File.Exists(sourceFileName))
                        {
                            File.Copy(sourceFileName, filename);
                            File.SetAttributes(filename, FileAttributes.Hidden);
                        }
					}
				}
			}
			base.Hide();

			this.method_4(false);
			ProfileManager profileManager = new ProfileManager(this.workingDirectoryPath, this.stringThatIsObtainedFromServer, "NETLoader.dll", this.int_3);
			profileManager.ShowDialog(this);
			Environment.Exit(0);
		}
		private void method_3(byte[] byte_0, string string_11, string string_12)
		{
			Stream stream = new MemoryStream(byte_0, true);
			new StreamReader(stream);
			new StreamWriter(stream);
			byte[] bytes = Encoding.Unicode.GetBytes(string_11);
			byte[] bytes2 = Encoding.Unicode.GetBytes(string_12);
			Array.Resize<byte>(ref bytes2, bytes2.Length + 4);
			if (bytes.Length < bytes2.Length)
			{
				throw new ArgumentException("target must be longer than replacement bytes");
			}
			int num;
			while ((num = LoginWindow.smethod_0(byte_0, bytes)) > -1)
			{
				for (int i = 0; i < bytes2.Length; i++)
				{
					byte_0[num + i] = bytes2[i];
				}
			}
			bytes = Encoding.ASCII.GetBytes(string_11);
			bytes2 = Encoding.ASCII.GetBytes(string_12);
			Array.Resize<byte>(ref bytes2, bytes2.Length + 1);
			while ((num = LoginWindow.smethod_0(byte_0, bytes)) > -1)
			{
				for (int j = 0; j < bytes2.Length; j++)
				{
					byte_0[num + j] = bytes2[j];
				}
			}
		}
		private static int smethod_0(byte[] byte_0, byte[] byte_1)
		{
			if (byte_1.Length > byte_0.Length)
			{
				return -1;
			}
			int i = 0;
			IL_35:
			while (i < byte_0.Length - byte_1.Length)
			{
				bool flag = true;
				int j = 0;
				while (j < byte_1.Length)
				{
					if (byte_0[i + j] != byte_1[j])
					{
						flag = false;
						
						if (!flag)
						{
							i++;
							goto IL_35;
						}
						return i;
					}
					else
					{
						j++;
					}
				}
				
			}
			return -1;
		}
		private void method_4(bool bool_0)
		{
			LoginWindow.Class11 @class = new LoginWindow.Class11();
			@class.bool_0 = bool_0;
			@class.loginWindow_0 = this;
			base.Invoke(new Action(@class.method_0));
		}
		private byte[] method_5(byte[] byte_0)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(byte_0))
			{
				using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					byte[] buffer = new byte[4096];
					using (MemoryStream memoryStream2 = new MemoryStream())
					{
						int num;
						do
						{
							num = gZipStream.Read(buffer, 0, 4096);
							if (num > 0)
							{
								memoryStream2.Write(buffer, 0, num);
							}
						}
						while (num > 0);
						result = memoryStream2.ToArray();
					}
				}
			}
			return result;
		}
		private bool verifyFileIntegrity(string filename, string checksum)
		{
			filename = Path.Combine(LoginWindow.hbFolderPath, filename);
			if (File.Exists(filename))
			{
				string b = Class7.smethod_0(filename);
				if (checksum == b)
				{
					return true;
				}
			}
			return false;
		}
		private void OpenHellbuddyWebSite(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://www.hellbuddy.com");
		}
		private void method_8(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				this.submitBtn_Click(null, null);
			}
		}
		private void LoginWindow_Shown(object sender, EventArgs e)
		{
			Settings.Default.Upgrade();
			if (Settings.Default.TryAutoLogin)
			{
				this.submitBtn_Click(null, null);
				return;
			}
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			if (commandLineArgs.Length <= 1)
			{
				return;
			}
			if (this.LicenceKeyBox.Text.Length > 0)
			{
				if (commandLineArgs[1] == "-autologin")
				{
					this.submitBtn_Click(null, null);
					return;
				}
				AutoLogin autoLogin = new AutoLogin(1.5f);
				if (autoLogin.ShowDialog(this) == DialogResult.OK)
				{
					this.submitBtn_Click(null, null);
				}
			}
		}
		private void LabelVersion_MouseUp(object sender, MouseEventArgs e)
		{
			if (!Directory.Exists(LoginWindow.hbFolderPath))
			{
				Directory.CreateDirectory(LoginWindow.hbFolderPath);
			}
			string text = Path.Combine(LoginWindow.hbFolderPath, "Quests");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start("explorer.exe", text);
		}
		private void BtnExtendLicenceBox_Click(object sender, EventArgs e)
		{
			this.BtnExtendLicenceBox.Visible = false;
			this.LicenceKeyBox.Multiline = true;
			base.Size = new Size(base.Size.Width, base.Size.Height + 150);
			this.LicenceKeyBox.Width += 26;
		}
		private void LicenceKeyBox_Enter(object sender, EventArgs e)
		{
			this.LicenceKeyBox.SelectAll();
		}
		private void method_9(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//ActivateKeyDialog activateKeyDialog = new ActivateKeyDialog("193.192.58.73");
			//activateKeyDialog.ShowDialog();
		}
		private void LoginWindow_Load(object sender, EventArgs e)
		{
		}
		[CompilerGenerated]
		private void method_10()
		{
			this.statusLabel.Text = "Authenticating...";
		}
		[CompilerGenerated]
		private void method_11()
		{
			this.statusLabel.Text = "Checking files...";
		}
		[CompilerGenerated]
		private static bool smethod_1(string string_11)
		{
			return string_11.Trim() == "-noupdate";
		}
		[CompilerGenerated]
		private void method_12()
		{
			this.method_2();
		}
		[CompilerGenerated]
		private void method_13()
		{
			this.statusLabel.Text = "Streaming...";
		}
	}
}
