using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace BikeManagerProgram
{
    public static class Images
    {
         private static npgSQL SQLConnector=new npgSQL();

         public static Image GetImage(String code) 
         {
             try
             {
                 SQLConnector.DBConnect();
                 String sql = @"SELECT image FROM ""Image"" WHERE code='{0}'";

                 sql = String.Format(sql, code);
                 IDataReader Reader = SQLConnector.ExecuteQuery(sql);
                 Reader.Read();

                 Byte[] getimage = (Byte[])Reader["Image"];
                 MemoryStream ms = new MemoryStream(getimage);
                 Image newImage = Bitmap.FromStream(ms);
                 SQLConnector.DBClose();
                 return newImage;
             }
             catch (Exception e)
             {
                 throw e;
             }
         }
         public static void  SaveImage(String code,Byte[] image)
         {
            

             SQLConnector.DBConnect();
             SQLConnector.DBCommand = new Npgsql.NpgsqlCommand(@"INSERT INTO ""Image"" VALUES (@code,@image);", (Npgsql.NpgsqlConnection)SQLConnector.DBConnection);
             ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@code", code);
             ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@image", image);

             SQLConnector.DBCommand.ExecuteNonQuery();
             SQLConnector.DBClose();
            
         }
    }
}
