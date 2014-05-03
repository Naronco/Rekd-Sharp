namespace RekdFileCompiler
{
	partial class AddShaderItem
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.type = new System.Windows.Forms.ComboBox();
			this.def = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Shader Variable Name:";
			// 
			// name
			// 
			this.name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.name.Location = new System.Drawing.Point(137, 12);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(280, 20);
			this.name.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Shader Variable Type:";
			// 
			// type
			// 
			this.type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.type.FormattingEnabled = true;
			this.type.Items.AddRange(new object[] {
            "String",
            "Texture",
            "Vector2",
            "Vector3",
            "Vector4",
            "Matrix3x3",
            "Matrix4x4",
            "Number"});
			this.type.Location = new System.Drawing.Point(137, 38);
			this.type.Name = "type";
			this.type.Size = new System.Drawing.Size(280, 21);
			this.type.TabIndex = 3;
			// 
			// def
			// 
			this.def.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.def.Location = new System.Drawing.Point(137, 65);
			this.def.Name = "def";
			this.def.Size = new System.Drawing.Size(280, 20);
			this.def.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Default Value:";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(12, 91);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(405, 52);
			this.button1.TabIndex = 6;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AddShaderItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 155);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.def);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.type);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.name);
			this.Controls.Add(this.label1);
			this.Name = "AddShaderItem";
			this.Text = "Add Shader Item";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox type;
		private System.Windows.Forms.TextBox def;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
	}
}