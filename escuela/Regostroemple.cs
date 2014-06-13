
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Media;
namespace escuela
{
	
	public partial class Registroemple: Form
	{
		private MySqlCommand myCmdQuery;
		private MySqlDataAdapter myDataAdapter;
		private BindingSource myBindingSource;
		private MySqlCommandBuilder myCommandBuilder;
		private DataSet myData;
		private MySqlConnection myConnection;
		private string myStringCon;
		
		public Registroemple()
		{
			
			InitializeComponent();
			
			
			this.myCmdQuery= new MySqlCommand();
			this.myDataAdapter=new MySqlDataAdapter();
			this.myBindingSource=new BindingSource();
			this.myCommandBuilder =new MySqlCommandBuilder();
			this.myData =new DataSet();
			this.myDataGrid.AllowUserToAddRows = false;
			this.myStringCon=
				"Server=localhost;" +
				"Database=mueblesk;" +
				"User ID=root;" +
				"Password=123;" +
				"Pooling=false;";
			

		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//create an instance of MySqlConnection class
			this.myConnection = new MySqlConnection(this.myStringCon);
			try{
				this.myConnection.Open();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
				System.Environment.Exit(1);
			}
			
			this.myCmdQuery.CommandText="SELECT * FROM empleados";//muestra lo de la tablas
			this.myCmdQuery.CommandType=CommandType.Text;
			this.myCmdQuery.Connection=this.myConnection;
			
			this.myDataAdapter.SelectCommand=this.myCmdQuery;
			this.myCommandBuilder.DataAdapter=this.myDataAdapter;
			//Llenar el dataset
			this.myDataAdapter.Fill(this.myData,"empleados");
			this.myBindingSource.DataSource=this.myData;
			this.myBindingSource.DataMember="empleados";
			this.myDataGrid.DataSource=this.myBindingSource;

			

		}
		
		
		void BtnAgregarClick(object sender, EventArgs e)
		{ SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
			simpleSound.Play();
			Nuevoemple nuevo = new Nuevoemple(this);
			nuevo.Show();
		}
		
		void BtnEditarClick(object sender, EventArgs e)
		{   SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
			simpleSound.Play();
			if(this.myDataGrid.SelectedRows.Count>0){
				DataGridViewRow row = this.myDataGrid.SelectedRows[0];
				DataGridViewCell cell = row.Cells[0];
				string id = cell.Value.ToString();
				Editaremple edita = new Editaremple(this, id);
				edita.Show();
			}
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(this.myDataGrid.SelectedRows.Count>0){
				DataGridViewRow row = this.myDataGrid.SelectedRows[0];
				DataGridViewCell cell0 = row.Cells[0];
				DataGridViewCell cell1 = row.Cells[1];
				DataGridViewCell cell2 = row.Cells[2];
				string id = cell0.Value.ToString();
				string nombre = cell1.Value.ToString();
				 SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\notify.wav");
			simpleSound.Play();
				System.Windows.Forms.DialogResult result = MessageBox.Show(
					"¿Está seguro que desea eliminar al empleado con id " + id + "?", "Confirmar eliminación",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question,
					MessageBoxDefaultButton.Button1
				);
				
				if(result == System.Windows.Forms.DialogResult.Yes){
					this.eliminarAlumno(id);
					this.actualizarTabla();
					MessageBox.Show("El empleado con el id " + id + " fue eliminado con exito.");
				}
			}
		}
		
		private void eliminarAlumno(string id){
			string sql = "DELETE FROM `empleados` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
		}
		
		
		
		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}
		
		public void actualizarTabla(){
			try{
				this.myData.Clear();
				this.myDataAdapter.Fill(this.myData,"empleados");
				this.myBindingSource.DataSource=this.myData;
				this.myBindingSource.DataMember="empleados";
				this.myDataGrid.DataSource=this.myBindingSource;
				this.myDataGrid.Update();
				this.myDataGrid.Refresh();
			}catch(MySqlException ex){
				MessageBox.Show(ex.Message);
			}
		}
		
	}
}
