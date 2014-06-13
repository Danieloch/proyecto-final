using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Media;

namespace escuela
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(this.txtcuent.Text =="dann" && this.textBox2.Text == "123")
			{
				SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
			simpleSound.Play();
			Menu  m = new Menu();	
			m.Show();
			this.Hide();
			System.Windows.Forms.MessageBox.Show("bienvenido al programa"); 
			}
			
			else{
				SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
			simpleSound.Play();
				System.Windows.Forms.MessageBox.Show("Usuario invalio o Codigo  invalido"); 
			
			
			}
				
				
	}
		
		void Button2Click(object sender, EventArgs e)
		{   
			SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\ir_end.wav");
			simpleSound.Play();
			this.Hide();
		}
		
		
	
		/*
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			if(this.textBox2.Text == "123")
			{
				SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
			simpleSound.Play();
			Menu  m = new Menu();	
			m.Show();
			this.Hide();
			}
	}
	*/
	
}
}