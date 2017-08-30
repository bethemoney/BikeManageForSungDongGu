using BikeManagerProgram.BikeNS;
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
    public partial class Form_Return : Form
    {
        Boolean isRentAvail = false;
        Rent m_Rent = null;
        Form_Main m_Parent;
        RentalShop m_RentalShop;
        npgSQL npgsql = new npgSQL();

        public Form_Return(Form_Main parent,RentalShop rentalshop)
        {

            m_RentalShop = rentalshop;
            m_Parent= parent;
            InitializeComponent();
        }
        private void txtBox_BikeCode_TextChanged(object sender, EventArgs e)
        {
            m_Rent = RentManager.GetNotReturnRent(txtBox_BikeCode.Text.ToUpper());
            if (m_Rent != null)
            {
                //대여중일경우
                if (m_Rent.ReturnDate.ToShortDateString().Equals("1111-11-11")) 
                {
                    int returnlimit = RentManager.GetReturnLimit();
                    if(m_Rent.RentDate.AddDays(returnlimit) < DateTime.Today)
                    {
                        txtBox_BikeStatus.Text = "연체중";
                    }
                    else
                    {
                        txtBox_BikeStatus.Text = "정상 대여중";
                    }
                    isRentAvail = true;
                }

              

            }
            else
            {
                txtBox_BikeStatus.Text = "";
                isRentAvail = false;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            if (isRentAvail)
            {
                RentManager.Return(m_Rent,m_RentalShop);

                MessageBox.Show("정상적으로 반납되었습니다.");
                String sql = @"SELECT r.rentdate, r.bikecode, m.name, m.tel, m.address, r.returndate FROM ""Rent"" r , ""Member"" m WHERE r.membercode = m.code";
                m_Parent.UpdateRentDataGridView(sql);

                this.Close();
            }
            else
            {
                MessageBox.Show("자전거가 없거나 대여중이 아닙니다.");
            }
        }
        
    }
}
