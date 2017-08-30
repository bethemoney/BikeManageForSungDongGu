using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;
namespace BikeManagerProgram.MemberNS
{
    public class MemberManager
    {
        private npgSQL SQLConnector;

        public MemberManager(npgSQL npgsql)
        {
            SQLConnector = npgsql;
            
        }
        
        public void MemberRegister(Member member)
        {
            String newMemberCode = GetNewMemberCode(member.IsFemale); //수정해야함
            SQLConnector.DBConnect();

            
            SQLConnector.DBCommand =
                new Npgsql.NpgsqlCommand(@"INSERT INTO ""Member"" VALUES (@code, @name, @tel, @address, @regdate, @etc, @isfemale, @image,@city,@county);",
                (Npgsql.NpgsqlConnection)SQLConnector.DBConnection);

            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@code", member.Code);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@name", member.Name);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@tel", member.Tel);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@address", member.Address);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@regdate", member.RegDate);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@etc", member.ETC);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@isfemale", member.IsFemale);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@image", member.Picture);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@city", member.City);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@county", member.County);

            SQLConnector.DBCommand.ExecuteNonQuery();
            SQLConnector.DBClose();
        }

        public Member GetMember(String memberCode)
        {
            SQLConnector.DBConnect();

            string sql = "";
            sql = @"SELECT * FROM ""Member"" WHERE ""code""='" + memberCode + "'";
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);

            Member newMember = null;
            if (Reader.Read())
            {
                newMember = new Member((String)Reader["name"],
                                        (String)Reader["code"],
                                        (String)Reader["tel"],
                                        (String)Reader["City"],
                                        (String)Reader["County"],
                                        (String)Reader["address"],
                                        (String)Reader["etc"],
                                        Reader["regdate"].ToString(),
                                        (Byte[])Reader["image"],
                                        (Boolean)Reader["isfemale"]);
            }

            SQLConnector.DBClose();
            
            return  newMember;
        }
        public String GetNewMemberCode(Boolean isfemale)
        {

            SQLConnector.DBConnect();

            string sql = "";
            string MemberCode = "M";
            if (isfemale)
            {
                sql = @"SELECT Max(right(""code"",8)) as number FROM ""Member"" WHERE substr(""code"",2,1)='W'";
                MemberCode += "W";
            }
            else
            {
                sql = @"SELECT Max(right(""code"",8)) as number FROM ""Member"" WHERE substr(""code"",2,1)='M'";
                MemberCode += "M";
            }
            IDataReader Reader = SQLConnector.ExecuteQuery(sql);
            Reader.Read();
            int MaxCode;
            if(!Reader.IsDBNull(0))
                MaxCode = int.Parse((String)Reader["number"]);
            else
                MaxCode = 0;
            MemberCode += string.Format("{0:D8}", MaxCode + 1);

            SQLConnector.DBClose();

            return MemberCode;
        }
        public void MemberUpdate(Member member)
        {
            SQLConnector.DBConnect();

            SQLConnector.DBCommand =
                new Npgsql.NpgsqlCommand(@"UPDATE ""Member"" SET name=@name, tel=@tel, city=@city, county=@county, address=@address, regdate=@regdate, etc=@etc, isfemale=@isfemale, image=@image WHERE code=@code;",
                (Npgsql.NpgsqlConnection)SQLConnector.DBConnection);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@name", member.Name);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@tel", member.Tel);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@city", member.City);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@county", member.County);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@address", member.Address);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@regdate", DateTime.Parse(member.RegDate).Date);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@etc", member.ETC);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@isfemale", member.IsFemale);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@image", member.Picture);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@code", member.Code);

      
            SQLConnector.DBCommand.ExecuteNonQuery();
            SQLConnector.DBClose();

        }
        public void MemberDelete(String code)
        {
            SQLConnector.DBConnect();

            SQLConnector.DBCommand =
                new Npgsql.NpgsqlCommand(@"DELETE FROM ""Member"" WHERE code=@code",
                (Npgsql.NpgsqlConnection)SQLConnector.DBConnection);
            ((Npgsql.NpgsqlCommand)SQLConnector.DBCommand).Parameters.AddWithValue("@code", code);

            SQLConnector.DBCommand.ExecuteNonQuery();
            SQLConnector.DBClose();
        }

        public enum Sex
        {   
            Male,
            Female
        }

    }
}
