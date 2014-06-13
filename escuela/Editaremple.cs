

using System;
using System.Drawing;
using System.Windows.Forms;

namespace escuela
{
	
	public partial class Editaremple : Form
	{
		private Registroemple main;
		private string id;

		public Editaremple(Registroemple main, string id)
		{
			
			InitializeComponent();

			this.main = main;
			this.id = id;
		}

		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(this.txtNom.Text.Trim()!="" && this.txtDom.Text.Trim()!="" && this.txtTelef.Text.Trim()!=""){
				Empleados emple = new Empleados();
				emple.editar(this.id,this.txtNom.Text.Trim(),this.txtDom.Text.Trim(), this.txtTelef.Text.Trim());
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
			this.txtNom.Text =registro["nombre"].ToString();
			this.txtDom.Text=registro["domicilio"].ToString();
			this.txtTelef.Text=registro["telefono"].ToString();
		}
		
		
	}
}
