using BikeManagerProgram.BikeNS;
using BikeManagerProgram.MemberNS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BikeManagerProgram.RentNS
{
    public class RentManager
    {
        private static npgSQL SQLConnector = new npgSQL();

     
        public static List<RentalShop> getRentalShops()
        {
            List<RentalShop> result = new List<RentalShop>();
            SQLConnector.DBConnect();
            string sql = @"select * FROM ""RentalShop""";
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);
            while (Reader.Read())
            {
                RentalShop rentalShop = new RentalShop((String)Reader["code"], (String)Reader["name"] , (String)Reader["address"]);
                result.Add(rentalShop);
            }
            SQLConnector.DBClose();
            return result;
        }
        public static RentalShop GetRentalShopByName(String name)
        {
            SQLConnector.DBConnect();
            String sql = @"Select * FROM ""RentalShop"" WHERE name='" + name + "'";
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);
            Reader.Read();
            RentalShop rentalShop = new RentalShop((String)Reader["code"], (String)Reader["name"], (String)Reader["address"]);
            SQLConnector.DBClose();

            return rentalShop;
        }
        public static RentalShop GetRentalShopByCode(String code)
        {
            SQLConnector.DBConnect();
            String sql = @"Select * FROM ""RentalShop"" WHERE code='" + code + "'";
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);
            Reader.Read();
            RentalShop rentalShop = new RentalShop((String)Reader["code"], (String)Reader["name"], (String)Reader["address"]);
            SQLConnector.DBClose();

            return rentalShop;
        }
        public static void Rent(Member member, Bike bike,RentalShop rentalshop)
        {
            SQLConnector.DBConnect();
            String sql = @"INSERT INTO ""Rent""(membercode, bikecode, rentdate, rentshop, returnshop, returndate) 
                            VALUES ('" + member.Code + "','" + bike.Code + "','" + DateTime.Now.ToShortDateString() + "','" + rentalshop.Code+ "','대여중','1111-11-11')";
            SQLConnector.ExecuteNon(sql);
            SQLConnector.DBClose();
        }
        public static void Return(Rent rent, RentalShop rentalshop)
        {
            int returnlimit = GetReturnLimit();
            SQLConnector.DBConnect();
            DateTime rentdate = rent.RentDate;
            String sql = @"UPDATE ""Rent""
                               SET returnshop='" + rentalshop.Code + "', returndate='" + DateTime.Today.ToShortDateString() + "' " +
                            "WHERE membercode='"+rent.MemberCode+"' AND bikecode='" + rent.BikeCode + @"';";
              

           
            SQLConnector.ExecuteNon(sql);
            SQLConnector.DBClose();
        }
        public static Rent GetNotReturnRent(String bikeCode)
        {
            SQLConnector.DBConnect();

            String sql =  @"SELECT * FROM ""Rent"" WHERE ""bikecode""='" + bikeCode + @"' AND ""returndate"" = '1111-11-11'";
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);

           
            Rent newRent = null;
            if (Reader.Read())
            {
                newRent = new Rent((String)Reader["membercode"],
                                   (String)Reader["bikecode"],
                                   (DateTime)Reader["rentdate"],
                                   (String)Reader["rentshop"],
                                   (String)Reader["returnshop"],
                                   (DateTime)Reader["returndate"]);
            }

            SQLConnector.DBClose();

            return newRent;
        }
        public static int GetReturnLimit()
        {
            SQLConnector.DBConnect();
            String sql = @"SELECT * FROM ""Configuration""";
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);
            Reader.Read();
            int returnLimit =  (int)Reader["returnlimit"];

            SQLConnector.DBClose();
            return returnLimit;
        }
    }
}
