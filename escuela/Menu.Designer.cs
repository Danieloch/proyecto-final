/*
 * Created by SharpDevelop.
 * User: Paola
 * Date: 25/05/2014
 * Time: 11:28 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace escuela
{
	partial class Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registoDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.registroDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.escritoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lockersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.manuelDelUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.registrosToolStripMenuItem,
									this.productosToolStripMenuItem,
									this.facturaToolStripMenuItem,
									this.ayudaToolStripMenuItem,
									this.cerrarSesionToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(380, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// registrosToolStripMenuItem
			// 
			this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.registroDeClientesToolStripMenuItem,
									this.registoDeEmpleadosToolStripMenuItem,
									this.registroDeComprasToolStripMenuItem});
			this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
			this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.registrosToolStripMenuItem.Text = "Registros";
			// 
			// registroDeClientesToolStripMenuItem
			// 
			this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
			this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.registroDeClientesToolStripMenuItem.Text = "Registro de clientes";
			this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeClientesToolStripMenuItemClick);
			// 
			// registoDeEmpleadosToolStripMenuItem
			// 
			this.registoDeEmpleadosToolStripMenuItem.Name = "registoDeEmpleadosToolStripMenuItem";
			this.registoDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.registoDeEmpleadosToolStripMenuItem.Text = "Registro de empleados";
			this.registoDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.RegistoDeEmpleadosToolStripMenuItemClick);
			// 
			// registroDeComprasToolStripMenuItem
			// 
			this.registroDeComprasToolStripMenuItem.Name = "registroDeComprasToolStripMenuItem";
			this.registroDeComprasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
			this.registroDeComprasToolStripMenuItem.Text = "Registro de compras";
			this.registroDeComprasToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeComprasToolStripMenuItemClick);
			// 
			// productosToolStripMenuItem
			// 
			this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.sillasToolStripMenuItem,
									this.escritoriosToolStripMenuItem,
									this.lockersToolStripMenuItem});
			this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
			this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.productosToolStripMenuItem.Text = "Productos";
			this.productosToolStripMenuItem.Click += new System.EventHandler(this.ProductosToolStripMenuItemClick);
			// 
			// sillasToolStripMenuItem
			// 
			this.sillasToolStripMenuItem.Name = "sillasToolStripMenuItem";
			this.sillasToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.sillasToolStripMenuItem.Text = "Sillas";
			// 
			// escritoriosToolStripMenuItem
			// 
			this.escritoriosToolStripMenuItem.Name = "escritoriosToolStripMenuItem";
			this.escritoriosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.escritoriosToolStripMenuItem.Text = "Escritorios";
			this.escritoriosToolStripMenuItem.Click += new System.EventHandler(this.EscritoriosToolStripMenuItemClick);
			// 
			// lockersToolStripMenuItem
			// 
			this.lockersToolStripMenuItem.Name = "lockersToolStripMenuItem";
			this.lockersToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.lockersToolStripMenuItem.Text = "Lockers";
			this.lockersToolStripMenuItem.Click += new System.EventHandler(this.LockersToolStripMenuItemClick);
			// 
			// facturaToolStripMenuItem
			// 
			this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.compraToolStripMenuItem});
			this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
			this.facturaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.facturaToolStripMenuItem.Text = "Factura";
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.manuelDelUsuarioToolStripMenuItem});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// manuelDelUsuarioToolStripMenuItem
			// 
			this.manuelDelUsuarioToolStripMenuItem.Name = "manuelDelUsuarioToolStripMenuItem";
			this.manuelDelUsuarioToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
			this.manuelDelUsuarioToolStripMenuItem.Text = "Manuel del usuario";
			// 
			// cerrarSesionToolStripMenuItem
			// 
			this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
			this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
			this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
			this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.CerrarSesionToolStripMenuItemClick);
			// 
			// compraToolStripMenuItem
			// 
			this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
			this.compraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.compraToolStripMenuItem.Text = "compra";
			this.compraToolStripMenuItem.Click += new System.EventHandler(this.CompraToolStripMenuItemClick);
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(380, 307);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Menu";
			this.Text = "Menu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registroDeComprasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lockersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem escritoriosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sillasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem manuelDelUsuarioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registoDeEmpleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		
		
	}
}
