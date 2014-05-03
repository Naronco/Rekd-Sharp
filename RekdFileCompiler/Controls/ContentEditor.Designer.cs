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
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.direct3DPreview1 = new RekdFileCompiler.Controls.Direct3DPreview();
			this.panel3 = new System.Windows.Forms.Panel();
			this.shaderVariables = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.addWVP = new System.Windows.Forms.Button();
			this.addTexelSize = new System.Windows.Forms.Button();
			this.addTime = new System.Windows.Forms.Button();
			this.openFileControl2 = new RekdFileCompiler.Controls.OpenFileControl();
			this.runShaderButton = new System.Windows.Forms.Button();
			this.meshPage = new System.Windows.Forms.TabPage();
			this.openFileControl1 = new RekdFileCompiler.Controls.OpenFileControl();
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
			this.shaderPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.panel3.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.meshPage.SuspendLayout();
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
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// texturePage
			// 
			this.texturePage.Controls.Add(this.texDictionary);
			this.texturePage.Controls.Add(this.flowLayoutPanel2);
			this.texturePage.Location = new System.Drawing.Point(4, 22);
			this.texturePage.Name = "texturePage";
			this.texturePage.Padding = new System.Windows.Forms.Padding(3);
			this.texturePage.Size = new System.Drawing.Size(631, 268);
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
			this.texDictionary.Size = new System.Drawing.Size(625, 233);
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
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 236);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(625, 29);
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
			this.shaderPage.Controls.Add(this.splitContainer3);
			this.shaderPage.Location = new System.Drawing.Point(4, 22);
			this.shaderPage.Name = "shaderPage";
			this.shaderPage.Padding = new System.Windows.Forms.Padding(3);
			this.shaderPage.Size = new System.Drawing.Size(631, 268);
			this.shaderPage.TabIndex = 1;
			this.shaderPage.Text = "Shader";
			this.shaderPage.UseVisualStyleBackColor = true;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(3, 3);
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.direct3DPreview1);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.panel3);
			this.splitContainer3.Panel2.Controls.Add(this.runShaderButton);
			this.splitContainer3.Size = new System.Drawing.Size(625, 262);
			this.splitContainer3.SplitterDistance = 270;
			this.splitContainer3.TabIndex = 1;
			// 
			// direct3DPreview1
			// 
			this.direct3DPreview1.Content = null;
			this.direct3DPreview1.Device = null;
			this.direct3DPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.direct3DPreview1.Location = new System.Drawing.Point(0, 0);
			this.direct3DPreview1.Name = "direct3DPreview1";
			this.direct3DPreview1.Size = new System.Drawing.Size(270, 262);
			this.direct3DPreview1.spriteBatch = null;
			this.direct3DPreview1.TabIndex = 0;
			this.direct3DPreview1.Title = "DirectX Preview";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.shaderVariables);
			this.panel3.Controls.Add(this.flowLayoutPanel3);
			this.panel3.Controls.Add(this.openFileControl2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(351, 239);
			this.panel3.TabIndex = 6;
			// 
			// shaderVariables
			// 
			this.shaderVariables.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.shaderVariables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.shaderVariables.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shaderVariables.FullRowSelect = true;
			this.shaderVariables.GridLines = true;
			this.shaderVariables.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.shaderVariables.Location = new System.Drawing.Point(0, 24);
			this.shaderVariables.Name = "shaderVariables";
			this.shaderVariables.Size = new System.Drawing.Size(351, 186);
			this.shaderVariables.TabIndex = 1;
			this.shaderVariables.UseCompatibleStateImageBehavior = false;
			this.shaderVariables.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Type";
			this.columnHeader2.Width = 88;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Test Value";
			this.columnHeader3.Width = 160;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.button3);
			this.flowLayoutPanel3.Controls.Add(this.button4);
			this.flowLayoutPanel3.Controls.Add(this.addWVP);
			this.flowLayoutPanel3.Controls.Add(this.addTexelSize);
			this.flowLayoutPanel3.Controls.Add(this.addTime);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 210);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(351, 29);
			this.flowLayoutPanel3.TabIndex = 2;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(3, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(57, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "-";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(66, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(57, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "+";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// addWVP
			// 
			this.addWVP.Location = new System.Drawing.Point(129, 3);
			this.addWVP.Name = "addWVP";
			this.addWVP.Size = new System.Drawing.Size(57, 23);
			this.addWVP.TabIndex = 6;
			this.addWVP.Text = "+WVP";
			this.addWVP.UseVisualStyleBackColor = true;
			this.addWVP.Click += new System.EventHandler(this.addWVP_Click);
			// 
			// addTexelSize
			// 
			this.addTexelSize.Location = new System.Drawing.Point(192, 3);
			this.addTexelSize.Name = "addTexelSize";
			this.addTexelSize.Size = new System.Drawing.Size(57, 23);
			this.addTexelSize.TabIndex = 7;
			this.addTexelSize.Text = "+Texel";
			this.addTexelSize.UseVisualStyleBackColor = true;
			this.addTexelSize.Click += new System.EventHandler(this.addTexelSize_Click);
			// 
			// addTime
			// 
			this.addTime.Location = new System.Drawing.Point(255, 3);
			this.addTime.Name = "addTime";
			this.addTime.Size = new System.Drawing.Size(57, 23);
			this.addTime.TabIndex = 8;
			this.addTime.Text = "+Time";
			this.addTime.UseVisualStyleBackColor = true;
			this.addTime.Click += new System.EventHandler(this.addTime_Click);
			// 
			// openFileControl2
			// 
			this.openFileControl2.Dock = System.Windows.Forms.DockStyle.Top;
			this.openFileControl2.Filter = "Effect Files (*.fx)|*.fx";
			this.openFileControl2.Location = new System.Drawing.Point(0, 0);
			this.openFileControl2.Name = "openFileControl2";
			this.openFileControl2.Size = new System.Drawing.Size(351, 24);
			this.openFileControl2.TabIndex = 0;
			// 
			// runShaderButton
			// 
			this.runShaderButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.runShaderButton.Location = new System.Drawing.Point(0, 239);
			this.runShaderButton.Name = "runShaderButton";
			this.runShaderButton.Size = new System.Drawing.Size(351, 23);
			this.runShaderButton.TabIndex = 7;
			this.runShaderButton.Text = "Run";
			this.runShaderButton.UseVisualStyleBackColor = true;
			this.runShaderButton.Click += new System.EventHandler(this.runShaderButton_Click);
			// 
			// meshPage
			// 
			this.meshPage.Controls.Add(this.openFileControl1);
			this.meshPage.Location = new System.Drawing.Point(4, 22);
			this.meshPage.Name = "meshPage";
			this.meshPage.Padding = new System.Windows.Forms.Padding(3);
			this.meshPage.Size = new System.Drawing.Size(631, 268);
			this.meshPage.TabIndex = 2;
			this.meshPage.Text = "Mesh";
			this.meshPage.UseVisualStyleBackColor = true;
			// 
			// openFileControl1
			// 
			this.openFileControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.openFileControl1.Filter = "3D Meshes|*.obj; *.fbx; *.n3dm; *.n3dbm; *.x";
			this.openFileControl1.Location = new System.Drawing.Point(3, 3);
			this.openFileControl1.Name = "openFileControl1";
			this.openFileControl1.Size = new System.Drawing.Size(625, 24);
			this.openFileControl1.TabIndex = 0;
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
			this.shaderPage.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.flowLayoutPanel3.ResumeLayout(false);
			this.meshPage.ResumeLayout(false);
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
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button runShaderButton;
		private OpenFileControl openFileControl2;
		private OpenFileControl openFileControl1;
		private System.Windows.Forms.ListView shaderVariables;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button addWVP;
		private System.Windows.Forms.Button addTexelSize;
		private System.Windows.Forms.Button addTime;
		private Direct3DPreview direct3DPreview1;
	}
}
