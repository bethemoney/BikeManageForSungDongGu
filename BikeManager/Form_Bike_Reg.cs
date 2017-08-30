
using BikeManagerProgram.BikeNS;
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
    public partial class Form_Bike_Reg : Form
    {
        npgSQL npgsql = new npgSQL();
        BikeManager m_BikeManager;
        RentalShop m_RentalShop;
        OpenFileDialog ofd;
        public Form_Bike_Reg(RentalShop rentalShop)
        {
            InitializeComponent();
            m_BikeManager = new BikeManager(rentalShop);
            m_RentalShop = rentalShop;

            txtBox_RentalShop.Text = rentalShop.Name;

            List<BikeType> list_Biketype = m_BikeManager.GetBikeTypes();
            for(int i=0;i<list_Biketype.Count;i++)
            {
                cmboBox_Type.Items.Add(list_Biketype[i].Decription);
            }

            ofd = new OpenFileDialog();
            ofd.Filter = "Image  Files (*.bmp, *.gif, *.jpg, *.png)|*.bmp;*.gif;*.jpg;*.png";

        }
      
      
       
        private void btn_BikeReg_Click(object sender, EventArgs e)
        {
            String typecode = m_BikeManager.GetBikeTypeCode(cmboBox_Type.Text);
            String bikecode= m_BikeManager.GetNewBikeCode(typecode);
            DateTime date = DateTime.Now;

            MemoryStream mStream = new MemoryStream();

            pic_Picture.Image.Save(mStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            Byte[] imageArr = mStream.GetBuffer();


            try
            {
                m_BikeManager.BikeRegister(new Bike(
                    typecode,
                    bikecode,
                    m_RentalShop.Code,
                    m_RentalShop.Code,
                    txtBox_ETC.Text,
                    date.ToString().Substring(0, 10),
                    imageArr
                    ));
                MessageBox.Show("자전거등록을 성공적으로 수행하였습니다.\n자전거의 번호는\n" + bikecode + "\n입니다.");
            }
            catch(InvalidOperationException IOE)
            {
                MessageBox.Show("자전거등록을 수행 할 수 없습니다.");
            }
        }

        private void pic_Picture_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Picture.ImageLocation = ofd.FileName;

            }
        }
    }
}
