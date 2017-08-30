using BikeManagerProgram.RentNS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BikeManagerProgram.BikeNS
{
    public class BikeManager
    {
        private static npgSQL SQLConnector=new npgSQL();
        private RentalShop m_RentalShop;
        public BikeManager(RentalShop RentalShop)
        {
            m_RentalShop = RentalShop;
        }

        public void BikeRegister(Bike bike)
        {
            String newBikeNumber = GetNewBikeCode(bike.Type);
            SQLConnector.DBConnect();

           // String sql = "";
            SQLConnector.DBCommand =
                new Npgsql.NpgsqlCommand(@"INSERT INTO ""Bike"" VALUES (@code, @type, @initshop, @currentshop, @etc, @regdate, @image);",
                (Npgsql.NpgsqlConnection)SQLConnector.DBConnection);

            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@code", bike.Code);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@type", bike.Type);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@initshop", bike.InitRentalShop);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@currentshop", bike.CurrentRentalShop);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@etc", bike.ETC);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@regdate", bike.RegDate);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@image", bike.Picture);
  
            SQLConnector.DBCommand.ExecuteNonQuery();
            SQLConnector.DBClose();
      

        }

        public Bike GetBike(String bikeCode)
        {
            SQLConnector.DBConnect();

            string sql = "";
            sql = @"SELECT * FROM ""Bike"" WHERE ""code""='" + bikeCode + "'";
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);

          
            Bike newBike = null;
            if (Reader.Read())
            {
                String strType = (String)Reader["type"];


                newBike = new Bike(strType,
                                        (String)Reader["code"],
                                        (String)Reader["initrentalshop"],
                                        (String)Reader["currentRentalshop"],
                                        (String)Reader["etc"],
                                        Reader["regdate"].ToString(),
                                        (Byte[])Reader["image"]);
            }

            SQLConnector.DBClose();

            return newBike;
        }
        public List<BikeType> GetBikeTypes()
        {
            List<BikeType> result = new List<BikeType>();
            SQLConnector.DBConnect();
            string sql = "";
            sql = @"SELECT * FROM ""Biketype""";
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);


            while (Reader.Read())
            {
                BikeType biketype = new BikeType((String)Reader["code"], (String)Reader["description"], (String)Reader["name"]);
                result.Add(biketype);
            }


            SQLConnector.DBClose();
            return result;
        }

        public String GetNewBikeCode(String Type)
        {
            SQLConnector.DBConnect();
            string sql = "";
            string BikeCode = "B";
            sql = @"SELECT * FROM ""RentalShop"" WHERE ""code""='" + m_RentalShop.Code + "'";
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);
            Reader.Read();

            BikeCode += (String)Reader["code"];

            BikeCode += Type.ToString();
            Reader.Close();
            sql = @"SELECT Max(right(""code"",5)) as number FROM ""Bike"" WHERE substring(""code"" from 5 for 1) = '"  + Type + "'";

            IDataReader Reader1 = SQLConnector.ExecuteQuery(sql);
            Reader1.Read();
            int MaxCode;
            if (!Reader1.IsDBNull(0))
                MaxCode = int.Parse((String)Reader1["number"]);
            else
                MaxCode = 0;
            BikeCode += string.Format("{0:D5}", MaxCode + 1);
            SQLConnector.DBClose();
            return BikeCode;
        }

        public String GetBikeTypeCode(String description)
        {
            SQLConnector.DBConnect();
            String sql = @"SELECT * FROM ""Biketype"" WHERE ""description""='" + description + "'";
            //
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);
            Reader.Read();
            String code = (String)Reader["code"];

            SQLConnector.DBClose();
            return code;

        }
        public String GetBikeTypeDescription(String code)
        {
            SQLConnector.DBConnect();
            String sql = @"SELECT * FROM ""Biketype"" WHERE ""code""='" + code + "'";
        
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);
            Reader.Read();
            String description = (String)Reader["description"];

            SQLConnector.DBClose();
            return description;

        }

        public void BikeUpdate(Bike bike)
        {
            SQLConnector.DBConnect();

            SQLConnector.DBCommand =
                new Npgsql.NpgsqlCommand(@"UPDATE ""Bike"" SET type=@type, initrentalshop=@initshop, currentrentalshop=@currentshop, etc=@etc, regdate=@regdate, image=@image WHERE code=@code",
                (Npgsql.NpgsqlConnection)SQLConnector.DBConnection);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@code", bike.Code);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@type", bike.Type);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@initshop", bike.InitRentalShop);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@currentshop", bike.CurrentRentalShop);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@etc", bike.ETC);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@regdate", DateTime.Parse(bike.RegDate).Date);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@image", bike.Picture);

            SQLConnector.DBCommand.ExecuteNonQuery();
            SQLConnector.DBClose();
        }
        public void BikeDelete(String code)
        {
            SQLConnector.DBConnect();

            SQLConnector.DBCommand =
                new Npgsql.NpgsqlCommand(@"DELETE FROM ""Bike"" WHERE code=@code",
                (Npgsql.NpgsqlConnection)SQLConnector.DBConnection);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@code", code);

            SQLConnector.DBCommand.ExecuteNonQuery();
            SQLConnector.DBClose();
        }
    }
}
