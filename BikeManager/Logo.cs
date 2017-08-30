using BikeManagerProgram.RentNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BikeManagerProgram
{
    partial class Logo : Form
    {
        RentalShop m_RentalShop;

        npgSQL npgsql = new npgSQL();
        
        public Logo()
        {
            InitializeComponent();
            this.Text = String.Format("{0} 정보", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("버전 {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            npgsql.DBConnect();
            String sql = @"select * FROM ""RentalShop""";
            IDataReader Reader = npgsql.ExecuteQuery(sql);
            while(Reader.Read())
            {
                cmboBox_Logo_RentalShop.Items.Add((String)Reader["Name"]);
            }
            npgsql.DBClose();
        }

        #region 어셈블리 특성 접근자

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion


        private void okButton_Click(object sender, EventArgs e)
        {
            npgsql.DBConnect();
            String sql = @"select password from ""RentalShop"" where name='" + cmboBox_Logo_RentalShop.Text + "'";
            IDataReader Reader = npgsql.ExecuteQuery(sql);

            Reader.Read();
            Boolean isPasswordConfirm = txtBox_Password.Text.Equals(Reader["password"]);
            npgsql.DBClose();

            if (!isPasswordConfirm)
            {
                MessageBox.Show("비밀번호가 맞지않습니다.");
            }
            else
            {
                this.m_RentalShop = RentManager.GetRentalShopByName(cmboBox_Logo_RentalShop.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            
            


        }
        public RentalShop getRentalShop()
        {
            return this.m_RentalShop;
        }


    }
}
