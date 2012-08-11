using Launcher;
using Launcher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ns0
{
	public sealed class ProfileManager : Form
	{
		[CompilerGenerated]
		private sealed class Class8
		{
			public string string_0;
			public bool method_0(Profile profile_0)
			{
				return profile_0.ProfileName == this.string_0;
			}
		}
		private IContainer icontainer_0;
		private Button NewProfileBtn;
		private Button DeleteProfileBtn;
		private System.Windows.Forms.Timer timer_0;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private GroupBox groupBox1;
		private TextBox ProfilePasswordBox;
		private Label label4;
		private TextBox ProfileEmailBox;
		private Label label3;
		private ListBox ProfileListBox;
		private Button StartStopBtn;
		private Button BtnCheckForUpdate;
		private Label label5;
		private CheckBox CheckBoxKillErrorReporter;
		private Panel panel1;
		private CheckBox CheckBoxAutoLogin;
		private TextBox textBoxAdditionalParameters;
		private Label label10;
		private TabPage tabPage3;
		private GroupBox Schedule_Container;
		private Label label11;
		private Button Schedule_Add;
		private Button Scheduler_DeleteEntry;
		private ListBox Schedule_ListBox;
		private CheckBox Schedule_UseScheduler;
		private Label label12;
		private DateTimePicker Schedule_StartTime;
		private DateTimePicker Schedule_StopTime;
		private Label InfoLabel;
		private Panel panel2;
		private Button BtnRenameProfile;
		private TextBox D3PathBox;
		private Label label1;
		private Button BtnSelectD3Exe;
		private NumericUpDown NumericUpdown_ForceRestartMinutes;
		private Label label2;
		private CheckBox Checkbox_AutoLogin;
		private CheckBox CheckBox_AutostartProfile;
		private Label label6;
		private ComboBox ComboBox_RegionOverride;
		internal static string string_0;
		internal static string string_1;
		internal static string string_2;
		internal List<Profile> list_0;
		[CompilerGenerated]
		private static ProfileManager profileManager_0;
		[CompilerGenerated]
		private static int int_0;
		[CompilerGenerated]
		private DateTime dateTime_0;
		[CompilerGenerated]
		private static Action action_0;
		[CompilerGenerated]
		private static Func<Profile.Class1, TimeSpan> func_0;
		[CompilerGenerated]
		private static Func<Profile.Class1, TimeSpan> func_1;
		[CompilerGenerated]
		private static ThreadStart threadStart_0;
		public static ProfileManager Instance
		{
			get;
			private set;
		}
		internal static int maxClients
		{
			get;
			private set;
		}
		public DateTime lastValidResponse
		{
			get;
			set;
		}
		public ProfileManager(string string_3, string string_4, string string_5, int int_1)
		{
			ThreadStart threadStart = null;
			this.list_0 = new List<Profile>();
     
			ProfileManager.Instance = this;
			this.InitializeComponent();
			this.Text = Guid.NewGuid().ToString().Replace("-", "");
            this.InfoLabel.Text = "{0} (Keys: {1}) ".smethod_1("Project Respawn Alpha", int_1);
            ProfileManager.maxClients = 100;
			ProfileManager.string_0 = string_3;
            ProfileManager.string_1 = "CA89013A047D5D70CC28FB872E543604"; // This needs to be updated to new newest game version code. //
			ProfileManager.string_2 = string_5;
			this.Checkbox_AutoLogin.Checked = Settings.Default.TryAutoLogin;
			string[] names = Enum.GetNames(typeof(Profile.RegionOverride));
			for (int i = 0; i < names.Length; i++)
			{
				string item = names[i];
				this.ComboBox_RegionOverride.Items.Add(item);
			}
			this.method_0();
			if (threadStart == null)
			{
				threadStart = new ThreadStart(this.method_6);
			}
			new Thread(threadStart);
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
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ProfileManager));
			this.NewProfileBtn = new Button();
			this.DeleteProfileBtn = new Button();
			this.timer_0 = new System.Windows.Forms.Timer(this.icontainer_0);
			this.tabControl1 = new TabControl();
			this.tabPage1 = new TabPage();
			this.panel1 = new Panel();
			this.groupBox1 = new GroupBox();
			this.CheckBox_AutostartProfile = new CheckBox();
			this.BtnSelectD3Exe = new Button();
			this.textBoxAdditionalParameters = new TextBox();
			this.D3PathBox = new TextBox();
			this.label10 = new Label();
			this.label1 = new Label();
			this.CheckBoxAutoLogin = new CheckBox();
			this.label3 = new Label();
			this.ProfileEmailBox = new TextBox();
			this.ProfilePasswordBox = new TextBox();
			this.label4 = new Label();
			this.tabPage3 = new TabPage();
			this.panel2 = new Panel();
			this.NumericUpdown_ForceRestartMinutes = new NumericUpDown();
			this.label2 = new Label();
			this.Schedule_UseScheduler = new CheckBox();
			this.Schedule_Container = new GroupBox();
			this.Schedule_StopTime = new DateTimePicker();
			this.Schedule_StartTime = new DateTimePicker();
			this.label12 = new Label();
			this.label11 = new Label();
			this.Schedule_Add = new Button();
			this.Scheduler_DeleteEntry = new Button();
			this.Schedule_ListBox = new ListBox();
			this.tabPage2 = new TabPage();
			this.Checkbox_AutoLogin = new CheckBox();
			this.label5 = new Label();
			this.CheckBoxKillErrorReporter = new CheckBox();
			this.BtnCheckForUpdate = new Button();
			this.ProfileListBox = new ListBox();
			this.StartStopBtn = new Button();
			this.InfoLabel = new Label();
			this.BtnRenameProfile = new Button();
			this.label6 = new Label();
			this.ComboBox_RegionOverride = new ComboBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.panel2.SuspendLayout();
			((ISupportInitialize)this.NumericUpdown_ForceRestartMinutes).BeginInit();
			this.Schedule_Container.SuspendLayout();
			this.tabPage2.SuspendLayout();
			base.SuspendLayout();
			this.NewProfileBtn.Location = new Point(12, 100);
			this.NewProfileBtn.Name = "NewProfileBtn";
			this.NewProfileBtn.Size = new Size(59, 23);
			this.NewProfileBtn.TabIndex = 2;
			this.NewProfileBtn.Text = "New";
			this.NewProfileBtn.UseVisualStyleBackColor = true;
			this.NewProfileBtn.Click += new EventHandler(this.NewProfileBtn_Click);
			this.DeleteProfileBtn.Location = new Point(77, 100);
			this.DeleteProfileBtn.Name = "DeleteProfileBtn";
			this.DeleteProfileBtn.Size = new Size(59, 23);
			this.DeleteProfileBtn.TabIndex = 3;
			this.DeleteProfileBtn.Text = "Delete";
			this.DeleteProfileBtn.UseVisualStyleBackColor = true;
			this.DeleteProfileBtn.Click += new EventHandler(this.DeleteProfileBtn_Click);
			this.timer_0.Enabled = true;
			this.timer_0.Interval = 250;
			this.timer_0.Tick += new EventHandler(this.timer_0_Tick);
			this.tabControl1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new Point(12, 129);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new Size(395, 355);
			this.tabControl1.TabIndex = 5;
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new Size(387, 329);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Profile Details";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = DockStyle.Fill;
			this.panel1.Location = new Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new Padding(12);
			this.panel1.Size = new Size(387, 329);
			this.panel1.TabIndex = 8;
			this.groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox1.Controls.Add(this.ComboBox_RegionOverride);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.CheckBox_AutostartProfile);
			this.groupBox1.Controls.Add(this.BtnSelectD3Exe);
			this.groupBox1.Controls.Add(this.textBoxAdditionalParameters);
			this.groupBox1.Controls.Add(this.D3PathBox);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.CheckBoxAutoLogin);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.ProfileEmailBox);
			this.groupBox1.Controls.Add(this.ProfilePasswordBox);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new Point(15, 15);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new Padding(20, 12, 20, 12);
			this.groupBox1.Size = new Size(357, 299);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Profile Settings";
			this.CheckBox_AutostartProfile.AutoSize = true;
			this.CheckBox_AutostartProfile.Location = new Point(23, 177);
			this.CheckBox_AutostartProfile.Name = "CheckBox_AutostartProfile";
			this.CheckBox_AutostartProfile.Size = new Size(237, 17);
			this.CheckBox_AutostartProfile.TabIndex = 17;
			this.CheckBox_AutostartProfile.Text = "Autostart this profile when the launcher starts";
			this.CheckBox_AutostartProfile.UseVisualStyleBackColor = true;
			this.CheckBox_AutostartProfile.CheckedChanged += new EventHandler(this.CheckBox_AutostartProfile_CheckedChanged);
			this.BtnSelectD3Exe.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.BtnSelectD3Exe.Location = new Point(294, 223);
			this.BtnSelectD3Exe.Name = "BtnSelectD3Exe";
			this.BtnSelectD3Exe.Size = new Size(40, 23);
			this.BtnSelectD3Exe.TabIndex = 16;
			this.BtnSelectD3Exe.Text = "...";
			this.BtnSelectD3Exe.UseVisualStyleBackColor = true;
			this.BtnSelectD3Exe.Click += new EventHandler(this.BtnSelectD3Exe_Click);
			this.textBoxAdditionalParameters.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.textBoxAdditionalParameters.Location = new Point(23, 264);
			this.textBoxAdditionalParameters.Name = "textBoxAdditionalParameters";
			this.textBoxAdditionalParameters.Size = new Size(311, 20);
			this.textBoxAdditionalParameters.TabIndex = 15;
			this.textBoxAdditionalParameters.TextChanged += new EventHandler(this.textBoxAdditionalParameters_TextChanged);
			this.D3PathBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.D3PathBox.Location = new Point(23, 225);
			this.D3PathBox.Name = "D3PathBox";
			this.D3PathBox.Size = new Size(265, 20);
			this.D3PathBox.TabIndex = 6;
			this.D3PathBox.TextChanged += new EventHandler(this.D3PathBox_TextChanged);
			this.label10.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label10.AutoSize = true;
			this.label10.Location = new Point(23, 248);
			this.label10.Name = "label10";
			this.label10.Size = new Size(112, 13);
			this.label10.TabIndex = 14;
			this.label10.Text = "Additional Parameters:";
			this.label1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(23, 209);
			this.label1.Name = "label1";
			this.label1.Size = new Size(63, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Executable:";
			this.CheckBoxAutoLogin.AutoSize = true;
			this.CheckBoxAutoLogin.Location = new Point(23, 28);
			this.CheckBoxAutoLogin.Name = "CheckBoxAutoLogin";
			this.CheckBoxAutoLogin.Size = new Size(124, 17);
			this.CheckBoxAutoLogin.TabIndex = 3;
			this.CheckBoxAutoLogin.Text = "Autologin to account";
			this.CheckBoxAutoLogin.UseVisualStyleBackColor = true;
			this.CheckBoxAutoLogin.CheckedChanged += new EventHandler(this.CheckBoxAutoLogin_CheckedChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new Point(23, 48);
			this.label3.Name = "label3";
			this.label3.Size = new Size(35, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Email:";
			this.ProfileEmailBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.ProfileEmailBox.Enabled = false;
			this.ProfileEmailBox.Location = new Point(23, 64);
			this.ProfileEmailBox.Name = "ProfileEmailBox";
			this.ProfileEmailBox.Size = new Size(311, 20);
			this.ProfileEmailBox.TabIndex = 1;
			this.ProfileEmailBox.TextChanged += new EventHandler(this.ProfileEmailBox_TextChanged);
			this.ProfilePasswordBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.ProfilePasswordBox.Enabled = false;
			this.ProfilePasswordBox.Location = new Point(23, 103);
			this.ProfilePasswordBox.Name = "ProfilePasswordBox";
			this.ProfilePasswordBox.Size = new Size(311, 20);
			this.ProfilePasswordBox.TabIndex = 1;
			this.ProfilePasswordBox.UseSystemPasswordChar = true;
			this.ProfilePasswordBox.TextChanged += new EventHandler(this.ProfilePasswordBox_TextChanged);
			this.label4.AutoSize = true;
			this.label4.Location = new Point(23, 87);
			this.label4.Name = "label4";
			this.label4.Size = new Size(56, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Password:";
			this.tabPage3.Controls.Add(this.panel2);
			this.tabPage3.Location = new Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new Size(387, 318);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Profile Schedule";
			this.tabPage3.UseVisualStyleBackColor = true;
			this.panel2.Controls.Add(this.NumericUpdown_ForceRestartMinutes);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.Schedule_UseScheduler);
			this.panel2.Controls.Add(this.Schedule_Container);
			this.panel2.Dock = DockStyle.Fill;
			this.panel2.Location = new Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new Padding(12);
			this.panel2.Size = new Size(387, 318);
			this.panel2.TabIndex = 4;
			this.NumericUpdown_ForceRestartMinutes.Location = new Point(208, 10);
			NumericUpDown arg_D3B_0 = this.NumericUpdown_ForceRestartMinutes;
			int[] array = new int[4];
			array[0] = 300;
			arg_D3B_0.Maximum = new decimal(array);
			this.NumericUpdown_ForceRestartMinutes.Name = "NumericUpdown_ForceRestartMinutes";
			this.NumericUpdown_ForceRestartMinutes.Size = new Size(75, 20);
			this.NumericUpdown_ForceRestartMinutes.TabIndex = 4;
			this.NumericUpdown_ForceRestartMinutes.ValueChanged += new EventHandler(this.NumericUpdown_ForceRestartMinutes_ValueChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new Point(15, 12);
			this.label2.Name = "label2";
			this.label2.Size = new Size(187, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Force restart every X minutes (0 is off):";
			this.Schedule_UseScheduler.AutoSize = true;
			this.Schedule_UseScheduler.Location = new Point(18, 43);
			this.Schedule_UseScheduler.Name = "Schedule_UseScheduler";
			this.Schedule_UseScheduler.Size = new Size(91, 17);
			this.Schedule_UseScheduler.TabIndex = 1;
			this.Schedule_UseScheduler.Text = "Use schedule";
			this.Schedule_UseScheduler.UseVisualStyleBackColor = true;
			this.Schedule_UseScheduler.CheckedChanged += new EventHandler(this.Schedule_UseScheduler_CheckedChanged);
			this.Schedule_Container.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.Schedule_Container.Controls.Add(this.Schedule_StopTime);
			this.Schedule_Container.Controls.Add(this.Schedule_StartTime);
			this.Schedule_Container.Controls.Add(this.label12);
			this.Schedule_Container.Controls.Add(this.label11);
			this.Schedule_Container.Controls.Add(this.Schedule_Add);
			this.Schedule_Container.Controls.Add(this.Scheduler_DeleteEntry);
			this.Schedule_Container.Controls.Add(this.Schedule_ListBox);
			this.Schedule_Container.Enabled = false;
			this.Schedule_Container.Location = new Point(15, 66);
			this.Schedule_Container.Name = "Schedule_Container";
			this.Schedule_Container.Padding = new Padding(6);
			this.Schedule_Container.Size = new Size(357, 208);
			this.Schedule_Container.TabIndex = 2;
			this.Schedule_Container.TabStop = false;
			this.Schedule_Container.Text = "Active times";
			this.Schedule_StopTime.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Schedule_StopTime.Format = DateTimePickerFormat.Time;
			this.Schedule_StopTime.Location = new Point(149, 176);
			this.Schedule_StopTime.Name = "Schedule_StopTime";
			this.Schedule_StopTime.ShowUpDown = true;
			this.Schedule_StopTime.Size = new Size(64, 20);
			this.Schedule_StopTime.TabIndex = 13;
			this.Schedule_StartTime.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Schedule_StartTime.Format = DateTimePickerFormat.Time;
			this.Schedule_StartTime.Location = new Point(50, 176);
			this.Schedule_StartTime.Name = "Schedule_StartTime";
			this.Schedule_StartTime.ShowUpDown = true;
			this.Schedule_StartTime.Size = new Size(64, 20);
			this.Schedule_StartTime.TabIndex = 12;
			this.label12.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label12.AutoSize = true;
			this.label12.Location = new Point(120, 180);
			this.label12.Name = "label12";
			this.label12.Size = new Size(23, 13);
			this.label12.TabIndex = 9;
			this.label12.Text = "To:";
			this.label11.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label11.AutoSize = true;
			this.label11.Location = new Point(11, 180);
			this.label11.Name = "label11";
			this.label11.Size = new Size(33, 13);
			this.label11.TabIndex = 5;
			this.label11.Text = "From:";
			this.Schedule_Add.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Schedule_Add.Location = new Point(219, 174);
			this.Schedule_Add.Name = "Schedule_Add";
			this.Schedule_Add.Size = new Size(60, 23);
			this.Schedule_Add.TabIndex = 2;
			this.Schedule_Add.Text = "Add";
			this.Schedule_Add.UseVisualStyleBackColor = true;
			this.Schedule_Add.Click += new EventHandler(this.Schedule_Add_Click);
			this.Scheduler_DeleteEntry.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.Scheduler_DeleteEntry.Location = new Point(285, 174);
			this.Scheduler_DeleteEntry.Name = "Scheduler_DeleteEntry";
			this.Scheduler_DeleteEntry.Size = new Size(60, 23);
			this.Scheduler_DeleteEntry.TabIndex = 1;
			this.Scheduler_DeleteEntry.Text = "Delete";
			this.Scheduler_DeleteEntry.UseVisualStyleBackColor = true;
			this.Scheduler_DeleteEntry.Click += new EventHandler(this.Scheduler_DeleteEntry_Click);
			this.Schedule_ListBox.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.Schedule_ListBox.FormattingEnabled = true;
			this.Schedule_ListBox.Location = new Point(12, 20);
			this.Schedule_ListBox.Name = "Schedule_ListBox";
			this.Schedule_ListBox.Size = new Size(333, 147);
			this.Schedule_ListBox.TabIndex = 0;
			this.tabPage2.Controls.Add(this.Checkbox_AutoLogin);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.CheckBoxKillErrorReporter);
			this.tabPage2.Controls.Add(this.BtnCheckForUpdate);
			this.tabPage2.Location = new Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new Padding(8);
			this.tabPage2.Size = new Size(387, 318);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Launcher Settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.Checkbox_AutoLogin.AutoSize = true;
			this.Checkbox_AutoLogin.Location = new Point(18, 93);
			this.Checkbox_AutoLogin.Name = "Checkbox_AutoLogin";
			this.Checkbox_AutoLogin.Size = new Size(165, 17);
			this.Checkbox_AutoLogin.TabIndex = 9;
			this.Checkbox_AutoLogin.Text = "Try to autologin when starting";
			this.Checkbox_AutoLogin.UseVisualStyleBackColor = true;
			this.Checkbox_AutoLogin.CheckedChanged += new EventHandler(this.Checkbox_AutoLogin_CheckedChanged);
			this.label5.ForeColor = SystemColors.ControlDark;
			this.label5.Location = new Point(34, 41);
			this.label5.Name = "label5";
			this.label5.Size = new Size(319, 30);
			this.label5.TabIndex = 8;
			this.label5.Text = "If the game crashes, it sends information about the crash blizzard. The report may contain evidence of the bot, so don't disable this.";
			this.CheckBoxKillErrorReporter.AutoSize = true;
			this.CheckBoxKillErrorReporter.Checked = true;
			this.CheckBoxKillErrorReporter.CheckState = CheckState.Checked;
			this.CheckBoxKillErrorReporter.Location = new Point(18, 21);
			this.CheckBoxKillErrorReporter.Name = "CheckBoxKillErrorReporter";
			this.CheckBoxKillErrorReporter.Size = new Size(151, 17);
			this.CheckBoxKillErrorReporter.TabIndex = 7;
			this.CheckBoxKillErrorReporter.Text = "Kill \"BlizzardErrorReporter\"";
			this.CheckBoxKillErrorReporter.UseVisualStyleBackColor = true;
			this.CheckBoxKillErrorReporter.CheckedChanged += new EventHandler(this.CheckBoxKillErrorReporter_CheckedChanged);
			this.BtnCheckForUpdate.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.BtnCheckForUpdate.Location = new Point(11, 226);
			this.BtnCheckForUpdate.Name = "BtnCheckForUpdate";
			this.BtnCheckForUpdate.Size = new Size(194, 37);
			this.BtnCheckForUpdate.TabIndex = 6;
			this.BtnCheckForUpdate.Text = "Restart and check for Update";
			this.BtnCheckForUpdate.UseVisualStyleBackColor = true;
			this.BtnCheckForUpdate.Click += new EventHandler(this.BtnCheckForUpdate_Click);
			this.ProfileListBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.ProfileListBox.FormattingEnabled = true;
			this.ProfileListBox.Location = new Point(12, 12);
			this.ProfileListBox.Name = "ProfileListBox";
			this.ProfileListBox.Size = new Size(395, 82);
			this.ProfileListBox.TabIndex = 6;
			this.ProfileListBox.SelectedIndexChanged += new EventHandler(this.ProfileListBox_SelectedIndexChanged);
			this.StartStopBtn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.StartStopBtn.Location = new Point(273, 100);
			this.StartStopBtn.Name = "StartStopBtn";
			this.StartStopBtn.Size = new Size(134, 23);
			this.StartStopBtn.TabIndex = 7;
			this.StartStopBtn.Text = "Start Profile";
			this.StartStopBtn.UseVisualStyleBackColor = true;
			this.StartStopBtn.Click += new EventHandler(this.StartStopBtn_Click);
			this.InfoLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.InfoLabel.AutoSize = true;
			this.InfoLabel.BackColor = Color.Transparent;
			this.InfoLabel.Font = new Font("Segoe UI Semibold", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.InfoLabel.ForeColor = SystemColors.ControlDark;
			this.InfoLabel.Location = new Point(12, 487);
			this.InfoLabel.Name = "InfoLabel";
			this.InfoLabel.Size = new Size(53, 12);
			this.InfoLabel.TabIndex = 8;
			this.InfoLabel.Text = "INFO LABEL";
			this.InfoLabel.MouseUp += new MouseEventHandler(this.InfoLabel_MouseUp);
			this.BtnRenameProfile.Location = new Point(142, 100);
			this.BtnRenameProfile.Name = "BtnRenameProfile";
			this.BtnRenameProfile.Size = new Size(59, 23);
			this.BtnRenameProfile.TabIndex = 9;
			this.BtnRenameProfile.Text = "Rename";
			this.BtnRenameProfile.UseVisualStyleBackColor = true;
			this.BtnRenameProfile.Click += new EventHandler(this.BtnRenameProfile_Click);
			this.label6.AutoSize = true;
			this.label6.Location = new Point(23, 126);
			this.label6.Name = "label6";
			this.label6.Size = new Size(85, 13);
			this.label6.TabIndex = 18;
			this.label6.Text = "Region override:";
			this.ComboBox_RegionOverride.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ComboBox_RegionOverride.FormattingEnabled = true;
			this.ComboBox_RegionOverride.Location = new Point(23, 142);
			this.ComboBox_RegionOverride.Name = "ComboBox_RegionOverride";
			this.ComboBox_RegionOverride.Size = new Size(177, 21);
			this.ComboBox_RegionOverride.TabIndex = 19;
			this.ComboBox_RegionOverride.SelectedIndexChanged += new EventHandler(this.ComboBox_RegionOverride_SelectedIndexChanged);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
//			base.AutoScaleMode = AutoScaleMode.Font;
		//	this.BackgroundImage = Class9.gradient_dim;
			this.BackgroundImageLayout = ImageLayout.Stretch;
			base.ClientSize = new Size(419, 502);
			base.Controls.Add(this.BtnRenameProfile);
			base.Controls.Add(this.InfoLabel);
			base.Controls.Add(this.DeleteProfileBtn);
			base.Controls.Add(this.StartStopBtn);
			base.Controls.Add(this.ProfileListBox);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.NewProfileBtn);
//			base.FormBorderStyle = FormBorderStyle.FixedSingle;
		//	base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Location = new Point(20, 100);
			base.MaximizeBox = false;
			base.Name = "ProfileManager";
			base.StartPosition = FormStartPosition.Manual;
			this.Text = "Project: Respawn Bot - Profile Manager";
			base.FormClosing += new FormClosingEventHandler(this.ProfileManager_FormClosing);
			base.Load += new EventHandler(this.ProfileManager_Load);
			base.Shown += new EventHandler(this.ProfileManager_Shown);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((ISupportInitialize)this.NumericUpdown_ForceRestartMinutes).EndInit();
			this.Schedule_Container.ResumeLayout(false);
			this.Schedule_Container.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		internal static string smethod_0()
		{
			return ProfileManager.string_0;
		}
		internal static string smethod_1()
		{
			return ProfileManager.string_2;
		}
		private void method_0()
		{
			string[] files = Directory.GetFiles(Profile.ProfileFolder, "*.hbp", SearchOption.TopDirectoryOnly);
			string[] array = files;
			for (int i = 0; i < array.Length; i++)
			{
				string fileName = array[i];
				Profile profile = Profile.LoadFromFile(fileName);
				this.list_0.Add(profile);
				if (profile.AutoStartThisProfile)
				{
					profile.ProfileActive = true;
				}
			}
			this.method_1();
			if (this.list_0.Count > 0)
			{
				this.ProfileListBox.SelectedIndex = 0;
				return;
			}
			this.NewProfileBtn_Click(null, null);
		}
		internal void method_1()
		{
			this.ProfileListBox.SuspendLayout();
			int num = 0;
			if (this.ProfileListBox.SelectedIndex > -1)
			{
				num = this.ProfileListBox.SelectedIndex;
			}
			this.ProfileListBox.Items.Clear();
			for (int i = 0; i < this.list_0.Count; i++)
			{
				this.ProfileListBox.Items.Add(this.list_0[i]);
			}
			if (num < this.ProfileListBox.Items.Count && this.ProfileListBox.Items.Count > 0)
			{
				int num2 = this.ProfileListBox.ClientRectangle.Height / this.ProfileListBox.ItemHeight;
				num2 /= 2;
				num2--;
				this.ProfileListBox.SelectedIndex = num;
				int num3 = num - num2;
				if (num3 > -1)
				{
					this.ProfileListBox.TopIndex = num3;
				}
			}
			this.ProfileListBox.ResumeLayout();
			this.ProfileListBox.Update();
      return;
		}
		private void NewProfileBtn_Click(object sender, EventArgs e)
		{
			ProfileManager.Class8 @class = new ProfileManager.Class8();
			Profile profile = new Profile();
			@class.string_0 = null;
			int num = 1;
			while (@class.string_0 == null || this.list_0.FirstOrDefault(new Func<Profile, bool>(@class.method_0)) != null)
			{
				@class.string_0 = "New Profile - " + num;
				num++;
			}
			profile.ProfileName = @class.string_0;
			this.list_0.Add(profile);
			this.method_1();
		}
		internal void method_2()
		{
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			if (profile == null)
			{
				return;
			}
			this.ProfileEmailBox.Text = profile.AccountName;
			this.ProfilePasswordBox.Text = profile.Password;
			if (profile.ProfileActive)
			{
				this.StartStopBtn.Text = "Stop Profile";
			}
			else
			{
				this.StartStopBtn.Text = "Start Profile";
			}
			this.textBoxAdditionalParameters.Text = profile.Parameters;
			this.panel1.Enabled = !profile.ProfileActive;
			this.panel2.Enabled = !profile.ProfileActive;
			this.DeleteProfileBtn.Enabled = !profile.ProfileActive;
			this.BtnRenameProfile.Enabled = !profile.ProfileActive;
			this.CheckBox_AutostartProfile.Checked = profile.AutoStartThisProfile;
			this.CheckBoxAutoLogin.Checked = profile.AutoLogin;
			this.Schedule_UseScheduler.Checked = profile.UseSchedule;
			IEnumerable<Profile.Class1> arg_118_0 = profile.Schedule;
			if (ProfileManager.func_0 == null)
			{
				ProfileManager.func_0 = new Func<Profile.Class1, TimeSpan>(ProfileManager.smethod_3);
			}
			arg_118_0.OrderBy(ProfileManager.func_0);
			this.Schedule_ListBox.Items.Clear();
			this.Schedule_ListBox.Items.AddRange(profile.Schedule.ToArray());
			this.ComboBox_RegionOverride.SelectedIndex = (int)profile.Region;
			this.NumericUpdown_ForceRestartMinutes.Value = profile.ForceRestartTimeoutMinutes;
			this.D3PathBox.Text = profile.D3Executable;
			if (!File.Exists(this.D3PathBox.Text))
			{
				try
				{
					string text = Path.Combine(Class3.smethod_0(), "Diablo III.exe");
					this.D3PathBox.Text = text;
				}
				catch
				{
					this.D3PathBox.Text = "";
				}
			}
      return;
		}
		private void method_3(object sender, EventArgs e)
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				try
				{
					this.list_0[i].SaveToFile();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Settings could not be saved!\n\nExeption: " + ex.Message);
				}
			}
		}
		private void timer_0_Tick(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < this.list_0.Count; i++)
				{
					this.list_0[i].Update();
				}
				if (this.CheckBoxKillErrorReporter.Checked)
				{
					Process[] processesByName = Process.GetProcessesByName("BlizzardError");
					for (int j = 0; j < processesByName.Length; j++)
					{
						Process process = processesByName[j];
						process.Kill();
					}
				}
			}
			catch
			{
			}
		}
		private void ProfileEmailBox_TextChanged(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			profile.AccountName = (sender as TextBox).Text;
		}
		private void ProfilePasswordBox_TextChanged(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			profile.Password = (sender as TextBox).Text;
		}
		private void ProfileListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_2();
		}
		private void StartStopBtn_Click(object sender, EventArgs e)
		{
        //    MessageBox.Show("Currently not available,sorry.","Sorry",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            
            Profile profile = this.ProfileListBox.SelectedItem as Profile;
            if (profile == null)
            {
                return;
            }
            if (profile.AutoLogin && (profile.AccountName.Length < 4 || profile.Password.Length < 4))
            {
                MessageBox.Show("Battle.NET Account-Email / Password invalid!\n\nBoth must be longer than 4 characters!", "Error starting profile", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!profile.ProfileActive)
            {
                if (!File.Exists(profile.D3Executable))
                {
                    MessageBox.Show("The games executable could not be found.", "Cannot start game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string text = Class7.smethod_0(profile.D3Executable);
                if (text != ProfileManager.string_1)
                {
                    MessageBox.Show(string.Concat(new string[]
                    {
                        "This version of the game is not supported.\r\nIf you think you got this message by mistake, then visit our forums.\r\n\r\nThe bot supports this version: ",
                        ProfileManager.string_1,
                        "\r\nYour game has this version: ",
                        text,
                        "\r\n\r\nIf the bot is out of date we will publish an update soon. If the game is out of date you should update it now. But be aware that Europe/Asia receive the updates at later times than users in North America"
                    }), "MD5 Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            profile.SaveToFile();
            profile.ProfileActive = !profile.ProfileActive;
            this.timer_0_Tick(null, null);
            this.method_2();
            this.method_1();
            this.timer_0_Tick(null, null);
          
        }
            
		private void DeleteProfileBtn_Click(object sender, EventArgs e)
		{
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			if (profile == null)
			{
				return;
			}
			this.list_0.Remove(profile);
			if (!string.IsNullOrWhiteSpace(profile.LoadedFromFileName))
			{
				string path = Path.Combine(Profile.ProfileFolder, profile.LoadedFromFileName);
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			this.method_2();
			this.method_1();
		}
		private void BtnCheckForUpdate_Click(object sender, EventArgs e)
		{
			foreach (Profile current in this.list_0)
			{
				try
				{
					current.D3Process.Kill();
				}
				catch
				{
				}
			}
			try
			{
				Process.Start(Application.ExecutablePath, "-autologin");
				Environment.Exit(0);
			}
			catch
			{
			}
		}
		private void CheckBoxAutoLogin_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			profile.AutoLogin = this.CheckBoxAutoLogin.Checked;
			this.ProfileEmailBox.Enabled = this.CheckBoxAutoLogin.Checked;
			this.ProfilePasswordBox.Enabled = this.CheckBoxAutoLogin.Checked;
		}
		private void ProfileManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.method_3(null, null);
		}
		private void textBoxAdditionalParameters_TextChanged(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			profile.Parameters = this.textBoxAdditionalParameters.Text;
		}
		private void Schedule_UseScheduler_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			this.Schedule_Container.Enabled = this.Schedule_UseScheduler.Checked;
			profile.UseSchedule = this.Schedule_UseScheduler.Checked;
			profile.SaveToFile();
		}
		private void Schedule_Add_Click(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			TimeSpan timeOfDay = this.Schedule_StartTime.Value.TimeOfDay;
			TimeSpan timeOfDay2 = this.Schedule_StopTime.Value.TimeOfDay;
			if (timeOfDay2.TotalMilliseconds <= timeOfDay.TotalMilliseconds)
			{
				MessageBox.Show("Stop earlier than Start doesn't make sense.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Profile.Class1 @class = new Profile.Class1();
			@class.timeSpan_0 = timeOfDay;
			@class.timeSpan_1 = timeOfDay2;
			profile.Schedule.Add(@class);
			IEnumerable<Profile.Class1> arg_B0_0 = profile.Schedule;
			if (ProfileManager.func_1 == null)
			{
				ProfileManager.func_1 = new Func<Profile.Class1, TimeSpan>(ProfileManager.smethod_4);
			}
			arg_B0_0.OrderBy(ProfileManager.func_1);
			profile.SaveToFile();
			this.Schedule_ListBox.Items.Clear();
			this.Schedule_ListBox.Items.AddRange(profile.Schedule.ToArray());
		}
		private void Scheduler_DeleteEntry_Click(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			int selectedIndex = this.Schedule_ListBox.SelectedIndex;
			if (selectedIndex == -1)
			{
				return;
			}
			profile.Schedule.RemoveAt(selectedIndex);
			this.Schedule_ListBox.Items.RemoveAt(selectedIndex);
			profile.SaveToFile();
		}
		private void InfoLabel_MouseUp(object sender, MouseEventArgs e)
		{
			string string_ = LoginWindow.string_10;
			if (!Directory.Exists(string_))
			{
				Directory.CreateDirectory(string_);
			}
			string text = Path.Combine(string_, "Quests");
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			Process.Start("explorer.exe", text);
		}
		private void BtnRenameProfile_Click(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			StringQuery stringQuery = new StringQuery("Rename Profile", "Enter the new profile name:");
			if (stringQuery.ShowDialog() == DialogResult.OK)
			{
				string text = Path.Combine(Profile.ProfileFolder, Path.GetFileNameWithoutExtension(profile.ProfileName) + ".settings");
				profile.ProfileName = stringQuery.string_0;
				profile.SaveToFile();
				string destFileName = Path.Combine(Profile.ProfileFolder, Path.GetFileNameWithoutExtension(stringQuery.string_0) + ".settings");
				if (File.Exists(text))
				{
					File.Move(text, destFileName);
				}
				this.method_1();
			}
		}
		private void method_4(object sender, EventArgs e)
		{
		}
		private void ProfileManager_Shown(object sender, EventArgs e)
		{
			if (ProfileManager.threadStart_0 == null)
			{
				ProfileManager.threadStart_0 = new ThreadStart(ProfileManager.smethod_5);
			}
			new Thread(ProfileManager.threadStart_0).Start();
		}
		private string method_5()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Diablo III Main Executable|Diablo III.exe";
			DialogResult dialogResult = openFileDialog.ShowDialog();
			if (dialogResult != DialogResult.OK)
			{
				return "";
			}
			return openFileDialog.FileName;
		}
		private void D3PathBox_TextChanged(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			profile.D3Executable = this.D3PathBox.Text;
			profile.SaveToFile();
		}
		private void BtnSelectD3Exe_Click(object sender, EventArgs e)
		{
			string text = this.method_5();
			if (text.Length > 0)
			{
				this.D3PathBox.Text = text;
			}
		}
		private void NumericUpdown_ForceRestartMinutes_ValueChanged(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			profile.ForceRestartTimeoutMinutes = (int)this.NumericUpdown_ForceRestartMinutes.Value;
		}
		private void ProfileManager_Load(object sender, EventArgs e)
		{
		}
		private void CheckBoxKillErrorReporter_CheckedChanged(object sender, EventArgs e)
		{
		}
		private void Checkbox_AutoLogin_CheckedChanged(object sender, EventArgs e)
		{
			Settings.Default.TryAutoLogin = this.Checkbox_AutoLogin.Checked;
			Settings.Default.Save();
		}
		private void CheckBox_AutostartProfile_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			profile.AutoStartThisProfile = this.CheckBox_AutostartProfile.Checked;
			profile.SaveToFile();
		}
		private void ComboBox_RegionOverride_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.ProfileListBox.SelectedItem == null)
			{
				return;
			}
			Profile profile = this.ProfileListBox.SelectedItem as Profile;
			profile.Region = (Profile.RegionOverride)this.ComboBox_RegionOverride.SelectedIndex;
			profile.SaveToFile();
		}
		[CompilerGenerated]
		private void method_6()
		{
			int num = 2797;
			string text = Class4.smethod_2("SessionID");
			DateTime now = DateTime.Now;
			while (true)
			{
				try
				{
					TcpClient tcpClient = new TcpClient();
          if (tcpClient.smethod_7("1", num, 10000))// if (tcpClient.smethod_7("193.192.58.73", num, 10000))
					{
						NetworkStream stream = tcpClient.GetStream();
						stream.smethod_5(2);
						stream.smethod_3(text);
						int num2 = stream.smethod_4();
						stream.Close();
						if (num2 != 1)
						{
							break;
						}
						now = DateTime.Now;
						Thread.Sleep(TimeSpan.FromMinutes(2.0));
					}
					goto IL_AB;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Auth error: " + ex.Message, "error");
					goto IL_AB;
				}
				IL_9C:
				Thread.Sleep(5000);
				continue;
				IL_AB:
				if (DateTime.Now - now > TimeSpan.FromMinutes(10.0))
				{
					break;
				}
				goto IL_9C;
			}
			base.BeginInvoke(new MethodInvoker(this.method_7));
			TaskFactory arg_100_0 = Task.Factory;
			if (ProfileManager.action_0 == null)
			{
				ProfileManager.action_0 = new Action(ProfileManager.smethod_2);
			}
			arg_100_0.StartNew(ProfileManager.action_0);
		}
		[CompilerGenerated]
		private void method_7()
		{
			this.ProfileListBox.Enabled = false;
			this.StartStopBtn.Enabled = false;
			foreach (Profile current in this.list_0)
			{
				current.ProfileActive = false;
			}
		}
		[CompilerGenerated]
		private static void smethod_2()
		{
			MessageBox.Show("Your session expired.\r\n=> Someone else logged on with one or more keys you are using\r\n", "Session expired", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		[CompilerGenerated]
		private static TimeSpan smethod_3(Profile.Class1 class1_0)
		{
			return class1_0.timeSpan_0;
		}
		[CompilerGenerated]
		private static TimeSpan smethod_4(Profile.Class1 class1_0)
		{
			return class1_0.timeSpan_0;
		}
		[CompilerGenerated]
		private static void smethod_5()
		{
			string value = "wmic os get dataexecutionprevention_supportpolicy\nexit\n";
			Process process = new Process();
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.FileName = "cmd.exe";
			process.Start();
			process.StandardInput.WriteLine(value);
			string text = process.StandardOutput.ReadToEnd();
			int num = -1;
			string[] array = text.Split(new char[]
			{
				'\n'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string s = array[i];
				if (int.TryParse(s, out num))
				{
					break;
				}
			}
			if (num != 0 && num != 2)
			{
				MessageBox.Show("DEP (Data execution prevention) seems to be turned \"ON\" on your computer.\r\nYou should disable it before using the bot.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
	}
}
