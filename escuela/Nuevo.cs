using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace escuela
{
	/// <summary>
	/// Description of Nuevo.
	/// </summary>
	public partial class Nuevo : Form
	{
		private Registros main;
		public Nuevo(Registros main)
		{
			
			InitializeComponent();

			this.main=main;
		}

		void BtnGuardarClick(object sender, EventArgs e)
		{
			if(this.txtNombre.Text.Trim()!="" && this.txtDomicilio.Text.Trim()!="" && this.txtTel.Text.Trim()!=""){
				Clientes cliente = new Clientes();
				cliente.insertarRegistroNuevo(this.txtNombre.Text.Trim(),this.txtDomicilio.Text.Trim(),this.txtTel.Text.Trim());
				this.main.actualizarTabla();
				 SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
			simpleSound.Play();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"El cliente se agregó con exito ¿Desea agregar otro cliente?", "Nuevo cliente",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
            
				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
				}else{
					
					this.txtNombre.Clear();
					this.txtDomicilio.Clear();
					this.txtTel.Clear();
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
