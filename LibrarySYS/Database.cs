using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySYS
{
     class Database
    {
        //Here i created a Class of my Database Connect so i can call it in each of my classes


       

        public const String connectionString = "Data Source=localhost:1521/orcl;User ID=c##User1;Password=12345678;";// change DataScource and UserID on different machines 


        public static OracleConnection OpenConnection() { 
        
            OracleConnection conn = new OracleConnection(Database.connectionString);

            conn.Open();

            return conn;

        }

        public static void ExecuteNonQuery(string sql) { 
        
            OracleConnection conn = OpenConnection();

            OracleCommand cmd = new OracleCommand(sql, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static OracleDataReader ExecuteSingleRowQuery(string query) {

            OracleConnection conn = OpenConnection();
            OracleCommand cmd = new OracleCommand(query, conn);

            OracleDataReader dr = cmd.ExecuteReader();

            return dr;


        }
        public static DataSet ExecuteMultiRowQuery(string query) {

            OracleConnection conn = OpenConnection();

            OracleCommand cmd = new OracleCommand(query, conn);

           OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);

            conn.Close();

            return ds;

                      
        
        }


    }
}
