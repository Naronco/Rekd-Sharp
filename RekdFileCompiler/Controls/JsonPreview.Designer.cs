namespace RekdFileCompiler.Controls
{
	partial class JsonPreview
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
			this.codeLines = new System.Windows.Forms.RichTextBox();
			this.codePreview = new System.Windows.Forms.RichTextBox();
			this.title = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.zooms = new System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// codeLines
			// 
			this.codeLines.BackColor = System.Drawing.Color.WhiteSmoke;
			this.codeLines.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.codeLines.DetectUrls = false;
			this.codeLines.Dock = System.Windows.Forms.DockStyle.Fill;
			this.codeLines.Font = new System.Drawing.Font("Segoe UI Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.codeLines.ForeColor = System.Drawing.Color.DimGray;
			this.codeLines.Location = new System.Drawing.Point(0, 0);
			this.codeLines.Name = "codeLines";
			this.codeLines.ReadOnly = true;
			this.codeLines.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.codeLines.Size = new System.Drawing.Size(47, 466);
			this.codeLines.TabIndex = 4;
			this.codeLines.Text = "";
			// 
			// codePreview
			// 
			this.codePreview.BackColor = System.Drawing.Color.WhiteSmoke;
			this.codePreview.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.codePreview.DetectUrls = false;
			this.codePreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.codePreview.Font = new System.Drawing.Font("Segoe UI Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.codePreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.codePreview.Location = new System.Drawing.Point(47, 29);
			this.codePreview.Name = "codePreview";
			this.codePreview.ReadOnly = true;
			this.codePreview.Size = new System.Drawing.Size(569, 483);
			this.codePreview.TabIndex = 3;
			this.codePreview.Text = "";
			this.codePreview.WordWrap = false;
			this.codePreview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codePreview_KeyDown);
			this.codePreview.KeyUp += new System.Windows.Forms.KeyEventHandler(this.codePreview_KeyUp);
			// 
			// title
			// 
			this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.title.Dock = System.Windows.Forms.DockStyle.Top;
			this.title.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.title.Location = new System.Drawing.Point(0, 0);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(616, 29);
			this.title.TabIndex = 5;
			this.title.Text = "Preview";
			this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.codeLines);
			this.panel1.Controls.Add(this.zooms);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 29);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(47, 483);
			this.panel1.TabIndex = 6;
			// 
			// zooms
			// 
			this.zooms.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.zooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zooms.FormattingEnabled = true;
			this.zooms.Items.AddRange(new object[] {
            "50 %",
            "70 %",
            "90 %",
            "100 %",
            "110 %",
            "150 %",
            "200 %",
            "300 %",
            "400 %",
            "500 %"});
			this.zooms.Location = new System.Drawing.Point(0, 466);
			this.zooms.Margin = new System.Windows.Forms.Padding(0);
			this.zooms.Name = "zooms";
			this.zooms.Size = new System.Drawing.Size(47, 17);
			this.zooms.TabIndex = 0;
			this.zooms.Text = "100 %";
			this.zooms.SelectedIndexChanged += new System.EventHandler(this.zooms_SelectedIndexChanged);
			this.zooms.SelectionChangeCommitted += new System.EventHandler(this.zooms_SelectionChangeCommitted);
			this.zooms.Leave += new System.EventHandler(this.zooms_Leave);
			// 
			// JsonPreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.codePreview);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.title);
			this.Name = "JsonPreview";
			this.Size = new System.Drawing.Size(616, 512);
			this.Load += new System.EventHandler(this.JsonPreview_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox codeLines;
		private System.Windows.Forms.RichTextBox codePreview;
		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox zooms;
	}
}
