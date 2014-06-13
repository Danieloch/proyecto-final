/*
 * Created by SharpDevelop.
 * User: virtual
 * Date: 17/05/2014
 * Time: 08:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;

namespace escuela
{
	/// <summary>
	/// Description of MySQL.
	/// </summary>
	public class MySQL
	{
		protected MySqlConnection myConnection;
		public MySQL ()
		{
		}
		
		protected void abrirConexion(){
			string connectionString =
          		"Server=localhost;" +
	          	"Database=mueblesk;" +
	          	"User ID=root;" +
	          	"Password=123;" +
	          	"Pooling=false;";
	       this.myConnection = new MySqlConnection(connectionString);
	       this.myConnection.Open();
		}
		
		protected void cerrarConexion(){
			this.myConnection.Close(); 
			this.myConnection = null;
		}
	}
}
