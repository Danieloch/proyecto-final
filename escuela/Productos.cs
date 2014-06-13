using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace escuela
{
	
	public class Productos : MySQL
	{
		public Productos ()
		{
		}

		public void mostrarTodos(){
			this.abrirConexion();
            MySqlCommand myCommand = new MySqlCommand(this.querySelect(), 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
	        while (myReader.Read()){
	            string codigo = myReader["codigo"].ToString();
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
            MySqlCommand myCommand = new MySqlCommand("SELECT * FROM compras WHERE id = '"+id+"'", 
			                                          myConnection);
            MySqlDataReader myReader = myCommand.ExecuteReader();	
            if(myReader.HasRows){
	        	myReader.Read();
	        	registro["id"] = myReader["id"].ToString();
	            registro["estado_producto"] = myReader["estado_producto"].ToString();
	       }
          
            myReader.Close();
			myReader = null;
            myCommand.Dispose();
			myCommand = null;
			this.cerrarConexion();
			return registro;
		}

		public void insertarRegistroNuevo(string Id,string comprador,string vendedor,string fecha,string tipo_producto,string estado_producto){
			this.abrirConexion();
string sql = "INSERT INTO `compras` (`Id`,`comprador`,`vendedor`,`fecha`,`tipo_producto`,`Estado_producto`) VALUES ('" + Id + "','" + comprador + "','" + vendedor +"','" + fecha + "','" + tipo_producto +"','" + estado_producto +"')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}
		
		
		public void editar(string id,string estado_producto){
			this.abrirConexion();
			string sql = "UPDATE `compras` SET `id`='" + id + "', `estado_producto`='" + estado_producto + "' WHERE (`id`='" + id + "')";
			this.ejecutarComando(sql);
			this.cerrarConexion();
		}

		
		
		
			
			public void eliminarRegistroPorId(string id){
			this.abrirConexion();
			string sql = "DELETE FROM `compras` WHERE (`id`='" + id + "')";
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
	           	"FROM compras";
		}
	}
}