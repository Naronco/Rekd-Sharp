namespace RekdFileCompiler.Controls
{
	partial class Direct3DPreview
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
			this.label1 = new System.Windows.Forms.Label();
			this.dxViewport = new SharpDX.Windows.RenderControl();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(268, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "DirectX Preview";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dxViewport
			// 
			this.dxViewport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dxViewport.Location = new System.Drawing.Point(0, 29);
			this.dxViewport.Name = "dxViewport";
			this.dxViewport.Size = new System.Drawing.Size(268, 216);
			this.dxViewport.TabIndex = 1;
			this.dxViewport.Resize += new System.EventHandler(this.dxViewport_Resize);
			// 
			// Direct3DPreview
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dxViewport);
			this.Controls.Add(this.label1);
			this.Name = "Direct3DPreview";
			this.Size = new System.Drawing.Size(268, 245);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private SharpDX.Windows.RenderControl dxViewport;
	}
}
