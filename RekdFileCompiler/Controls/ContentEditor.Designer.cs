namespace RekdFileCompiler.Controls
{
	partial class ContentEditor
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Komponenten-Designer generierter Code

		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.props = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.exportBtn = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.jsonPreview = new RekdFileCompiler.Controls.JsonPreview();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.White;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.jsonPreview);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
			this.splitContainer1.Panel2.Controls.Add(this.props);
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Panel2.Text = "CustomComboBox Enabled";
			this.splitContainer1.Size = new System.Drawing.Size(705, 396);
			this.splitContainer1.SplitterDistance = 235;
			this.splitContainer1.TabIndex = 1;
			// 
			// props
			// 
			this.props.AutoScroll = true;
			this.props.Dock = System.Windows.Forms.DockStyle.Fill;
			this.props.Location = new System.Drawing.Point(0, 0);
			this.props.Name = "props";
			this.props.Size = new System.Drawing.Size(466, 365);
			this.props.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.exportBtn);
			this.panel2.Controls.Add(this.flowLayoutPanel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 365);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
			this.panel2.Size = new System.Drawing.Size(466, 31);
			this.panel2.TabIndex = 4;
			// 
			// exportBtn
			// 
			this.exportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.exportBtn.Location = new System.Drawing.Point(227, 0);
			this.exportBtn.Name = "exportBtn";
			this.exportBtn.Size = new System.Drawing.Size(234, 26);
			this.exportBtn.TabIndex = 3;
			this.exportBtn.Text = "Export";
			this.exportBtn.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBox2);
			this.flowLayoutPanel1.Controls.Add(this.checkBox1);
			this.flowLayoutPanel1.Controls.Add(this.checkBox3);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(227, 26);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(3, 5);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(55, 17);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "Binary";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(64, 5);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(53, 17);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "Minify";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(123, 5);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(101, 17);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "Embed Shaders";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// jsonPreview
			// 
			this.jsonPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.jsonPreview.Location = new System.Drawing.Point(0, 0);
			this.jsonPreview.Name = "jsonPreview";
			this.jsonPreview.Size = new System.Drawing.Size(235, 396);
			this.jsonPreview.TabIndex = 0;
			// 
			// ContentEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "ContentEditor";
			this.Size = new System.Drawing.Size(705, 396);
			this.Load += new System.EventHandler(this.ContentEditor_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private JsonPreview jsonPreview;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button exportBtn;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Panel props;
	}
}
