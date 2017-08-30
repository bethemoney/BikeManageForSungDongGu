using BikeManagerProgram.BikeNS;
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
    public partial class Form_Bike_Modify : Form
    {
        Bike m_Bike;
        RentalShop m_RentalShop;
        npgSQL npgsql = new npgSQL();
        BikeManager m_BikeManager;

        OpenFileDialog ofd;

        public Form_Bike_Modify(Bike bike,RentalShop rentalShop)
        {
            InitializeComponent();
            m_Bike = bike;
            m_BikeManager = new BikeManager(rentalShop);
     

            txtBox_Code.Text = bike.Code;
           
            m_RentalShop = rentalShop;

            List<RentalShop> list_RentalShops= RentManager.getRentalShops();

            for (int i = 0; i < list_RentalShops.Count;i++)
                cmboBox_InitRentalShop.Items.Add(list_RentalShops[i].Name);

            for (int i = 0; i < list_RentalShops.Count; i++)
                cmboBox_CurrentRentalShop.Items.Add(list_RentalShops[i].Name);

            List<BikeType> list_Biketype = m_BikeManager.GetBikeTypes();
            for (int i = 0; i < list_Biketype.Count; i++)
                cmboBox_Type.Items.Add(list_Biketype[i].Decription);

           
            String description = m_BikeManager.GetBikeTypeDescription(bike.Type);

            ofd = new OpenFileDialog();
            ofd.Filter = "Image  Files (*.bmp, *.gif, *.jpg, *.png)|*.bmp;*.gif;*.jpg;*.png";


            cmboBox_Type.SelectedItem = description;
            cmboBox_InitRentalShop.SelectedItem = RentManager.GetRentalShopByCode(m_Bike.InitRentalShop).Name;
            cmboBox_CurrentRentalShop.SelectedItem = RentManager.GetRentalShopByCode(m_Bike.CurrentRentalShop).Name;
            txtBox_ETC.Text = bike.ETC;
            //Date 
            dateTimePicker_RegDate.Value = DateTime.Parse(m_Bike.RegDate);


            MemoryStream ms = new MemoryStream(bike.Picture);
            Image newImage = Bitmap.FromStream(ms);

            pic_Picture.Image = newImage;

           

        }

        private void btn_BikeModify_Click(object sender, EventArgs e)
        {
            String type = m_BikeManager.GetBikeTypeCode((String)cmboBox_Type.SelectedItem);
            String initRentalShop = cmboBox_InitRentalShop.Text;
            String currentRentalShop = cmboBox_CurrentRentalShop.Text;

            MemoryStream mStream = new MemoryStream();

            pic_Picture.Image.Save(mStream,System.Drawing.Imaging.ImageFormat.Jpeg);
            Byte[] imageArr=  mStream.GetBuffer();

            m_BikeManager.BikeUpdate(new Bike(
                type,
                txtBox_Code.Text,
                RentManager.GetRentalShopByName(initRentalShop).Code,
                RentManager.GetRentalShopByName(currentRentalShop).Code,
                txtBox_ETC.Text,
                dateTimePicker_RegDate.Value.ToString(),
                imageArr));
            MessageBox.Show(txtBox_Code.Text + "자전거의 정보가 수정되었습니다.");
            this.Close();
        }

        private void pic_Picture_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pic_Picture.ImageLocation = ofd.FileName;
            }
        }

        private void btn_BikeRemove_Click(object sender, EventArgs e)
        {
            Form_Bike_DeleteConfirm form_Bike_DeleteConfirm = new Form_Bike_DeleteConfirm(m_Bike, m_RentalShop);

            form_Bike_DeleteConfirm.ShowDialog();
            if (form_Bike_DeleteConfirm.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(txtBox_Code.Text + "자전거의 정보가 삭제되었습니다.");
                this.Close();
            }
        }


    }
}
