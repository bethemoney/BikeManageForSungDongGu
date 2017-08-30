using BikeManagerProgram.BikeNS;
using BikeManagerProgram.MemberNS;
using BikeManagerProgram.RentNS; /* 추가한 부분 1줄 */
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
    public partial class Form_Rent : Form
    {
        Boolean isMemberAvail= false;
        Boolean isBikeAvail = false;
        Member m_Member=null;
        Boolean isBikeRented = false; /* 추가한 부분 1줄 */
        Bike m_Bike = null;
        npgSQL npgsql=new npgSQL();

        MemberManager m_MemberManager;
        BikeManager m_BikeManager;
        RentalShop m_RentalShop;
        Form_Main m_Parent;
        public Form_Rent(Form_Main parent,RentalShop rentalshop)
        {
            m_Parent = parent;

            m_MemberManager = new MemberManager(npgsql);
            m_BikeManager = new BikeManager(rentalshop);
          
            m_RentalShop = rentalshop; 
            InitializeComponent();
        }

        
        private void txtBox_MemCode_TextChanged(object sender, EventArgs e)
        {
            m_Member =  m_MemberManager.GetMember(txtBox_MemCode.Text);
            if (m_Member != null)
            {
                txtBox_MemName.Text = m_Member.Name;
                //성별 
                if (m_Member.IsFemale)
                    txtBox_MemSex.Text = "여자";
                else
                    txtBox_MemSex.Text = "남자";
                txtBox_MemTel.Text = m_Member.Tel;
                txtBox_MemAddress.Text = m_Member.Address;
                isMemberAvail = true;
            }
            else
            {
                txtBox_MemName.Text = "";
                txtBox_MemSex.Text = "";
                txtBox_MemTel.Text = "";
                txtBox_MemAddress.Text = "";
                isMemberAvail = false;
            }

            
        }

        private void Form_Rent_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void txtBox_BikeCode_TextChanged(object sender, EventArgs e)
        {
            m_Bike = m_BikeManager.GetBike(txtBox_BikeCode.Text);
            if (m_Bike != null)
            {
                txtBox_BikeType.Text = m_Bike.Type.ToString();
                isBikeAvail = true;

                // 선택된 자전거 대여 여부 확인
                Rent rent = RentManager.GetNotReturnRent(m_Bike.Code);
                if(rent != null)
                {
                    isBikeRented=true;
                }

            }
            else
            {
                txtBox_BikeType.Text = "";
                isBikeAvail = false;
            }
        }

        private void btn_Rent_Click(object sender, EventArgs e)
        {
            if (isBikeAvail && isMemberAvail)
            {
                if (isBikeRented)
                {
                    MessageBox.Show("자전거가 이미 대여된 상태입니다.");
                }
                else
                {
                    RentManager.Rent(m_Member, m_Bike, m_RentalShop);

                    MessageBox.Show("정상적으로 대여되었습니다.");

                    String sql = @"SELECT r.rentdate, r.bikecode, m.name, m.tel, m.address, r.returndate FROM ""Rent"" r , ""Member"" m WHERE r.membercode = m.code";
                    m_Parent.UpdateRentDataGridView(sql);

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("멤버 또는 자전거가 옳지않습니다.");
            }
        }
        

    }
}
