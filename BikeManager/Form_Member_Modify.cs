using BikeManagerProgram.MemberNS;
using BikeManagerProgram.RentNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BikeManagerProgram
{
    public partial class Form_Member_Modify : Form
    {
        Member m_Member;
        OpenFileDialog ofd;
        MemberManager m_MemberManager;
        RentalShop m_RentalShop;
        npgSQL npgsql = new npgSQL();
        public Form_Member_Modify(Member member, RentalShop rentalShop)
        {
         
            InitializeComponent();
            m_MemberManager = new MemberManager(npgsql);
            m_Member = member;
            txtBox_Name.Text = m_Member.Name;
            txtBox_ETC.Text = m_Member.ETC;
            txtBox_Tel.Text = m_Member.Tel;
            if (member.IsFemale)
                cmboBox_Sex.SelectedIndex = 1;
            else
                cmboBox_Sex.SelectedIndex = 0;
            txtBox_Code.Text = m_Member.Code;
            m_RentalShop=rentalShop;
           ofd = new OpenFileDialog();
           ofd.Filter = "Image  Files (*.bmp, *.gif, *.jpg, *.png)|*.bmp;*.gif;*.jpg;*.png";

            //Date 
            dateTimePicker_RegDate.Value = DateTime.Parse(m_Member.RegDate);

            //시군구 출력
            String[] cities = GetCities();
            foreach (String city in cities)
            {
                cmboBox_City.Items.Add(city);
            }
            cmboBox_City.SelectedItem = m_Member.City;
            cmboBox_County.SelectedItem = m_Member.County;
            txtBox_Address.Text = m_Member.Address;
            MemoryStream ms = new MemoryStream(m_Member.Picture);
            Image newImage = Bitmap.FromStream(ms);

            pic_Picture.Image = newImage;
        }

        private void pic_Picture_Click(object sender, EventArgs e)
        {
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Picture.ImageLocation = ofd.FileName;

            }
        }

        private void btn_MemModify_Click(object sender, EventArgs e)
        {
            Boolean isfemale;
            if (cmboBox_Sex.SelectedIndex == 0)
                isfemale = false;
            else
                isfemale = true;
            

            MemoryStream mStream = new MemoryStream();
            pic_Picture.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            Byte[] imageArr = mStream.GetBuffer();

            m_MemberManager.MemberUpdate(new Member(
                txtBox_Name.Text,
                txtBox_Code.Text,
                txtBox_Tel.Text,
                cmboBox_City.Text,
                cmboBox_County.Text,
                txtBox_Address.Text,
                txtBox_ETC.Text,
                dateTimePicker_RegDate.Value.ToString(),
                imageArr,
                isfemale));
            MessageBox.Show(txtBox_Name.Text+"회원님의 정보가 수정되었습니다.");
            this.Close();           
        }

        private void cmboBox_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            String city = (String)cmboBox_City.SelectedItem;
            String[] counties = GetCounties(city);
            if (counties.Length > 0)
            {
                cmboBox_County.Items.Clear();
            }
            foreach (String county in counties)
            {
                cmboBox_County.Items.Add(county);
            }
        }
        private String[] GetCities()
        {
            List<String> cities = new List<String>();
            npgsql.DBConnect();
            String sql = @"SELECT city FROM ""Address"" GROUP BY city ORDER BY min(no)";
            IDataReader Reader = npgsql.ExecuteQuery(sql);
            while (Reader.Read())
            {
                cities.Add((String)Reader[0]);
            }
            npgsql.DBClose();
            return cities.ToArray();
        }

        private String[] GetCounties(String city)
        {
            List<String> counties = new List<String>();
            npgsql.DBConnect();
            String sql = @"SELECT county FROM ""Address"" WHERE city = '" + city + @"' ORDER BY no";
            IDataReader Reader = npgsql.ExecuteQuery(sql);
            while (Reader.Read())
            {
                counties.Add(Reader[0].ToString());
            }
            npgsql.DBClose();
            return counties.ToArray();
        }

        private void btn_MemRemove_Click(object sender, EventArgs e)
        {
            Form_Member_DeleteConfirm form_Member_DeleteConfirm = new Form_Member_DeleteConfirm(m_Member,m_RentalShop);

            form_Member_DeleteConfirm.ShowDialog();
            if (form_Member_DeleteConfirm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(txtBox_Name.Text + "회원님의 정보가 삭제되었습니다.");
                this.Close();
            }
        }


    }
}
