namespace BikeManagerProgram
{
    partial class Form_Member_Reg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Member_Reg));
            this.cmboBox_Sex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_MemReg = new System.Windows.Forms.Button();
            this.lb_ETC = new System.Windows.Forms.Label();
            this.txtBox_ETC = new System.Windows.Forms.TextBox();
            this.txtBox_Address = new System.Windows.Forms.TextBox();
            this.cmboBox_County = new System.Windows.Forms.ComboBox();
            this.cmboBox_City = new System.Windows.Forms.ComboBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.lb_Tel = new System.Windows.Forms.Label();
            this.txtBox_Tel = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.pic_Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboBox_Sex
            // 
            this.cmboBox_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox_Sex.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmboBox_Sex.FormattingEnabled = true;
            this.cmboBox_Sex.Items.AddRange(new object[] {
            "남자",
            "여자"});
            this.cmboBox_Sex.Location = new System.Drawing.Point(437, 12);
            this.cmboBox_Sex.Name = "cmboBox_Sex";
            this.cmboBox_Sex.Size = new System.Drawing.Size(78, 29);
            this.cmboBox_Sex.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(350, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 73;
            this.label1.Text = "성별";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_MemReg
            // 
            this.btn_MemReg.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_MemReg.Location = new System.Drawing.Point(664, 194);
            this.btn_MemReg.Name = "btn_MemReg";
            this.btn_MemReg.Size = new System.Drawing.Size(114, 31);
            this.btn_MemReg.TabIndex = 72;
            this.btn_MemReg.Text = "회원 등록";
            this.btn_MemReg.UseVisualStyleBackColor = true;
            this.btn_MemReg.Click += new System.EventHandler(this.btn_MemReg_Click);
            // 
            // lb_ETC
            // 
            this.lb_ETC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_ETC.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_ETC.Location = new System.Drawing.Point(152, 114);
            this.lb_ETC.Name = "lb_ETC";
            this.lb_ETC.Size = new System.Drawing.Size(81, 31);
            this.lb_ETC.TabIndex = 71;
            this.lb_ETC.Text = "기타사항";
            this.lb_ETC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_ETC
            // 
            this.txtBox_ETC.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_ETC.Location = new System.Drawing.Point(239, 114);
            this.txtBox_ETC.Name = "txtBox_ETC";
            this.txtBox_ETC.Size = new System.Drawing.Size(539, 28);
            this.txtBox_ETC.TabIndex = 70;
            // 
            // txtBox_Address
            // 
            this.txtBox_Address.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_Address.Location = new System.Drawing.Point(493, 80);
            this.txtBox_Address.Name = "txtBox_Address";
            this.txtBox_Address.Size = new System.Drawing.Size(285, 28);
            this.txtBox_Address.TabIndex = 69;
            // 
            // cmboBox_County
            // 
            this.cmboBox_County.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmboBox_County.FormattingEnabled = true;
            this.cmboBox_County.Location = new System.Drawing.Point(366, 80);
            this.cmboBox_County.Name = "cmboBox_County";
            this.cmboBox_County.Size = new System.Drawing.Size(121, 29);
            this.cmboBox_County.TabIndex = 68;
            // 
            // cmboBox_City
            // 
            this.cmboBox_City.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmboBox_City.FormattingEnabled = true;
            this.cmboBox_City.Location = new System.Drawing.Point(239, 80);
            this.cmboBox_City.Name = "cmboBox_City";
            this.cmboBox_City.Size = new System.Drawing.Size(121, 29);
            this.cmboBox_City.TabIndex = 67;
            this.cmboBox_City.SelectedIndexChanged += new System.EventHandler(this.cmboBox_City_SelectedIndexChanged);
            // 
            // lb_Address
            // 
            this.lb_Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Address.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Address.Location = new System.Drawing.Point(152, 80);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(81, 31);
            this.lb_Address.TabIndex = 66;
            this.lb_Address.Text = "주소";
            this.lb_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Tel
            // 
            this.lb_Tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Tel.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Tel.Location = new System.Drawing.Point(152, 46);
            this.lb_Tel.Name = "lb_Tel";
            this.lb_Tel.Size = new System.Drawing.Size(81, 31);
            this.lb_Tel.TabIndex = 63;
            this.lb_Tel.Text = "전화번호";
            this.lb_Tel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_Tel
            // 
            this.txtBox_Tel.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_Tel.Location = new System.Drawing.Point(239, 46);
            this.txtBox_Tel.Name = "txtBox_Tel";
            this.txtBox_Tel.Size = new System.Drawing.Size(105, 28);
            this.txtBox_Tel.TabIndex = 62;
            // 
            // lb_Name
            // 
            this.lb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Name.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Name.Location = new System.Drawing.Point(152, 12);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(81, 31);
            this.lb_Name.TabIndex = 61;
            this.lb_Name.Text = "회원명";
            this.lb_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_Name.Location = new System.Drawing.Point(239, 12);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(105, 28);
            this.txtBox_Name.TabIndex = 60;
            // 
            // pic_Picture
            // 
            this.pic_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Picture.Image = ((System.Drawing.Image)(resources.GetObject("pic_Picture.Image")));
            this.pic_Picture.Location = new System.Drawing.Point(12, 12);
            this.pic_Picture.Name = "pic_Picture";
            this.pic_Picture.Size = new System.Drawing.Size(134, 170);
            this.pic_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Picture.TabIndex = 59;
            this.pic_Picture.TabStop = false;
            this.pic_Picture.Click += new System.EventHandler(this.pic_Picture_Click);
            // 
            // Form_Member_Reg
            // 
            this.AcceptButton = this.btn_MemReg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 235);
            this.Controls.Add(this.cmboBox_Sex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_MemReg);
            this.Controls.Add(this.lb_ETC);
            this.Controls.Add(this.txtBox_ETC);
            this.Controls.Add(this.txtBox_Address);
            this.Controls.Add(this.cmboBox_County);
            this.Controls.Add(this.cmboBox_City);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.lb_Tel);
            this.Controls.Add(this.txtBox_Tel);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.pic_Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Member_Reg";
            this.Text = "회원 등록";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboBox_Sex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_MemReg;
        private System.Windows.Forms.Label lb_ETC;
        private System.Windows.Forms.TextBox txtBox_ETC;
        private System.Windows.Forms.TextBox txtBox_Address;
        private System.Windows.Forms.ComboBox cmboBox_County;
        private System.Windows.Forms.ComboBox cmboBox_City;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.Label lb_Tel;
        private System.Windows.Forms.TextBox txtBox_Tel;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.PictureBox pic_Picture;
    }
}