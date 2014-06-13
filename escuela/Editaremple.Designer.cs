namespace escuela
{
	partial class Editaremple
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editaremple));
			this.txtDom = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTelef = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtDom
			// 
			this.txtDom.Location = new System.Drawing.Point(12, 236);
			this.txtDom.Name = "txtDom";
			this.txtDom.Size = new System.Drawing.Size(253, 20);
			this.txtDom.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 21;
			this.label4.Text = "Domicilio";
			// 
			// txtTelef
			// 
			this.txtTelef.Location = new System.Drawing.Point(12, 160);
			this.txtTelef.Name = "txtTelef";
			this.txtTelef.Size = new System.Drawing.Size(253, 20);
			this.txtTelef.TabIndex = 20;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 19;
			this.label3.Text = "Tel";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(171, 289);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(96, 31);
			this.btnGuardar.TabIndex = 18;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(12, 102);
			this.txtNom.MaxLength = 256;
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(255, 20);
			this.txtNom.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 16;
			this.label2.Text = "Nombre";
			// 
			// Editaremple
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 339);
			this.Controls.Add(this.txtDom);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTelef);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Editaremple";
			this.Text = "Editaremple";
			this.Load += new System.EventHandler(this.EditarLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTelef;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDom;
	}
}
