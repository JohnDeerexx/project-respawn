using D3Core;
using D3Core.Classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
namespace ns1
{
	public class SelectTargetScene : Form
	{
		[CompilerGenerated]
		private sealed class Class78
		{
			private sealed class Class79
			{
				public SelectTargetScene.Class78 class78_0;
				public int int_0;
				public bool method_0(D3Actor d3Actor_0)
				{
					return (ulong)d3Actor_0.Guid == (ulong)((long)this.int_0);
				}
			}
			public string string_0;
			public void method_0()
			{
				SelectTargetScene.Class78.Class79 @class = new SelectTargetScene.Class78.Class79();
				@class.class78_0 = this;
				@class.int_0 = (int)Framework.LastHoverGUID;
				D3Actor d3Actor = Framework.Actors.FirstOrDefault(new Func<D3Actor, bool>(@class.method_0));
				if (d3Actor != null)
				{
					this.string_0 = d3Actor.Modelname;
				}
			}
		}
		[CompilerGenerated]
		private sealed class Class77
		{
			public D3Actor d3Actor_0;
			public void method_0()
			{
				float num = 3.40282347E+38f;
				foreach (D3Actor current in Framework.Actors)
				{
					if (current.IsD3Object && current.Guid != Framework.Hero.Guid && (current.Team == D3Team.HoverableNeutral || current.Team == D3Team.Friendly))
					{
						float num2 = current.DistanceToHero();
						if (num2 < num)
						{
							this.d3Actor_0 = current;
							num = num2;
						}
					}
				}
			}
		}
		private IContainer icontainer_0 = null;
		private Button okBtn;
		private Button cancelBtn;
		private Button setSceneBtn;
		private TextBox targetSceneBox;
		private Label label3;
		private Label label2;
		private Button nearestBtn;
		private Button hoverBtn;
		private TextBox targetActorBox;
		[CompilerGenerated]
		private string string_0;
		[CompilerGenerated]
		private string string_1;
		public string SceneName
		{
			get;
			set;
		}
		public string ActorName
		{
			get;
			set;
		}
		public SelectTargetScene()
		{
			this.InitializeComponent();
			this.targetSceneBox.Focus();
			this.SceneName = (this.ActorName = "");
			base.CancelButton = this.cancelBtn;
			base.AcceptButton = this.okBtn;
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
			this.okBtn = new Button();
			this.cancelBtn = new Button();
			this.setSceneBtn = new Button();
			this.targetActorBox = new TextBox();
			this.label3 = new Label();
			this.nearestBtn = new Button();
			this.label2 = new Label();
			this.hoverBtn = new Button();
			this.targetSceneBox = new TextBox();
			base.SuspendLayout();
			this.okBtn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.okBtn.DialogResult = DialogResult.OK;
			this.okBtn.Location = new Point(371, 77);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new Size(100, 23);
			this.okBtn.TabIndex = 0;
			this.okBtn.Text = "OK";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new EventHandler(this.okBtn_Click);
			this.cancelBtn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.cancelBtn.DialogResult = DialogResult.Cancel;
			this.cancelBtn.Location = new Point(265, 77);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new Size(100, 23);
			this.cancelBtn.TabIndex = 1;
			this.cancelBtn.Text = "Cancel";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.setSceneBtn.Location = new Point(335, 9);
			this.setSceneBtn.Name = "setSceneBtn";
			this.setSceneBtn.Size = new Size(132, 23);
			this.setSceneBtn.TabIndex = 2;
			this.setSceneBtn.Text = "\"Here\"";
			this.setSceneBtn.UseVisualStyleBackColor = true;
			this.setSceneBtn.Click += new EventHandler(this.setSceneBtn_Click);
			this.targetActorBox.Location = new Point(92, 41);
			this.targetActorBox.Name = "targetActorBox";
			this.targetActorBox.Size = new Size(237, 20);
			this.targetActorBox.TabIndex = 5;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(28, 44);
			this.label3.Name = "label3";
			this.label3.Size = new Size(58, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Unit name:";
			this.nearestBtn.Location = new Point(404, 38);
			this.nearestBtn.Name = "nearestBtn";
			this.nearestBtn.Size = new Size(63, 23);
			this.nearestBtn.TabIndex = 7;
			this.nearestBtn.Text = "Nearest";
			this.nearestBtn.UseVisualStyleBackColor = true;
			this.nearestBtn.Click += new EventHandler(this.nearestBtn_Click);
			this.label2.AutoSize = true;
			this.label2.Location = new Point(16, 15);
			this.label2.Name = "label2";
			this.label2.Size = new Size(70, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Scene name:";
			this.hoverBtn.Location = new Point(335, 38);
			this.hoverBtn.Name = "hoverBtn";
			this.hoverBtn.Size = new Size(63, 23);
			this.hoverBtn.TabIndex = 6;
			this.hoverBtn.Text = "Selected";
			this.hoverBtn.UseVisualStyleBackColor = true;
			this.hoverBtn.Click += new EventHandler(this.hoverBtn_Click);
			this.targetSceneBox.Location = new Point(92, 12);
			this.targetSceneBox.Name = "targetSceneBox";
			this.targetSceneBox.Size = new Size(237, 20);
			this.targetSceneBox.TabIndex = 1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(483, 112);
			base.Controls.Add(this.setSceneBtn);
			base.Controls.Add(this.targetActorBox);
			base.Controls.Add(this.cancelBtn);
			base.Controls.Add(this.nearestBtn);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.okBtn);
			base.Controls.Add(this.hoverBtn);
			base.Controls.Add(this.targetSceneBox);
			base.Controls.Add(this.label2);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SelectTargetScene";
			base.ShowInTaskbar = false;
			this.Text = "Dungeon";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}
		private void okBtn_Click(object sender, EventArgs e)
		{
			this.SceneName = this.targetSceneBox.Text;
			this.ActorName = this.targetActorBox.Text;
			base.DialogResult = DialogResult.OK;
		}
		private void setSceneBtn_Click(object sender, EventArgs e)
		{
			this.targetSceneBox.Text = Framework.Scene;
		}
		private void hoverBtn_Click(object sender, EventArgs e)
		{
			SelectTargetScene.Class78 @class = new SelectTargetScene.Class78();
			@class.string_0 = "";
			Framework.RunInD3ContextSynced(new Action(@class.method_0));
		}
		private void nearestBtn_Click(object sender, EventArgs e)
		{
			SelectTargetScene.Class77 @class = new SelectTargetScene.Class77();
			@class.d3Actor_0 = null;
			Framework.RunInD3ContextSynced(new Action(@class.method_0));
			if (@class.d3Actor_0 != null)
			{
				this.targetActorBox.Text = @class.d3Actor_0.Modelname.smethod_4(0, @class.d3Actor_0.Modelname.IndexOf('-'));
			}
		}
	}
}
