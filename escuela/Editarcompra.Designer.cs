/*
 * Creado por SharpDevelop.
 * Usuario: DANIEL
 * Fecha: 12/06/2014
 * Hora: 10:23 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace escuela
{
	partial class Editarcompra
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editarcompra));
			this.txtproducto = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtproducto
			// 
			this.txtproducto.Location = new System.Drawing.Point(15, 109);
			this.txtproducto.Name = "txtproducto";
			this.txtproducto.Size = new System.Drawing.Size(253, 20);
			this.txtproducto.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(15, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Estado de producto";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(174, 162);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(96, 31);
			this.btnGuardar.TabIndex = 14;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// Editarcompra
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.txtproducto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnGuardar);
			this.Name = "Editarcompra";
			this.Text = "Editarcompra";
			this.Load += new System.EventHandler(this.EditarLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtproducto;
	}
}
