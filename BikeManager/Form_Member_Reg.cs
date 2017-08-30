using BikeManagerProgram.MemberNS;
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
    public partial class Form_Member_Reg : Form
    {
        npgSQL npgsql = new npgSQL();
        MemberManager memberManager;
        OpenFileDialog ofd;
        public Form_Member_Reg()
        {
            InitializeComponent();
            memberManager = new MemberManager(npgsql);

            ofd = new OpenFileDialog();
            ofd.Filter = "Image  Files (*.bmp, *.gif, *.jpg, *.png)|*.bmp;*.gif;*.jpg;*.png";


            //시군구
            String[] cities = GetCities();
            foreach (String city in cities)
            {
                cmboBox_City.Items.Add(city);
            }

            
        }

        private void btn_MemReg_Click(object sender, EventArgs e)
        {
            Boolean isfemale ;
            if (cmboBox_Sex.SelectedIndex == 0)
                isfemale = false;
            else 
                isfemale = true;
            DateTime date = DateTime.Now;

            MemoryStream mStream = new MemoryStream();

            pic_Picture.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            Byte[] imageArr = mStream.GetBuffer();

            try
            {
                String membercode = memberManager.GetNewMemberCode(isfemale);
                memberManager.MemberRegister(new Member(
                    txtBox_Name.Text,
                    membercode,
                    txtBox_Tel.Text,
                    cmboBox_City.Text,
                    cmboBox_County.Text,
                    txtBox_Address.Text,
                    txtBox_ETC.Text,
                    date.ToString().Substring(0, 10),
                    imageArr,
                    isfemale));
                
                MessageBox.Show("회원등록을 성공적으로 수행하였습니다.\n회원님의 회원번호는\n" + membercode + "\n입니다.");
                this.Close();
            }
            catch (InvalidOperationException IOE)
            {
                MessageBox.Show("회원등록을 수행 할 수 없습니다.");
                
            }
        }

        private void pic_Picture_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Picture.ImageLocation = ofd.FileName;

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
            return counties.ToArray();
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

    }
}
