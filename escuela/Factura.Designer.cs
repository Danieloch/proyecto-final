/*
 * Created by SharpDevelop.
 * User: DANIEL
 * Date: 25/05/2014
 * Time: 05:46 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace escuela
{
	partial class Factura
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtid = new System.Windows.Forms.TextBox();
			this.txtcomp = new System.Windows.Forms.TextBox();
			this.txtvend = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.txttipo = new System.Windows.Forms.ComboBox();
			this.txtfech = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.txtestado = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID_producto";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Comprador";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Vendedor";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Fecha";
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(93, 12);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(100, 20);
			this.txtid.TabIndex = 4;
			// 
			// txtcomp
			// 
			this.txtcomp.Location = new System.Drawing.Point(93, 51);
			this.txtcomp.Name = "txtcomp";
			this.txtcomp.Size = new System.Drawing.Size(100, 20);
			this.txtcomp.TabIndex = 5;
			// 
			// txtvend
			// 
			this.txtvend.Location = new System.Drawing.Point(93, 96);
			this.txtvend.Name = "txtvend";
			this.txtvend.Size = new System.Drawing.Size(100, 20);
			this.txtvend.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(214, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Tipo_producto";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(329, 249);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 16;
			this.button1.Text = "Enviar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(199, 249);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 17;
			this.button2.Text = "Limpiar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// txttipo
			// 
			this.txttipo.FormattingEnabled = true;
			this.txttipo.Items.AddRange(new object[] {
									"Sillas",
									"Escritorios",
									"Lockers"});
			this.txttipo.Location = new System.Drawing.Point(306, 12);
			this.txttipo.Name = "txttipo";
			this.txttipo.Size = new System.Drawing.Size(121, 21);
			this.txttipo.TabIndex = 20;
			this.txttipo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// txtfech
			// 
			this.txtfech.Location = new System.Drawing.Point(93, 139);
			this.txtfech.Name = "txtfech";
			this.txtfech.Size = new System.Drawing.Size(200, 20);
			this.txtfech.TabIndex = 22;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(214, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 23;
			this.label6.Text = "Estado de producto";
			// 
			// txtestado
			// 
			this.txtestado.Location = new System.Drawing.Point(320, 51);
			this.txtestado.Name = "txtestado";
			this.txtestado.Size = new System.Drawing.Size(100, 20);
			this.txtestado.TabIndex = 24;
			// 
			// Factura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 284);
			this.Controls.Add(this.txtestado);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtfech);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txttipo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtvend);
			this.Controls.Add(this.txtcomp);
			this.Controls.Add(this.txtid);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Factura";
			this.Text = "Factura";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtestado;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker txtfech;
		private System.Windows.Forms.ComboBox txttipo;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtvend;
		private System.Windows.Forms.TextBox txtcomp;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
