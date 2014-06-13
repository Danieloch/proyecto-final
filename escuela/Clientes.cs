using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace escuela
{
	
	public class Clientes : MySQL
	{
		public Clientes ()
		{
		}

		public void mostrarTodos(){
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string nombre = myReader["nombre"].ToString();
	            string domicilio = myReader["domicilio"].ToString();                                        
				                  
	       }

            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
		}

		public Hashtable obtenerPorId(string id){
			Hashtable registro = new Hashtable();
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM clientes WHERE id = '"+id+"'", 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
            if(myReader.HasRows){
	        	myReader.Read();
	        	registro["id"] = myReader["id"].ToString();
	            registro["nombre"] = myReader["nombre"].ToString();
	            registro["domicilio"] = myReader["domicilio"].ToString();
	            registro["telefono"] = myReader["telefono"].ToString();
	            
	       }
          
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
			return registro;
		}

		public void insertarRegistroNuevo(string nombre,string domicilio,string telefono){
			this.abrirConexion();
string sql = "INSERT INTO `clientes` (`nombre`,`domicilio`,`telefono`) VALUES ('" + nombre + "','" + domicilio + "','" + telefono +"')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		
		public void editar(string id,string nombre,string domicilio, string telefono){
			this.abrirConexion();
			string sql = "UPDATE `clientes` SET  `nombre`='" + nombre + "' , `domicilio`='" + domicilio + "' , `telefono`='" + telefono + 
			"' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

			
			public void eliminarRegistroPorId(string id){
			this.abrirConexion();
			string sql = "DELETE FROM `clientes` WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		private int ejecutarComando(string sql){
			MySqlCommand myCommand = new MySqlCommand(sql,this.myConnection);
			int afectadas = myCommand.ExecuteNonQuery();
			myCommand.Dispose();
			myCommand = null;
			return afectadas;
		}

		private string querySelect(){
			return "SELECT * " +
	           	"FROM clientes";
		}
	}
}