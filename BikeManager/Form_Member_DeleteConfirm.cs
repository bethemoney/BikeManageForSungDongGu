using BikeManagerProgram.MemberNS;
using BikeManagerProgram.RentNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BikeManagerProgram
{
    public partial class Form_Member_DeleteConfirm : Form
    {
        RentalShop m_RentalShop;
        npgSQL npgsql = new npgSQL();
        Member m_Member;
        public Form_Member_DeleteConfirm(Member member, RentalShop rentalShop)
        {
            InitializeComponent();
            m_RentalShop = rentalShop;
            m_Member = member;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            npgsql.DBConnect();
            String sql = @"select password from ""RentalShop"" where code='" + m_RentalShop.Code + "'";
            IDataReader Reader = npgsql.ExecuteQuery(sql);

            Reader.Read();
         
            bool isPasswordConfirm = txtBox_Password.Text.Equals(Reader["password"]);
            npgsql.DBClose();
            if (!isPasswordConfirm)
            {
                MessageBox.Show("비밀번호가 맞지않습니다.");
            }
            else
            {
                npgsql.DBConnect();
                sql = @"DELETE FROM ""Member"" WHERE code = '" + m_Member.Code  + "'";
                npgsql.ExecuteNon(sql);
                npgsql.DBClose();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

           
         
            
        }

    }
}
