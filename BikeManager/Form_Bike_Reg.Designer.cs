namespace BikeManagerProgram
{
    partial class Form_Bike_Reg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bike_Reg));
            this.btn_BikeReg = new System.Windows.Forms.Button();
            this.lb_BikeReg_ETC = new System.Windows.Forms.Label();
            this.txtBox_ETC = new System.Windows.Forms.TextBox();
            this.lb_BikeReg_RentalShop = new System.Windows.Forms.Label();
            this.lb_BikeReg_Type = new System.Windows.Forms.Label();
            this.cmboBox_Type = new System.Windows.Forms.ComboBox();
            this.txtBox_RentalShop = new System.Windows.Forms.TextBox();
            this.pic_Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_BikeReg
            // 
            this.btn_BikeReg.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_BikeReg.Location = new System.Drawing.Point(636, 185);
            this.btn_BikeReg.Name = "btn_BikeReg";
            this.btn_BikeReg.Size = new System.Drawing.Size(114, 31);
            this.btn_BikeReg.TabIndex = 34;
            this.btn_BikeReg.Text = "자전거등록";
            this.btn_BikeReg.UseVisualStyleBackColor = true;
            this.btn_BikeReg.Click += new System.EventHandler(this.btn_BikeReg_Click);
            // 
            // lb_BikeReg_ETC
            // 
            this.lb_BikeReg_ETC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_BikeReg_ETC.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BikeReg_ETC.Location = new System.Drawing.Point(138, 82);
            this.lb_BikeReg_ETC.Name = "lb_BikeReg_ETC";
            this.lb_BikeReg_ETC.Size = new System.Drawing.Size(81, 31);
            this.lb_BikeReg_ETC.TabIndex = 33;
            this.lb_BikeReg_ETC.Text = "기타사항";
            this.lb_BikeReg_ETC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_ETC
            // 
            this.txtBox_ETC.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_ETC.Location = new System.Drawing.Point(225, 82);
            this.txtBox_ETC.Name = "txtBox_ETC";
            this.txtBox_ETC.Size = new System.Drawing.Size(525, 28);
            this.txtBox_ETC.TabIndex = 32;
            // 
            // lb_BikeReg_RentalShop
            // 
            this.lb_BikeReg_RentalShop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_BikeReg_RentalShop.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BikeReg_RentalShop.Location = new System.Drawing.Point(138, 48);
            this.lb_BikeReg_RentalShop.Name = "lb_BikeReg_RentalShop";
            this.lb_BikeReg_RentalShop.Size = new System.Drawing.Size(81, 31);
            this.lb_BikeReg_RentalShop.TabIndex = 31;
            this.lb_BikeReg_RentalShop.Text = "등록지";
            this.lb_BikeReg_RentalShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_BikeReg_Type
            // 
            this.lb_BikeReg_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_BikeReg_Type.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BikeReg_Type.Location = new System.Drawing.Point(138, 12);
            this.lb_BikeReg_Type.Name = "lb_BikeReg_Type";
            this.lb_BikeReg_Type.Size = new System.Drawing.Size(81, 31);
            this.lb_BikeReg_Type.TabIndex = 29;
            this.lb_BikeReg_Type.Text = "종류";
            this.lb_BikeReg_Type.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmboBox_Type
            // 
            this.cmboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox_Type.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmboBox_Type.FormattingEnabled = true;
            this.cmboBox_Type.Location = new System.Drawing.Point(225, 13);
            this.cmboBox_Type.Name = "cmboBox_Type";
            this.cmboBox_Type.Size = new System.Drawing.Size(121, 29);
            this.cmboBox_Type.TabIndex = 35;
            // 
            // txtBox_RentalShop
            // 
            this.txtBox_RentalShop.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_RentalShop.Location = new System.Drawing.Point(225, 48);
            this.txtBox_RentalShop.Name = "txtBox_RentalShop";
            this.txtBox_RentalShop.ReadOnly = true;
            this.txtBox_RentalShop.Size = new System.Drawing.Size(100, 28);
            this.txtBox_RentalShop.TabIndex = 37;
            // 
            // pic_Picture
            // 
            this.pic_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Picture.Image = ((System.Drawing.Image)(resources.GetObject("pic_Picture.Image")));
            this.pic_Picture.Location = new System.Drawing.Point(12, 12);
            this.pic_Picture.Name = "pic_Picture";
            this.pic_Picture.Size = new System.Drawing.Size(120, 160);
            this.pic_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Picture.TabIndex = 25;
            this.pic_Picture.TabStop = false;
            this.pic_Picture.Click += new System.EventHandler(this.pic_Picture_Click);
            // 
            // Form_Bike_Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 231);
            this.Controls.Add(this.txtBox_RentalShop);
            this.Controls.Add(this.cmboBox_Type);
            this.Controls.Add(this.btn_BikeReg);
            this.Controls.Add(this.lb_BikeReg_ETC);
            this.Controls.Add(this.txtBox_ETC);
            this.Controls.Add(this.lb_BikeReg_RentalShop);
            this.Controls.Add(this.lb_BikeReg_Type);
            this.Controls.Add(this.pic_Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Bike_Reg";
            this.Text = "Form_BikeReg";
            ((System.ComponentModel.ISupportInitialize)(this.pic_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_BikeReg;
        private System.Windows.Forms.Label lb_BikeReg_ETC;
        private System.Windows.Forms.TextBox txtBox_ETC;
        private System.Windows.Forms.Label lb_BikeReg_RentalShop;
        private System.Windows.Forms.Label lb_BikeReg_Type;
        private System.Windows.Forms.PictureBox pic_Picture;
        private System.Windows.Forms.ComboBox cmboBox_Type;
        private System.Windows.Forms.TextBox txtBox_RentalShop;
    }
}