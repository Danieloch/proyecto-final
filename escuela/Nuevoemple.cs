using System;
using System.Drawing;
using System.Windows.Forms;

namespace escuela
{
	/// <summary>
	/// Description of Nuevo.
	/// </summary>
	public partial class Nuevoemple : Form
	{
		private Registroemple main;
		public Nuevoemple(Registroemple main)
		{
			
			InitializeComponent();

			this.main=main;
		}

		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(this.txtNombre.Text.Trim()!="" && this.txtDomicilio.Text.Trim()!="" && this.txtTel.Text.Trim()!=""){
				Empleados emple = new Empleados();
				emple.insertarRegistroNuevo(this.txtNombre.Text.Trim(),this.txtDomicilio.Text.Trim(),this.txtTel.Text.Trim());
				this.main.actualizarTabla();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"El empleado se agregó con exito ¿Desea agregar otro empleado?", "Nuevo empleado",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);

				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
				}else{
					
					this.txtNombre.Clear();
				}
			}
		
		
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
			txtNombre.Clear();
			txtDomicilio.Clear();
			txtTel.Clear();
		}
	}
}
