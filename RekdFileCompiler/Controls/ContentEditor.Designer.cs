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
			this.jsonPreview = new RekdFileCompiler.Controls.JsonPreview();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.props = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.texturePage = new System.Windows.Forms.TabPage();
			this.texDictionary = new System.Windows.Forms.ListView();
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.texName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.texPath = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.shaderPage = new System.Windows.Forms.TabPage();
			this.meshPage = new System.Windows.Forms.TabPage();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.meshPath = new System.Windows.Forms.TextBox();
			this.loadMeshFileButton = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.exportBtn = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.texturePage.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.meshPage.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
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
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Panel2.Text = "CustomComboBox Enabled";
			this.splitContainer1.Size = new System.Drawing.Size(1018, 652);
			this.splitContainer1.SplitterDistance = 375;
			this.splitContainer1.TabIndex = 1;
			// 
			// jsonPreview
			// 
			this.jsonPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.jsonPreview.Location = new System.Drawing.Point(0, 0);
			this.jsonPreview.Name = "jsonPreview";
			this.jsonPreview.Size = new System.Drawing.Size(375, 652);
			this.jsonPreview.TabIndex = 0;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.props);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.panel1);
			this.splitContainer2.Size = new System.Drawing.Size(639, 621);
			this.splitContainer2.SplitterDistance = 323;
			this.splitContainer2.TabIndex = 7;
			// 
			// props
			// 
			this.props.AutoScroll = true;
			this.props.Dock = System.Windows.Forms.DockStyle.Fill;
			this.props.Location = new System.Drawing.Point(0, 0);
			this.props.Name = "props";
			this.props.Size = new System.Drawing.Size(639, 323);
			this.props.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(639, 294);
			this.panel1.TabIndex = 6;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.texturePage);
			this.tabControl1.Controls.Add(this.shaderPage);
			this.tabControl1.Controls.Add(this.meshPage);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(639, 294);
			this.tabControl1.TabIndex = 0;
			// 
			// texturePage
			// 
			this.texturePage.Controls.Add(this.texDictionary);
			this.texturePage.Controls.Add(this.flowLayoutPanel2);
			this.texturePage.Location = new System.Drawing.Point(4, 22);
			this.texturePage.Name = "texturePage";
			this.texturePage.Padding = new System.Windows.Forms.Padding(3);
			this.texturePage.Size = new System.Drawing.Size(667, 241);
			this.texturePage.TabIndex = 0;
			this.texturePage.Text = "Texture";
			this.texturePage.UseVisualStyleBackColor = true;
			// 
			// texDictionary
			// 
			this.texDictionary.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.texDictionary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chPath});
			this.texDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
			this.texDictionary.FullRowSelect = true;
			this.texDictionary.GridLines = true;
			this.texDictionary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.texDictionary.Location = new System.Drawing.Point(3, 3);
			this.texDictionary.Name = "texDictionary";
			this.texDictionary.Size = new System.Drawing.Size(661, 206);
			this.texDictionary.TabIndex = 0;
			this.texDictionary.UseCompatibleStateImageBehavior = false;
			this.texDictionary.View = System.Windows.Forms.View.Details;
			// 
			// chName
			// 
			this.chName.Text = "Name";
			this.chName.Width = 244;
			// 
			// chPath
			// 
			this.chPath.Text = "Path";
			this.chPath.Width = 303;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.button2);
			this.flowLayoutPanel2.Controls.Add(this.texName);
			this.flowLayoutPanel2.Controls.Add(this.label1);
			this.flowLayoutPanel2.Controls.Add(this.texPath);
			this.flowLayoutPanel2.Controls.Add(this.button1);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 209);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(661, 29);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(48, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "-";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// texName
			// 
			this.texName.Location = new System.Drawing.Point(57, 3);
			this.texName.Name = "texName";
			this.texName.Size = new System.Drawing.Size(100, 20);
			this.texName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(163, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = ":";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// texPath
			// 
			this.texPath.Location = new System.Drawing.Point(179, 3);
			this.texPath.Name = "texPath";
			this.texPath.Size = new System.Drawing.Size(100, 20);
			this.texPath.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(285, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "+";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// shaderPage
			// 
			this.shaderPage.Location = new System.Drawing.Point(4, 22);
			this.shaderPage.Name = "shaderPage";
			this.shaderPage.Padding = new System.Windows.Forms.Padding(3);
			this.shaderPage.Size = new System.Drawing.Size(667, 241);
			this.shaderPage.TabIndex = 1;
			this.shaderPage.Text = "Shader";
			this.shaderPage.UseVisualStyleBackColor = true;
			// 
			// meshPage
			// 
			this.meshPage.Controls.Add(this.flowLayoutPanel3);
			this.meshPage.Location = new System.Drawing.Point(4, 22);
			this.meshPage.Name = "meshPage";
			this.meshPage.Padding = new System.Windows.Forms.Padding(3);
			this.meshPage.Size = new System.Drawing.Size(631, 268);
			this.meshPage.TabIndex = 2;
			this.meshPage.Text = "Mesh";
			this.meshPage.UseVisualStyleBackColor = true;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.meshPath);
			this.flowLayoutPanel3.Controls.Add(this.loadMeshFileButton);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel3.Size = new System.Drawing.Size(625, 31);
			this.flowLayoutPanel3.TabIndex = 3;
			// 
			// meshPath
			// 
			this.meshPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.meshPath.Location = new System.Drawing.Point(3, 5);
			this.meshPath.Name = "meshPath";
			this.meshPath.Size = new System.Drawing.Size(566, 20);
			this.meshPath.TabIndex = 1;
			// 
			// loadMeshFileButton
			// 
			this.loadMeshFileButton.Location = new System.Drawing.Point(575, 5);
			this.loadMeshFileButton.Name = "loadMeshFileButton";
			this.loadMeshFileButton.Size = new System.Drawing.Size(45, 23);
			this.loadMeshFileButton.TabIndex = 0;
			this.loadMeshFileButton.Text = "...";
			this.loadMeshFileButton.UseVisualStyleBackColor = true;
			this.loadMeshFileButton.Click += new System.EventHandler(this.loadMeshFileButton_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.exportBtn);
			this.panel2.Controls.Add(this.flowLayoutPanel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 621);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 5);
			this.panel2.Size = new System.Drawing.Size(639, 31);
			this.panel2.TabIndex = 4;
			// 
			// exportBtn
			// 
			this.exportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.exportBtn.Location = new System.Drawing.Point(227, 0);
			this.exportBtn.Name = "exportBtn";
			this.exportBtn.Size = new System.Drawing.Size(407, 26);
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
			// ContentEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "ContentEditor";
			this.Size = new System.Drawing.Size(1018, 652);
			this.Load += new System.EventHandler(this.ContentEditor_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.texturePage.ResumeLayout(false);
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.meshPage.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
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
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage texturePage;
		private System.Windows.Forms.TabPage shaderPage;
		private System.Windows.Forms.TabPage meshPage;
		private System.Windows.Forms.ListView texDictionary;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chPath;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox texName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox texPath;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.TextBox meshPath;
		private System.Windows.Forms.Button loadMeshFileButton;
	}
}
