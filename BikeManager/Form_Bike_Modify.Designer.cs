namespace BikeManagerProgram
{
    partial class Form_Bike_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bike_Modify));
            this.btn_BikeModify = new System.Windows.Forms.Button();
            this.lb_BikeReg_ETC = new System.Windows.Forms.Label();
            this.txtBox_ETC = new System.Windows.Forms.TextBox();
            this.lb_InitRentalShop = new System.Windows.Forms.Label();
            this.lb_Code = new System.Windows.Forms.Label();
            this.txtBox_Code = new System.Windows.Forms.TextBox();
            this.pic_Picture = new System.Windows.Forms.PictureBox();
            this.lb_BikeReg_Type = new System.Windows.Forms.Label();
            this.cmboBox_Type = new System.Windows.Forms.ComboBox();
            this.cmboBox_InitRentalShop = new System.Windows.Forms.ComboBox();
            this.cmboBox_CurrentRentalShop = new System.Windows.Forms.ComboBox();
            this.lb_CurrentRentalShop = new System.Windows.Forms.Label();
            this.dateTimePicker_RegDate = new System.Windows.Forms.DateTimePicker();
            this.lb_RegDate = new System.Windows.Forms.Label();
            this.btn_BikeRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BikeModify
            // 
            this.btn_BikeModify.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_BikeModify.Location = new System.Drawing.Point(701, 187);
            this.btn_BikeModify.Name = "btn_BikeModify";
            this.btn_BikeModify.Size = new System.Drawing.Size(114, 31);
            this.btn_BikeModify.TabIndex = 44;
            this.btn_BikeModify.Text = "자전거수정";
            this.btn_BikeModify.UseVisualStyleBackColor = true;
            this.btn_BikeModify.Click += new System.EventHandler(this.btn_BikeModify_Click);
            // 
            // lb_BikeReg_ETC
            // 
            this.lb_BikeReg_ETC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_BikeReg_ETC.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BikeReg_ETC.Location = new System.Drawing.Point(153, 116);
            this.lb_BikeReg_ETC.Name = "lb_BikeReg_ETC";
            this.lb_BikeReg_ETC.Size = new System.Drawing.Size(101, 31);
            this.lb_BikeReg_ETC.TabIndex = 43;
            this.lb_BikeReg_ETC.Text = "기타사항";
            this.lb_BikeReg_ETC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_ETC
            // 
            this.txtBox_ETC.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_ETC.Location = new System.Drawing.Point(260, 116);
            this.txtBox_ETC.Name = "txtBox_ETC";
            this.txtBox_ETC.Size = new System.Drawing.Size(555, 28);
            this.txtBox_ETC.TabIndex = 42;
            // 
            // lb_InitRentalShop
            // 
            this.lb_InitRentalShop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_InitRentalShop.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_InitRentalShop.Location = new System.Drawing.Point(153, 81);
            this.lb_InitRentalShop.Name = "lb_InitRentalShop";
            this.lb_InitRentalShop.Size = new System.Drawing.Size(101, 31);
            this.lb_InitRentalShop.TabIndex = 41;
            this.lb_InitRentalShop.Text = "등록지";
            this.lb_InitRentalShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Code
            // 
            this.lb_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Code.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Code.Location = new System.Drawing.Point(153, 12);
            this.lb_Code.Name = "lb_Code";
            this.lb_Code.Size = new System.Drawing.Size(101, 31);
            this.lb_Code.TabIndex = 37;
            this.lb_Code.Text = "자전거코드";
            this.lb_Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_Code
            // 
            this.txtBox_Code.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_Code.Location = new System.Drawing.Point(260, 12);
            this.txtBox_Code.Name = "txtBox_Code";
            this.txtBox_Code.ReadOnly = true;
            this.txtBox_Code.Size = new System.Drawing.Size(143, 28);
            this.txtBox_Code.TabIndex = 36;
            // 
            // pic_Picture
            // 
            this.pic_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Picture.Image = ((System.Drawing.Image)(resources.GetObject("pic_Picture.Image")));
            this.pic_Picture.Location = new System.Drawing.Point(12, 12);
            this.pic_Picture.Name = "pic_Picture";
            this.pic_Picture.Size = new System.Drawing.Size(135, 169);
            this.pic_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Picture.TabIndex = 35;
            this.pic_Picture.TabStop = false;
            this.pic_Picture.Click += new System.EventHandler(this.pic_Picture_Click);
            // 
            // lb_BikeReg_Type
            // 
            this.lb_BikeReg_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_BikeReg_Type.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BikeReg_Type.Location = new System.Drawing.Point(153, 46);
            this.lb_BikeReg_Type.Name = "lb_BikeReg_Type";
            this.lb_BikeReg_Type.Size = new System.Drawing.Size(101, 31);
            this.lb_BikeReg_Type.TabIndex = 39;
            this.lb_BikeReg_Type.Text = "종류";
            this.lb_BikeReg_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmboBox_Type
            // 
            this.cmboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox_Type.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmboBox_Type.FormattingEnabled = true;
            this.cmboBox_Type.Location = new System.Drawing.Point(260, 46);
            this.cmboBox_Type.Name = "cmboBox_Type";
            this.cmboBox_Type.Size = new System.Drawing.Size(121, 29);
            this.cmboBox_Type.TabIndex = 46;
            // 
            // cmboBox_InitRentalShop
            // 
            this.cmboBox_InitRentalShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox_InitRentalShop.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmboBox_InitRentalShop.FormattingEnabled = true;
            this.cmboBox_InitRentalShop.Location = new System.Drawing.Point(260, 81);
            this.cmboBox_InitRentalShop.Name = "cmboBox_InitRentalShop";
            this.cmboBox_InitRentalShop.Size = new System.Drawing.Size(121, 29);
            this.cmboBox_InitRentalShop.TabIndex = 47;
            // 
            // cmboBox_CurrentRentalShop
            // 
            this.cmboBox_CurrentRentalShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox_CurrentRentalShop.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmboBox_CurrentRentalShop.FormattingEnabled = true;
            this.cmboBox_CurrentRentalShop.Location = new System.Drawing.Point(474, 81);
            this.cmboBox_CurrentRentalShop.Name = "cmboBox_CurrentRentalShop";
            this.cmboBox_CurrentRentalShop.Size = new System.Drawing.Size(134, 29);
            this.cmboBox_CurrentRentalShop.TabIndex = 49;
            // 
            // lb_CurrentRentalShop
            // 
            this.lb_CurrentRentalShop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_CurrentRentalShop.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_CurrentRentalShop.Location = new System.Drawing.Point(387, 81);
            this.lb_CurrentRentalShop.Name = "lb_CurrentRentalShop";
            this.lb_CurrentRentalShop.Size = new System.Drawing.Size(81, 31);
            this.lb_CurrentRentalShop.TabIndex = 48;
            this.lb_CurrentRentalShop.Text = "현재위치";
            this.lb_CurrentRentalShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_RegDate
            // 
            this.dateTimePicker_RegDate.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker_RegDate.Location = new System.Drawing.Point(260, 153);
            this.dateTimePicker_RegDate.Name = "dateTimePicker_RegDate";
            this.dateTimePicker_RegDate.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker_RegDate.TabIndex = 50;
            // 
            // lb_RegDate
            // 
            this.lb_RegDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_RegDate.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_RegDate.Location = new System.Drawing.Point(153, 150);
            this.lb_RegDate.Name = "lb_RegDate";
            this.lb_RegDate.Size = new System.Drawing.Size(101, 31);
            this.lb_RegDate.TabIndex = 51;
            this.lb_RegDate.Text = "등록지";
            this.lb_RegDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_BikeRemove
            // 
            this.btn_BikeRemove.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_BikeRemove.Location = new System.Drawing.Point(12, 187);
            this.btn_BikeRemove.Name = "btn_BikeRemove";
            this.btn_BikeRemove.Size = new System.Drawing.Size(114, 31);
            this.btn_BikeRemove.TabIndex = 52;
            this.btn_BikeRemove.Text = "자전거삭제";
            this.btn_BikeRemove.UseVisualStyleBackColor = true;
            this.btn_BikeRemove.Click += new System.EventHandler(this.btn_BikeRemove_Click);
            // 
            // Form_Bike_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 226);
            this.Controls.Add(this.btn_BikeRemove);
            this.Controls.Add(this.lb_RegDate);
            this.Controls.Add(this.dateTimePicker_RegDate);
            this.Controls.Add(this.cmboBox_CurrentRentalShop);
            this.Controls.Add(this.lb_CurrentRentalShop);
            this.Controls.Add(this.cmboBox_InitRentalShop);
            this.Controls.Add(this.cmboBox_Type);
            this.Controls.Add(this.btn_BikeModify);
            this.Controls.Add(this.lb_BikeReg_ETC);
            this.Controls.Add(this.txtBox_ETC);
            this.Controls.Add(this.lb_InitRentalShop);
            this.Controls.Add(this.lb_BikeReg_Type);
            this.Controls.Add(this.lb_Code);
            this.Controls.Add(this.txtBox_Code);
            this.Controls.Add(this.pic_Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Bike_Modify";
            this.Text = "Form_Bike_Modify";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BikeModify;
        private System.Windows.Forms.Label lb_BikeReg_ETC;
        private System.Windows.Forms.TextBox txtBox_ETC;
        private System.Windows.Forms.Label lb_InitRentalShop;
        private System.Windows.Forms.Label lb_Code;
        private System.Windows.Forms.TextBox txtBox_Code;
        private System.Windows.Forms.PictureBox pic_Picture;
        private System.Windows.Forms.Label lb_BikeReg_Type;
        private System.Windows.Forms.ComboBox cmboBox_Type;
        private System.Windows.Forms.ComboBox cmboBox_InitRentalShop;
        private System.Windows.Forms.ComboBox cmboBox_CurrentRentalShop;
        private System.Windows.Forms.Label lb_CurrentRentalShop;
        private System.Windows.Forms.DateTimePicker dateTimePicker_RegDate;
        private System.Windows.Forms.Label lb_RegDate;
        private System.Windows.Forms.Button btn_BikeRemove;
    }
}