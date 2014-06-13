using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace escuela
{
	/// <summary>
	/// Description of Factura.
	/// </summary>
	public partial class Factura : Form
	{
		private Registrocompra main;
		public Factura(Registrocompra main)
		{
			
			InitializeComponent();
			
			this.main=main;
		}
		
		void Button1Click(object sender, EventArgs e)
		{ 
			
			if(this.txtid.Text.Trim()!="" &&
			   this.txtcomp.Text.Trim()!="" &&
			   this.txtvend.Text.Trim()!="" &&
			   this.txtfech.Text.Trim()!="" &&
			   this.txttipo.Text.Trim()!="" &&
			   this.txtestado.Text.Trim()!=""){
				Productos productos = new Productos();
				productos.insertarRegistroNuevo(this.txtid.Text.Trim(),
				                                this.txtcomp.Text.Trim(),
				                                this.txtvend.Text.Trim(),
				                                this.txtfech.Text.Trim(),
				                                this.txttipo.Text.Trim(),
				                                this.txtestado.Text.Trim());
				this.main.actualizarTabla();
				 SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
			simpleSound.Play();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"La compra se agregó con exito ¿Desea agregar otra?", "Nuevo compra",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
            
				if(result != System.Windows.Forms.DialogResult.Yes){
					this.Close();
				}else{
					
					}
			}
		

             
         
                 
             
		}
		
		void Button2Click(object sender, EventArgs e)
		{    
		txtid.Clear();
        txtcomp.Clear();
        txtvend.Clear();
        //textBox4.Clear();
        //comboBox1.();
        //textBox6.Clear();
        //textBox7.Clear();
        //textBox8.Clear();
        //listView1.Clear();

			
			
			 
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
		}
		
		
		
	}
}
