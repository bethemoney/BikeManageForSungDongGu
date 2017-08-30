using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace BikeManagerProgram
{
   public class npgSQL
   {
       IDbCommand dbcmd;
       IDbConnection dbconn;

       public IDbConnection DBConnection { get { return dbconn; } }
       public IDbCommand DBCommand { get { return dbcmd; } set { dbcmd = value; } }

       public void DBConnect()
       {
           try
           {
               FileStream fStream = new FileStream("config", FileMode.OpenOrCreate);
               StreamReader sReader = new StreamReader(fStream);
               String ServerIP = sReader.ReadLine();
               String database = sReader.ReadLine();
               String UserID = sReader.ReadLine();
               String password = sReader.ReadLine();
               sReader.Close();
               fStream.Close();

               string connectionString =
                  "Server=" + ServerIP + ";" +
                  "Database=" + database + ";" +
                  "User ID=" + UserID + ";" +
                  "Password=" + password;

               dbconn = new NpgsqlConnection(connectionString);
               dbconn.Open();
               dbcmd = dbconn.CreateCommand();
           }
           catch (Exception e)
           {
               MessageBox.Show(e.Message);
           }
       }
       public IDataReader ExecuteQuery(string sql)
       {
           dbcmd.CommandText = sql;
           return dbcmd.ExecuteReader();
       }
       public void ExecuteNon(string sql)
       {
           dbcmd.CommandText = sql;
           dbcmd.ExecuteNonQuery();
       }
       public void ExecuteNon()
       {
           dbcmd.ExecuteNonQuery();
       }


       
       public void DBClose()
       {
           dbcmd.Dispose();
           dbcmd = null;
           dbconn.Close();
           dbconn = null;
       }
    }

}
