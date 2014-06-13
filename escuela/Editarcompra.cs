/*
 * Creado por SharpDevelop.
 * Usuario: DANIEL
 * Fecha: 12/06/2014
 * Hora: 10:23 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace escuela
{
	/// <summary>
	/// Description of Editarcompra.
	/// </summary>
	public partial class Editarcompra : Form
	{
		
		private Registrocompra main;
		private string id;
		
		public Editarcompra(Registrocompra main, string id)
		{
			
			InitializeComponent();
			
			this.main = main;
			this.id = id;
		}
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
		if(this.txtproducto.Text.Trim()!=""){
				Productos prod = new Productos();
				prod.editar(this.id,this.txtproducto.Text.Trim());
				this.main.actualizarTabla();
				MessageBox.Show("Se editó con exito");
				this.Close();
			}	
		}
		
		void EditarLoad(object sender, EventArgs e)
		{
			System.Collections.Hashtable registro = new System.Collections.Hashtable();
			Productos prod = new Productos();
			registro= prod.obtenerPorId(this.id);
			this.txtproducto.Text =registro["estado_producto"].ToString();
			
		}
		
		
	}
}
