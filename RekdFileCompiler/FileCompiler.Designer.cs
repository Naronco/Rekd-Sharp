namespace RekdFileCompiler
{
	partial class FileCompiler
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

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.fileViewer = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.contentEditor1 = new RekdFileCompiler.Controls.ContentEditor();
			this.fileViewer.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1022, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// fileViewer
			// 
			this.fileViewer.Controls.Add(this.tabPage1);
			this.fileViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileViewer.Location = new System.Drawing.Point(0, 25);
			this.fileViewer.Name = "fileViewer";
			this.fileViewer.SelectedIndex = 0;
			this.fileViewer.Size = new System.Drawing.Size(1022, 567);
			this.fileViewer.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.contentEditor1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1014, 541);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "CustomContent1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// contentEditor1
			// 
			this.contentEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.contentEditor1.Location = new System.Drawing.Point(0, 0);
			this.contentEditor1.Name = "contentEditor1";
			this.contentEditor1.Size = new System.Drawing.Size(1014, 541);
			this.contentEditor1.TabIndex = 0;
			// 
			// FileCompiler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1022, 592);
			this.Controls.Add(this.fileViewer);
			this.Controls.Add(this.toolStrip1);
			this.Name = "FileCompiler";
			this.Text = "Rekd File Compiler";
			this.Load += new System.EventHandler(this.FileCompiler_Load);
			this.fileViewer.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TabControl fileViewer;
		private System.Windows.Forms.TabPage tabPage1;
		private Controls.ContentEditor contentEditor1;

	}
}

