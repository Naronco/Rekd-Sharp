namespace RekdFileCompiler.Controls
{
	partial class OpenFileControl
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
			this.browseButton = new System.Windows.Forms.Button();
			this.fileName = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// browseButton
			// 
			this.browseButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.browseButton.Location = new System.Drawing.Point(149, 0);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(66, 24);
			this.browseButton.TabIndex = 0;
			this.browseButton.Text = "...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
			// 
			// fileName
			// 
			this.fileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fileName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileName.Location = new System.Drawing.Point(0, 0);
			this.fileName.Name = "fileName";
			this.fileName.ReadOnly = true;
			this.fileName.Size = new System.Drawing.Size(149, 24);
			this.fileName.TabIndex = 1;
			this.fileName.Text = "";
			// 
			// OpenFileControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.fileName);
			this.Controls.Add(this.browseButton);
			this.Name = "OpenFileControl";
			this.Size = new System.Drawing.Size(215, 24);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.RichTextBox fileName;
	}
}
