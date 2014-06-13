

using System;
using System.Drawing;
using System.Windows.Forms;

namespace escuela
{
	
	public partial class Editar : Form
	{
		private Registros main;
		private string id;

		public Editar(Registros main, string id)
		{
			
			InitializeComponent();

			this.main = main;
			this.id = id;
		}

		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(this.txtNombre.Text.Trim()!="" && this.txtDomicilio.Text.Trim()!="" && this.txtTel.Text.Trim()!=""){
				Clientes cliente = new Clientes();
				cliente.editar(this.id,this.txtNombre.Text.Trim(),this.txtDomicilio.Text.Trim(), this.txtTel.Text.Trim());
				this.main.actualizarTabla();
				MessageBox.Show("Se editó con exito");
				this.Close();
			}
		}


		void EditarLoad(object sender, EventArgs e)
		{
			System.Collections.Hashtable registro = new System.Collections.Hashtable();
			Clientes cliente = new Clientes();
			registro= cliente.obtenerPorId(this.id);
			this.txtNombre.Text =registro["nombre"].ToString();
			this.txtDomicilio.Text=registro["domicilio"].ToString();
			this.txtTel.Text=registro["telefono"].ToString();
		}
	}
}
