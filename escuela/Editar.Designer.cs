namespace escuela
{
	partial class Editar
	{
		
		private System.ComponentModel.IContainer components = null;
		
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(171, 296);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(96, 31);
			this.btnGuardar.TabIndex = 9;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(12, 109);
			this.txtNombre.MaxLength = 256;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(255, 20);
			this.txtNombre.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Nombre";
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Location = new System.Drawing.Point(12, 243);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(253, 20);
			this.txtDomicilio.TabIndex = 13;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "Domicilio";
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(12, 167);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(253, 20);
			this.txtTel.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Tel";
			// 
			// Editar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 339);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Editar";
			this.Text = "Editar";
			this.Load += new System.EventHandler(this.EditarLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnGuardar;
	}
}

