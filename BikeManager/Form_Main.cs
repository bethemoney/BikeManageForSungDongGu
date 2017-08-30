using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BikeManagerProgram.MemberNS;
using BikeManagerProgram.BikeNS;
using System.Data.Common;
using BikeManagerProgram.RentNS;

namespace BikeManagerProgram
{
    public partial class Form_Main : Form
    {
        npgSQL npgsql = new npgSQL();
        MemberManager m_MemberManager;
        BikeManager m_BikeManager;
        RentalShop m_RentalShop;

        public Form_Main(RentalShop rentalShop)
        {
            InitializeComponent();


            m_RentalShop = rentalShop;
            this.Text = m_RentalShop + " 자전거 관리 프로그램";

            m_MemberManager = new MemberManager(npgsql);
            m_BikeManager = new BikeManager(m_RentalShop);
            m_RentalShop = rentalShop;
            radioBtn_All.Checked = true;
        }

        #region Update DataGridView
        public void UpdateRentDataGridView(String sql)
        {
            dataGridView_Rent.Rows.Clear();
            int returnlimit = RentManager.GetReturnLimit();

            npgsql.DBConnect();
            IDataReader Reader = npgsql.ExecuteQuery(sql);

            while (Reader.Read())
            {
                String status = "";
                String returndate="";
                
                //상태표시 
                if (((DateTime)Reader["returndate"]).ToShortDateString().Equals("1111-11-11"))
                {
                    status = "대여중";
                }
                else if (((DateTime)Reader["rentdate"]).AddDays(returnlimit) > (DateTime)Reader["returndate"])
                {
                    status = "정상반납";
                }
                else if (((DateTime)Reader["rentdate"]).AddDays(returnlimit) <= (DateTime)Reader["returndate"])
                {
                    status = "연체반납";
                }
                //반납일자 표시
                if(((DateTime)Reader["returndate"]).ToShortDateString().Equals("1111-11-11"))
                {
                     returndate="";
                }
                else
                {
                    returndate = ((DateTime)Reader["returndate"]).ToShortDateString();
                }
                
                String[] rows = new String[7];
                dataGridView_Rent.Rows.Add(new Object[]{
                    ((DateTime)Reader["rentdate"]).ToShortDateString(),                             //대여일시
                    returndate,                                                                 //반납일시
                    (String)Reader["bikecode"],                                                 //대여자전거
                    status,                                                                     //대여현황
                    (String)Reader["name"],                                                     //회원명
                    (String)Reader["tel"],                                                      //회원명
                    (String)Reader["address"],                                                  //회원명
                });
            }
            npgsql.DBClose();
            foreach (DataGridViewRow row in dataGridView_Rent.Rows)
                if (DateTime.Parse(row.Cells[0].Value.ToString()).AddDays(returnlimit) < DateTime.Today 
                                && row.Cells[3].Value.ToString().Equals("대여중"))
                {
                    row.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                }
        }

        public void UpdateMemberDataGridView(String sql)
        {
            dataGridView_MemList.Rows.Clear();
            npgsql.DBConnect();
            
            IDataReader Reader = npgsql.ExecuteQuery(sql);
            while (Reader.Read())
            {
                String[] rows = new String[6];

                rows[0] = (String)Reader["code"];
                rows[1] = (String)Reader["name"];
                rows[2] = Reader["regdate"].ToString().Substring(0, 10);
                rows[3] = (String)Reader["tel"];
                rows[4] = (String)Reader["city"] + " " + (String)Reader["county"] + " " + (String)Reader["address"];
                rows[5] = (String)Reader["etc"];
                dataGridView_MemList.Rows.Add(rows);
            }
            Reader.Close();
            npgsql.DBClose();
        }

        public void UpdateBikeDataGridView(String sql)
        {
            dataGridView_BikeList.Rows.Clear();
            npgsql.DBConnect();
       
            IDataReader Reader = npgsql.ExecuteQuery(sql);
            while (Reader.Read())
            {
                String[] rows = new String[6];

                rows[0] = (String)Reader["code"];
                rows[1] = (String)Reader["type"];
                rows[2] = (String)Reader["initrentalshop"];
                rows[2] = RentManager.GetRentalShopByCode(rows[2]).Name;

                rows[3] = (String)Reader["currentrentalshop"];
                rows[3] = RentManager.GetRentalShopByCode(rows[3]).Name;
                rows[4] = (String)Reader["etc"];
                rows[5] = Reader["regdate"].ToString();
                
                

                dataGridView_BikeList.Rows.Add(rows);
            }
            Reader.Close();
            npgsql.DBClose();
        }

        public void UpdateStatisticDataGridView(String sql)
        {

            dataGridView_Statistic.Rows.Clear();
            int returnlimit = RentManager.GetReturnLimit();

            npgsql.DBConnect();
            IDataReader Reader = npgsql.ExecuteQuery(sql);

            while (Reader.Read())
            {
                String status = "";
                //상태표시 
                if (((DateTime)Reader["returndate"]).ToShortDateString().Equals("1111-11-11"))
                {
                    status = "대여중";
                }
                else if (((DateTime)Reader["rentdate"]).AddDays(returnlimit) > (DateTime)Reader["returndate"])
                {
                    status = "정상반납";
                }
                else if (((DateTime)Reader["rentdate"]).AddDays(returnlimit) <= (DateTime)Reader["returndate"])
                {
                    status = "연체반납";
                }
                String[] rows = new String[7];
                dataGridView_Statistic.Rows.Add(new Object[]{
                    ((DateTime)Reader["rentdate"]).ToShortDateString(),                             //대여일시
                    ((DateTime)Reader["returndate"]).ToShortDateString(),                                           //반납일시
                    (String)Reader["bikecode"],                                                 //대여자전거
                    status,                                                                     //대여현황
                    (String)Reader["name"],                                                     //회원명
                    (String)Reader["tel"],                                                      //회원명
                    (String)Reader["address"],                                                  //회원명
                });
            }
            npgsql.DBClose();
        }

        private void UpdateStatisticControl()
        {
            String sql = @"SELECT r.rentdate, r.bikecode, m.name, m.tel, m.address, r.returndate 
                            FROM ""Rent"" r , ""Member"" m, ""Bike"" b
                            WHERE r.bikecode = b.code AND r.membercode = m.code {0} {1} {2} {3}";
            //날짜 필터링
            String sqlDate = "";

            sqlDate = "AND r.rentdate >= '" + dateTimePicker_Statistic_Start.Value.ToShortDateString() +
                    "' AND r.rentdate <= '" + dateTimePicker_Statistic_End.Value.ToShortDateString() + "'";
            //성별 필터링
            String sqlSex = "";
            if (cmboBox_Statistic_Sex.SelectedIndex == 0)
            {

            }
            else if (cmboBox_Statistic_Sex.Text.Equals("여자"))
            {
                sqlSex = "AND m.code LIKE '_W________'";
            }
            else if (cmboBox_Statistic_Sex.Text.Equals("남자"))
            {
                sqlSex = "AND m.code LIKE '_M________'";
            }
            //자전거 타입 필터링
            String sqlBikeType = "";
            
            //대여 장소 필터링
            String sqlRentalShop = "";
            

            String newSQL = String.Format(sql, sqlDate, sqlSex, sqlBikeType,sqlRentalShop);

            UpdateStatisticDataGridView(newSQL);
        }
        #endregion

        #region Event Handler
        private void tabControl_Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tabControl_Main.SelectedIndex == 0)
            {

                if (txtBox_Rent_BikeName.Text.Length != 4)
                    if (e.KeyChar.ToString().ToUpper() == "M")
                    {
                        if (!txtBox_Rent_MemName.Focused)
                        {
                            txtBox_Rent_MemName.Text = "M";
                            txtBox_Rent_MemName.SelectionStart = txtBox_Rent_MemName.Text.Length;
                        }
                        txtBox_Rent_MemName.Focus();
                    }
                if (e.KeyChar.ToString().ToUpper() == "B") {
                    if (!txtBox_Rent_BikeName.Focused) {
                        txtBox_Rent_BikeName.Text = "B";
                        txtBox_Rent_BikeName.SelectionStart = txtBox_Rent_BikeName.Text.Length;
                    }
                    txtBox_Rent_BikeName.Focus();
                }

            }
        }
        private void btn_Rent_Click(object sender, EventArgs e)
        {
            new Form_Rent(this, m_RentalShop).ShowDialog(this);
        }
        private void tabPage_Rent_Enter(object sender, EventArgs e)
        {
            if (tabControl_Main.SelectedIndex == 0)
            {
                String sql = @"SELECT r.rentdate, r.bikecode, m.name, m.tel, m.address, r.returndate FROM ""Rent"" r , ""Member"" m WHERE r.membercode = m.code";
                UpdateRentDataGridView(sql);
            }
        }
        private void btn_Rent_MemNameSearch_Click(object sender, EventArgs e)
        {
            String sql = @"Select * From ""Member"" Where ""name"" = '" + txtBox_MemList_Name.Text + "'";
            UpdateMemberDataGridView(sql);
        }

        private void txtBox_Rent_MemName_TextChanged(object sender, EventArgs e)
        {
            String sql = @"SELECT r.rentdate, r.bikecode, m.name, m.tel, m.address, r.returndate "+ 
                           "FROM \"Rent\" r, \"Member\" m " +
                           "WHERE r.membercode = m.code AND (m.name LIKE '%" + this.txtBox_Rent_MemName.Text.ToUpper() + "%'" +
                                                            " OR m.code LIKE '%" + this.txtBox_Rent_MemName.Text.ToUpper()+ "%') ";
            this.UpdateRentDataGridView(sql);

        }
        private void btn_Return_Click(object sender, EventArgs e)
        {
            new Form_Return(this,m_RentalShop).ShowDialog(this);
        }
        private void tabControl_Main_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_Main.SelectedIndex == 0)
            {
                String sql = @"SELECT r.rentdate, r.bikecode, m.name, m.tel, m.address, r.returndate FROM ""Rent"" r , ""Member"" m WHERE r.membercode = m.code";
                UpdateRentDataGridView(sql);
            }
            else if (tabControl_Main.SelectedIndex == 1)
            {
                //String sql = @"SELECT * FROM ""Member"" m ";
                String sql = @"SELECT m.code, m.name, m.tel, m.address, m.regdate, m.etc, m.isfemale, m.city, m.county FROM ""Member"" m";
                UpdateMemberDataGridView(sql);
            }
            else if (tabControl_Main.SelectedIndex == 2)
            {
                String sql = @"SELECT b.code, b.type, b.initrentalshop, b.currentrentalshop, b.etc, b.regdate FROM ""Bike"" b";
                UpdateBikeDataGridView(sql);
            }
            else if (tabControl_Main.SelectedIndex == 3)
            {
                UpdateStatisticPage();
            }
        }

        private void dataGridView_MemList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            npgsql.DBConnect();

            String memberCode = dataGridView_MemList.Rows[e.RowIndex].Cells[0].Value.ToString();

            String sql = @"SELECT * FROM ""Member"" WHERE ""code""= '" + memberCode + "'";
            IDataReader Reader = npgsql.ExecuteQuery(sql);
            Reader.Read();

            new Form_Member_Modify(new Member(
                                    (String)Reader["name"],
                                    (String)Reader["code"],
                                    (String)Reader["tel"],
                                    (String)Reader["city"],
                                    (String)Reader["county"],
                                    (String)Reader["address"],
                                    (String)Reader["etc"],
                                    Reader["regdate"].ToString(),
                                    (Byte[])Reader["image"],
                                    (Boolean)Reader["isfemale"]),m_RentalShop).ShowDialog(this);

            npgsql.DBClose();
            sql = @"SELECT m.code, m.name, m.tel, m.address, m.regdate, m.etc, m.isfemale, m.city, m.county FROM ""Member"" m";
            UpdateMemberDataGridView(sql);
        }
        private void btn_BikeReg_Click(object sender, EventArgs e)
        {
            new Form_Bike_Reg(m_RentalShop).ShowDialog(this);
            String sql = @"SELECT b.code, b.type, b.initrentalshop, b.currentrentalshop, b.etc, b.regdate FROM ""Bike"" b";
            UpdateBikeDataGridView(sql);
        }

        private void dataGridView_BikeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String bikeCode = dataGridView_BikeList.Rows[e.RowIndex].Cells[0].Value.ToString();
            //MessageBox.Show(bikeCode);

            npgsql.DBConnect();
            String sql = @"SELECT * FROM ""Bike"" WHERE ""code""= '" + bikeCode + "'";
            IDataReader Reader = npgsql.ExecuteQuery(sql);
            Reader.Read();
            Bike modifyBike = new Bike(
                                    (String)Reader["type"],
                                    (String)Reader["code"],
                                    (String)Reader["initrentalshop"],
                                    (String)Reader["currentRentalshop"],
                                    (String)Reader["etc"],
                                    Reader["regdate"].ToString(),
                                    (Byte[])Reader["image"]);
            npgsql.DBClose();
            new Form_Bike_Modify(modifyBike, m_RentalShop).ShowDialog(this);
            sql = @"SELECT b.code, b.type, b.initrentalshop, b.currentrentalshop, b.etc, b.regdate FROM ""Bike"" b";
            UpdateBikeDataGridView(sql);
        }

        private void btn_MemReg_Click(object sender, EventArgs e)
        {
            new Form_Member_Reg().ShowDialog(this);
            String sql = @"SELECT * FROM ""Member""";
            UpdateMemberDataGridView(sql);

        }

        #endregion

        private void btn_BikeDel_Click(object sender, EventArgs e)
        {
            String sql = @"SELECT * FROM ""Bike""";

            UpdateMemberDataGridView(sql);
        }

        private void txtBox_MemList_Name_TextChanged(object sender, EventArgs e)
        {
            String sql = @"Select * From ""Member"" Where ""name"" = '" + txtBox_MemList_Name.Text + "'";
            if(txtBox_MemList_Name.Text.Equals(""))
            {
                sql = @"Select * From ""Member""";
            }
            UpdateMemberDataGridView(sql);
        }

        private void txtBox_BikeList_Code_TextChanged(object sender, EventArgs e)
        {
            String sql = @"Select * From ""Bike"" Where ""code"" = '" + txtBox_BikeList_Code.Text + "'";
            if(txtBox_BikeList_Code.Text.Equals(""))
            {
                sql = @"SELECT b.code, b.type, b.initrentalshop, b.currentrentalshop, b.etc, b.regdate FROM ""Bike"" b";
            }
            UpdateBikeDataGridView(sql);
        }
        private void UpdateStatisticPage()
        {
            cmboBox_Statistic_BikeType.Items.Clear();
            cmboBox_Statistic_RentalShop.Items.Clear();
            cmboBox_Statistic_Sex.Items.Clear();

            List<BikeType> list_Biketype = m_BikeManager.GetBikeTypes();
            cmboBox_Statistic_BikeType.Items.Add("전체");
            for (int i = 0; i < list_Biketype.Count; i++)
                cmboBox_Statistic_BikeType.Items.Add(list_Biketype[i].Decription);
            cmboBox_Statistic_BikeType.SelectedIndex = 0;

            List<RentalShop> list_RentalShop = RentManager.getRentalShops();
            cmboBox_Statistic_RentalShop.Items.Add("전체");
            for (int i = 0; i < list_RentalShop.Count; i++)
                cmboBox_Statistic_RentalShop.Items.Add(list_RentalShop[i].Name);
            cmboBox_Statistic_RentalShop.SelectedIndex = 0;

            cmboBox_Statistic_Sex.Items.Add("전체");
            cmboBox_Statistic_Sex.Items.Add("남자");
            cmboBox_Statistic_Sex.Items.Add("여자");
            cmboBox_Statistic_Sex.SelectedIndex = 0;
        }


        private void dateTimePicker_Statistic_End_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatisticControl();
        }

        private void cmboBox_Statistic_RentalShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatisticControl();
        }

        private void cmboBox_Statistic_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatisticControl();
        }

        private void cmboBox_Statistic_BikeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatisticControl();
        }

        private void radioBtn_All_Click(object sender, EventArgs e)
        {
            String sql = @"SELECT r.rentdate, r.bikecode, m.name, m.tel, m.address, r.returndate FROM ""Rent"" r , ""Member"" m WHERE r.membercode = m.code";
            UpdateRentDataGridView(sql);
        }

        private void radioBtn_Renting_Click(object sender, EventArgs e)
        {
            String sql = @"SELECT r.rentdate, r.bikecode, m.name, m.tel, m.address, r.returndate FROM ""Rent"" r , ""Member"" m WHERE r.membercode = m.code AND r.returndate='1111-11-11'";
            UpdateRentDataGridView(sql);
        }

        

        private void radioBtn_Returned_Click(object sender, EventArgs e)
        {
            String sql = @"SELECT r.rentdate, r.bikecode, m.name, m.tel, m.address, r.returndate FROM ""Rent"" r , ""Member"" m WHERE r.membercode = m.code AND r.returndate<>'1111-11-11'";
            UpdateRentDataGridView(sql);
        }

        private void dateTimePicker_Statistic_Start_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatisticControl();
        }

        private void txtBox_Rent_BikeName_TextChanged(object sender, EventArgs e)
        {
            String sql = @"SELECT r.rentdate, r.bikecode, m.name, m.tel, m.address, r.returndate " +
                           "FROM \"Rent\" r, \"Member\" m " +
                           "WHERE r.membercode = m.code AND r.bikecode LIKE '%" +  this.txtBox_Rent_BikeName.Text.ToUpper() + "%'";
            this.UpdateRentDataGridView(sql);
        }
    }
}
