/*
 * Creado por SharpDevelop.
 * Usuario: DANIEL
 * Fecha: 01/06/2014
 * Hora: 01:26 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace escuela
{
	partial class Nuevoemple
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevoemple));
			this.button1 = new System.Windows.Forms.Button();
			this.txtDomicilio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(35, 306);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 27);
			this.button1.TabIndex = 19;
			this.button1.Text = "Limpiar registros";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtDomicilio
			// 
			this.txtDomicilio.Location = new System.Drawing.Point(10, 262);
			this.txtDomicilio.Name = "txtDomicilio";
			this.txtDomicilio.Size = new System.Drawing.Size(253, 20);
			this.txtDomicilio.TabIndex = 18;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 17;
			this.label4.Text = "Domicilio";
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(10, 186);
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(253, 20);
			this.txtTel.TabIndex = 16;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Tel";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(179, 306);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(96, 31);
			this.btnGuardar.TabIndex = 14;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(10, 116);
			this.txtNombre.MaxLength = 256;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(255, 20);
			this.txtNombre.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 12;
			this.label2.Text = "Nombre";
			// 
			// Nuevoemple
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 359);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtDomicilio);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Nuevoemple";
			this.Text = "Nuevoemple";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDomicilio;
		private System.Windows.Forms.Button button1;
	}
}
