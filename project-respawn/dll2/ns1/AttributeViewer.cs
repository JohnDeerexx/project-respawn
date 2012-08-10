using D3Core;
using D3Core.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace ns1
{
	public class AttributeViewer : Form
	{
		private class Class68
		{
			[CompilerGenerated]
			private string string_0;
			[CompilerGenerated]
			private D3Attribute d3Attribute_0;
			[CompilerGenerated]
			private int int_0;
			[CompilerGenerated]
			private float float_0;
			public string Name
			{
				get;
				set;
			}
			public D3Attribute Attribute
			{
				get;
				set;
			}
			public int ValueI
			{
				get;
				set;
			}
			public float ValueF
			{
				get;
				set;
			}
		}
		[CompilerGenerated]
		private sealed class Class67
		{
			public List<AttributeViewer.Class68> list_0;
			public string string_0;
			public AttributeViewer attributeViewer_0;
			public void method_0()
			{
				Func<D3Item, bool> func = null;
				Func<D3Actor, bool> func2 = null;
				try
				{
					if (this.attributeViewer_0.bool_0)
					{
						IEnumerable<D3Item> arg_32_0 = Framework.Hero.Inventory;
						if (func == null)
						{
							func = new Func<D3Item, bool>(this.method_1);
						}
						D3Item d3Item = arg_32_0.FirstOrDefault(func);
						if (d3Item == null)
						{
							return;
						}
						using (List<AttributeViewer.Class68>.Enumerator enumerator = this.list_0.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								AttributeViewer.Class68 current = enumerator.Current;
								current.ValueI = d3Item.GetInt(current.Attribute);
								current.ValueF = d3Item.GetFloat(current.Attribute);
							}
							goto IL_126;
						}
					}
					IEnumerable<D3Actor> arg_B8_0 = Framework.Actors;
					if (func2 == null)
					{
						func2 = new Func<D3Actor, bool>(this.method_2);
					}
					D3Actor d3Actor = arg_B8_0.FirstOrDefault(func2);
					if (d3Actor != null)
					{
						foreach (AttributeViewer.Class68 current in this.list_0)
						{
							current.ValueI = d3Actor.GetInt(current.Attribute);
							current.ValueF = d3Actor.GetFloat(current.Attribute);
						}
					}
					IL_126:;
				}
				catch (Exception ex)
				{
					this.string_0 = ex.Message;
				}
			}
			private bool method_1(D3Item d3Item_0)
			{
				return d3Item_0.Modelname == this.attributeViewer_0.string_0;
			}
			private bool method_2(D3Actor d3Actor_0)
			{
				return d3Actor_0.Modelname == this.attributeViewer_0.string_0;
			}
		}
		private IContainer icontainer_0 = null;
		private DataGridView dataGridView1;
		private Label label1;
		private DataGridViewTextBoxColumn Stat;
		private DataGridViewTextBoxColumn ValueI;
		private DataGridViewTextBoxColumn ValueF;
		private bool bool_0;
		private string string_0;
		public AttributeViewer(string string_1, bool bool_1)
		{
			this.InitializeComponent();
			this.bool_0 = bool_1;
			if (string_1.Contains('('))
			{
				this.string_0 = string_1.smethod_4(0, string_1.IndexOf('(')).Trim();
			}
			this.label1.Text = "";
			Label expr_57 = this.label1;
			expr_57.Text = expr_57.Text + "Unit: " + this.string_0 + "\r\n";
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
			this.Stat = new DataGridViewTextBoxColumn();
			this.ValueI = new DataGridViewTextBoxColumn();
			this.ValueF = new DataGridViewTextBoxColumn();
			this.label1 = new Label();
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
				this.Stat,
				this.ValueI,
				this.ValueF
			});
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = SystemColors.Control;
			this.dataGridView1.Location = new Point(12, 39);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new Size(480, 408);
			this.dataGridView1.TabIndex = 1;
			this.Stat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.Stat.HeaderText = "Stat";
			this.Stat.Name = "Stat";
			this.Stat.ReadOnly = true;
			this.ValueI.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ValueI.HeaderText = "Value(I)";
			this.ValueI.Name = "ValueI";
			this.ValueI.ReadOnly = true;
			this.ValueF.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.ValueF.HeaderText = "Value(F)";
			this.ValueF.Name = "ValueF";
			this.ValueF.ReadOnly = true;
			this.label1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.label1.BorderStyle = BorderStyle.FixedSingle;
			this.label1.Location = new Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Padding = new Padding(6);
			this.label1.Size = new Size(480, 27);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(504, 459);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.dataGridView1);
			base.Name = "AttributeViewer";
			this.Text = "AttributeViewer";
			base.Shown += new EventHandler(this.AttributeViewer_Shown);
			((ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
		}
		private void AttributeViewer_Shown(object sender, EventArgs e)
		{
			AttributeViewer.Class67 @class = new AttributeViewer.Class67();
			@class.attributeViewer_0 = this;
			@class.list_0 = new List<AttributeViewer.Class68>();
			foreach (D3Attribute d3Attribute in Enum.GetValues(typeof(D3Attribute)))
			{
				AttributeViewer.Class68 class2 = new AttributeViewer.Class68();
				class2.Attribute = d3Attribute;
				class2.Name = d3Attribute.ToString();
				@class.list_0.Add(class2);
			}
			@class.string_0 = null;
			Framework.RunInD3ContextSynced(new Action(@class.method_0));
			if (@class.string_0 == null)
			{
				using (List<AttributeViewer.Class68>.Enumerator enumerator2 = @class.list_0.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						AttributeViewer.Class68 current = enumerator2.Current;
						if ((current.ValueF != 0f || current.ValueI != 0) && (current.ValueI != -1 || !float.IsNaN(current.ValueF)))
						{
							this.dataGridView1.Rows.Add(new object[]
							{
								current.Name,
								current.ValueI,
								current.ValueF
							});
						}
					}
					return;
				}
			}
			this.dataGridView1.Rows.Add(new object[]
			{
				"Exception: " + @class.string_0
			});
		}
	}
}
