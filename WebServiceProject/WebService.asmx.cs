using Oracle.ManagedDataAccess.Client;
//using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;


namespace WebServiceProject
{
	/// <summary>  
	/// Summary description for WebService  
	/// </summary>  
	[WebService(Namespace = "http://tempuri.org/")]
	[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
	[System.ComponentModel.ToolboxItem(false)]
	// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.   
	// [System.Web.Script.Services.ScriptService]  
	public class WebService : System.Web.Services.WebService
	{
		//public virtual OracleConnection Db { get; set; }

		[WebMethod]
		public string HelloWorld()
		{

			return "Hello World";
		}
		[WebMethod]
		public int Add(int a, int b)
		{
			

			return a + b;
		}
		[WebMethod]
		public DataSet GetData()
		{
			
			string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
			OracleConnection conn = new OracleConnection(connStr);

			conn.Open();
			OracleDataAdapter cmd = new OracleDataAdapter("SELECT * FROM EQUIPOS",conn);
			
			conn.Close();
			DataSet ds = new DataSet();
			ds.Tables.Add("EQUIPOS");
			cmd.Fill(ds, "EQUIPOS"); // llenamos el dataset
			//	DataTable tt = ds.Tables[0];
				return ds;
			
		}

		[WebMethod]
		public  DataSet DatosEquipos()
		{
			
			string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString; // conexion al webConfig
			OracleConnection conn = new OracleConnection(connStr);
			DataSet ds = new DataSet();

			using (OracleCommand command = (OracleCommand)conn.CreateCommand())
			{
				conn.Open();
				command.Parameters.Add(new OracleParameter { ParameterName = "resultado", Value = Oracle.ManagedDataAccess.Types.OracleRefCursor.Null });
				command.Parameters[0].Direction = ParameterDirection.Output;
				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = "Connectiondb.Result";

			   OracleDataReader r = (OracleDataReader)command.ExecuteReader(CommandBehavior.CloseConnection);
			    DataTable data = new DataTable();
				data = new DataTable();
				data.Load(r);
		
				data.TableName ="EQUIPOS";
				ds.Tables.Add(data);
				return ds;

			}

		}
		[WebMethod]
		public DataSet ConsultaEquipos(string equipo)
		{
			string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString; // conexion al webConfig
			OracleConnection conn = new OracleConnection(connStr);
			DataSet equipos = new DataSet();

			using(OracleCommand command = (OracleCommand)conn.CreateCommand())
			{
				conn.Open();
				command.Parameters.Add(new OracleParameter { ParameterName = "nombreEquipo", Value = equipo });
				command.Parameters.Add(new OracleParameter { ParameterName = "resultado", Value = Oracle.ManagedDataAccess.Types.OracleRefCursor.Null });
				command.Parameters[1].Direction = ParameterDirection.Output;

				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = "Connectiondb.ConsultDatos";

				OracleDataReader r = (OracleDataReader)command.ExecuteReader(CommandBehavior.CloseConnection);
				DataTable data = new DataTable();
				data = new DataTable();
				data.Load(r);

				data.TableName = "EQUIPOS";
				equipos.Tables.Add(data);
				return equipos;

			}

		}
	}
}