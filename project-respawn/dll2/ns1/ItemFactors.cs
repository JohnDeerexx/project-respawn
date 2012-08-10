using D3Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace ns1
{
	public class ItemFactors : Form
	{
		private string string_0;
		private Class71 class71_0;
		private IContainer icontainer_0 = null;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Column1;
		private DataGridViewTextBoxColumn Column2;
		private Label label1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label3;
		private Button button1;
		internal ItemFactors(Class71 class71_1)
		{
			this.class71_0 = class71_1;
			this.InitializeComponent();
			if (class71_1.CustomItemFactors == null)
			{
				class71_1.CustomItemFactors = new Dictionary<D3Attribute, float>();
			}
			foreach (D3Attribute d3Attribute in Enum.GetValues(typeof(D3Attribute)))
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				float num = 0f;
				if (!class71_1.CustomItemFactors.TryGetValue(d3Attribute, out num))
				{
					num = 0f;
				}
				dataGridViewRow.CreateCells(this.dataGridView1, new object[]
				{
					d3Attribute.ToString(),
					num
				});
				dataGridViewRow.Tag = d3Attribute;
				this.dataGridView1.Rows.Add(dataGridViewRow);
			}
			this.textBox1.Text = class71_1.CustomItemFactors_MinimumValue.ToString();
			this.textBox2.Text = class71_1.CustomItemFactors_MaximumValue.ToString();
		}
		private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			this.string_0 = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
		}
		private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewCell dataGridViewCell = this.dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
			string s = dataGridViewCell.FormattedValue.ToString();
			int num = 0;
			if (!int.TryParse(s, out num))
			{
				dataGridViewCell.Value = this.string_0;
			}
			else
			{
				dataGridViewCell.Value = num.ToString();
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			float customItemFactors_MinimumValue;
			float customItemFactors_MaximumValue;
			if (!float.TryParse(this.textBox1.Text, out customItemFactors_MinimumValue) || !float.TryParse(this.textBox2.Text, out customItemFactors_MaximumValue))
			{
				MessageBox.Show("Minimum / maximum does not have a valid value!");
			}
			else
			{
				this.class71_0.CustomItemFactors_MinimumValue = customItemFactors_MinimumValue;
				this.class71_0.CustomItemFactors_MaximumValue = customItemFactors_MaximumValue;
				this.class71_0.CustomItemFactors.Clear();
				for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
				{
					D3Attribute key = (D3Attribute)this.dataGridView1.Rows[i].Tag;
					float num = float.Parse(this.dataGridView1.Rows[i].Cells[1].FormattedValue.ToString());
					if (num != 0f)
					{
						this.class71_0.CustomItemFactors[key] = num;
					}
				}
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
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
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.dataGridView1 = new DataGridView();
			this.Column1 = new DataGridViewTextBoxColumn();
			this.Column2 = new DataGridViewTextBoxColumn();
			this.label1 = new Label();
			this.textBox1 = new TextBox();
			this.textBox2 = new TextBox();
			this.label3 = new Label();
			this.button1 = new Button();
			((ISupportInitialize)this.dataGridView1).BeginInit();
			base.SuspendLayout();
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.GhostWhite;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
			this.dataGridView1.BorderStyle = BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeight = 24;
			this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.Column1,
				this.Column2
			});
			this.dataGridView1.EnableHeadersVisualStyles = false;
			this.dataGridView1.GridColor = Color.Gainsboro;
			this.dataGridView1.Location = new Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.ScrollBars = ScrollBars.Vertical;
			this.dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new Size(414, 408);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellBeginEdit += new DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
			this.dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
			this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "Attribute";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column2.HeaderText = "Factor";
			this.Column2.MinimumWidth = 60;
			this.Column2.Name = "Column2";
			this.label1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(12, 429);
			this.label1.Name = "label1";
			this.label1.Size = new Size(82, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Min/Max Value:";
			this.textBox1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.textBox1.Location = new Point(146, 426);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new Size(137, 20);
			this.textBox1.TabIndex = 2;
			this.textBox1.Text = "0";
			this.textBox2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.textBox2.Location = new Point(289, 426);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new Size(137, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "999999";
			this.label3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label3.ForeColor = SystemColors.ControlDarkDark;
			this.label3.Location = new Point(12, 449);
			this.label3.Name = "label3";
			this.label3.Size = new Size(305, 66);
			this.label3.TabIndex = 5;
			this.label3.Text = "If an item is under the minimum value, the bot won't pick it up.\r\nIf the items value exceeds the maximum he will always pick\r\nit up and never salvage or sell it.";
			this.button1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button1.Location = new Point(323, 480);
			this.button1.Name = "button1";
			this.button1.Size = new Size(103, 32);
			this.button1.TabIndex = 9;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(438, 524);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.dataGridView1);
			base.MaximizeBox = false;
			this.MaximumSize = new Size(600, 800);
			base.MinimizeBox = false;
			this.MinimumSize = new Size(410, 300);
			base.Name = "ItemFactors";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Item Factors";
			base.TopMost = true;
			((ISupportInitialize)this.dataGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
