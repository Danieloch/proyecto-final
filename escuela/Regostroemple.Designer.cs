
 
namespace escuela
{
	partial class Registroemple
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registroemple));
			this.myDataGrid = new System.Windows.Forms.DataGridView();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// myDataGrid
			// 
			this.myDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.myDataGrid.Location = new System.Drawing.Point(12, 78);
			this.myDataGrid.MultiSelect = false;
			this.myDataGrid.Name = "myDataGrid";
			this.myDataGrid.ReadOnly = true;
			this.myDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.myDataGrid.Size = new System.Drawing.Size(591, 334);
			this.myDataGrid.TabIndex = 0;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(505, 32);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(98, 40);
			this.btnAgregar.TabIndex = 1;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(403, 418);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(97, 39);
			this.btnEditar.TabIndex = 2;
			this.btnEditar.Text = "Editar";
			this.btnEditar.UseVisualStyleBackColor = true;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(506, 418);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(98, 39);
			this.btnEliminar.TabIndex = 3;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// Registroemple
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(630, 469);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnEditar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.myDataGrid);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Registroemple";
			this.Text = "Registros empleados";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.myDataGrid)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.DataGridView myDataGrid;
	}
}

