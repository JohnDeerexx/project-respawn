using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace ns1
{
	public class ActorListViewer : Form
	{
		private class Class69
		{
			[CompilerGenerated]
			private string string_0;
			[CompilerGenerated]
			private int int_0;
			[CompilerGenerated]
			private float float_0;
			public string modelname
			{
				get;
				private set;
			}
			public int modelid
			{
				get;
				private set;
			}
			public float distanceToChar
			{
				get;
				private set;
			}
			public Class69(string string_1, int int_1, float float_1)
			{
				this.modelname = string_1;
				this.modelid = int_1;
				this.distanceToChar = float_1;
			}
		}
		[CompilerGenerated]
		private sealed class Class70
		{
			public List<ActorListViewer.Class69> list_0;
			public ActorListViewer actorListViewer_0;
			public void method_0()
			{
				if (this.actorListViewer_0.bool_0)
				{
					List<D3Item> list = Framework.Hero.Inventory.ToList<D3Item>();
					string text = "";
					using (List<D3Item>.Enumerator enumerator = list.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							D3Item current = enumerator.Current;
							if (this.actorListViewer_0.bool_0)
							{
								if (current.IsBigItem)
								{
									text = ", BigItem";
								}
								else
								{
									text = ", SmallItem";
								}
							}
							this.list_0.Add(new ActorListViewer.Class69("{0} (guid: {1:X}, ptr: {2:X}{3})".smethod_3(new object[]
							{
								current.Modelname,
								current.GUID,
								current.Ptr,
								text
							}), (int)current.Sno, 0f));
						}
						return;
					}
				}
				List<D3Actor> list2 = Framework.Actors.ToList<D3Actor>();
				foreach (D3Actor current2 in list2)
				{
					this.list_0.Add(new ActorListViewer.Class69("{0} (guid: {1:X}, ptr: {2:X})".smethod_2(current2.Modelname, current2.Guid, current2._Ptr.ToInt32()), (int)current2.UInt32_0, current2.DistanceToHero()));
				}
			}
		}
		private IContainer icontainer_0 = null;
		private DataGridView dataGridView1;
		private Button BtnRefresh;
		private DataGridViewTextBoxColumn ModelName;
		private DataGridViewTextBoxColumn ModelID;
		private DataGridViewTextBoxColumn Distance;
		private bool bool_0 = false;
		public ActorListViewer(bool bool_1)
		{
			this.bool_0 = bool_1;
			this.InitializeComponent();
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
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			this.dataGridView1 = new DataGridView();
			this.BtnRefresh = new Button();
			this.ModelName = new DataGridViewTextBoxColumn();
			this.ModelID = new DataGridViewTextBoxColumn();
			this.Distance = new DataGridViewTextBoxColumn();
			((ISupportInitialize)this.dataGridView1).BeginInit();
			base.SuspendLayout();
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.WhiteSmoke;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.ModelName,
				this.ModelID,
				this.Distance
			});
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = SystemColors.Control;
			this.dataGridView1.Location = new Point(12, 12);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new Size(409, 319);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentDoubleClick += new DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
			this.dataGridView1.SortCompare += new DataGridViewSortCompareEventHandler(this.dataGridView1_SortCompare);
			this.BtnRefresh.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.BtnRefresh.Location = new Point(12, 340);
			this.BtnRefresh.Name = "BtnRefresh";
			this.BtnRefresh.Size = new Size(409, 23);
			this.BtnRefresh.TabIndex = 1;
			this.BtnRefresh.Text = "Refresh";
			this.BtnRefresh.UseVisualStyleBackColor = true;
			this.BtnRefresh.Click += new EventHandler(this.BtnRefresh_Click);
			this.ModelName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ModelName.HeaderText = "ModelName";
			this.ModelName.Name = "ModelName";
			this.ModelName.ReadOnly = true;
			this.ModelID.HeaderText = "ModelID";
			this.ModelID.Name = "ModelID";
			this.ModelID.ReadOnly = true;
			this.Distance.HeaderText = "Distance";
			this.Distance.Name = "Distance";
			this.Distance.ReadOnly = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(433, 375);
			base.Controls.Add(this.BtnRefresh);
			base.Controls.Add(this.dataGridView1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ActorListViewer";
			this.Text = "Unit List";
			base.Shown += new EventHandler(this.ActorListViewer_Shown);
			((ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
		}
		private void BtnRefresh_Click(object sender, EventArgs e)
		{
			Action action = null;
			ActorListViewer.Class70 @class = new ActorListViewer.Class70();
			@class.actorListViewer_0 = this;
			@class.list_0 = new List<ActorListViewer.Class69>();
			if (Framework.IsIngame)
			{
				if (action == null)
				{
					action = new Action(@class.method_0);
				}
				Framework.RunInD3ContextSynced(action);
			}
			else
			{
				@class.list_0.Add(new ActorListViewer.Class69("This feature only works when ingame!", 0, 0f));
			}
			this.dataGridView1.Rows.Clear();
			foreach (ActorListViewer.Class69 current in @class.list_0)
			{
				this.dataGridView1.Rows.Add(new object[]
				{
					current.modelname,
					"0x" + current.modelid.ToString("X"),
					current.distanceToChar.ToString("00.0")
				});
			}
			this.dataGridView1.Sort(this.dataGridView1.Columns[2], ListSortDirection.Ascending);
		}
		private void ActorListViewer_Shown(object sender, EventArgs e)
		{
			this.BtnRefresh_Click(null, null);
		}
		private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string string_ = null;
			try
			{
				string_ = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
			}
			catch
			{
				return;
			}
			AttributeViewer attributeViewer = new AttributeViewer(string_, this.bool_0);
			attributeViewer.Show();
		}
		private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (e.Column == this.dataGridView1.Columns[2])
			{
				string s = e.CellValue1.ToString();
				string s2 = e.CellValue2.ToString();
				float num = float.Parse(s, NumberStyles.Float);
				float num2 = float.Parse(s2, NumberStyles.Float);
				if (num < num2)
				{
					e.SortResult = -1;
				}
				else
				{
					if (num > num2)
					{
						e.SortResult = 1;
					}
					else
					{
						e.SortResult = 0;
					}
				}
				e.Handled = true;
			}
		}
	}
}
