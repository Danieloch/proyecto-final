namespace escuela
{
	partial class Nuevo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo));
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(12, 57);
			this.txtNombre.MaxLength = 256;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(255, 20);
			this.txtNombre.TabIndex = 3;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(169, 257);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(96, 31);
			this.btnGuardar.TabIndex = 4;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Tel";
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(12, 127);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(253, 20);
			this.txtTel.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 165);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Domicilio";
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Location = new System.Drawing.Point(12, 203);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(253, 20);
			this.txtDomicilio.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(12, 259);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 27);
			this.button1.TabIndex = 9;
			this.button1.Text = "Limpiar registros";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Nuevo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 313);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Nuevo";
			this.Text = "Nuevo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
	}
}
