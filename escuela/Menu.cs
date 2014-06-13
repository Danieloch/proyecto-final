using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace escuela
{
	
	public partial class Menu : Form
	{
		public Menu()
		{
			
			InitializeComponent();
			
			
		}
		
		void RegistroDeClientesToolStripMenuItemClick(object sender, EventArgs e)
		{
			Registros regi = new Registros();
			regi.Show();
		}
		
		
		
		void CerrarSesionToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\ir_end.wav");
			simpleSound.Play();
			 MainForm m = new MainForm();
			m.Show();
             
		    Application.Exit();
		    
		   
			
							
		}
		
		
		
		void RegistoDeEmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{ 
			Registroemple  regiem = new Registroemple ();
			regiem.Show();
		}
		
		
		
		void ProductosToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void EscritoriosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Escritorios escritorios = new Escritorios();
			escritorios.Show();
		}
		
		void LockersToolStripMenuItemClick(object sender, EventArgs e)
		{
			Lockers lockers = new Lockers();
			lockers.Show();
		}
		
		
		
		void RegistroDeComprasToolStripMenuItemClick(object sender, EventArgs e)
		{
			Registrocompra regicom = new Registrocompra();
			regicom.Show();
		}
		
		void CompraToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
	}
}
