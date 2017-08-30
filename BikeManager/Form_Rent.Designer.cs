namespace BikeManagerProgram
{
    partial class Form_Rent
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
            this.btn_Rent = new System.Windows.Forms.Button();
            this.txtBox_MemName = new System.Windows.Forms.TextBox();
            this.txtBox_BikeCode = new System.Windows.Forms.TextBox();
            this.lb_MemName = new System.Windows.Forms.Label();
            this.label_BikeName = new System.Windows.Forms.Label();
            this.lb_MemCode = new System.Windows.Forms.Label();
            this.txtBox_MemCode = new System.Windows.Forms.TextBox();
            this.lb_Sex = new System.Windows.Forms.Label();
            this.txtBox_MemSex = new System.Windows.Forms.TextBox();
            this.lb_Tel = new System.Windows.Forms.Label();
            this.txtBox_MemTel = new System.Windows.Forms.TextBox();
            this.lb_Address = new System.Windows.Forms.Label();
            this.txtBox_MemAddress = new System.Windows.Forms.TextBox();
            this.lb_BikeType = new System.Windows.Forms.Label();
            this.txtBox_BikeType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Rent
            // 
            this.btn_Rent.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Rent.Location = new System.Drawing.Point(496, 191);
            this.btn_Rent.Name = "btn_Rent";
            this.btn_Rent.Size = new System.Drawing.Size(137, 51);
            this.btn_Rent.TabIndex = 0;
            this.btn_Rent.Text = "대여";
            this.btn_Rent.UseVisualStyleBackColor = true;
            this.btn_Rent.Click += new System.EventHandler(this.btn_Rent_Click);
            // 
            // txtBox_MemName
            // 
            this.txtBox_MemName.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_MemName.Location = new System.Drawing.Point(91, 43);
            this.txtBox_MemName.Name = "txtBox_MemName";
            this.txtBox_MemName.ReadOnly = true;
            this.txtBox_MemName.Size = new System.Drawing.Size(157, 28);
            this.txtBox_MemName.TabIndex = 1;
            // 
            // txtBox_BikeCode
            // 
            this.txtBox_BikeCode.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_BikeCode.Location = new System.Drawing.Point(369, 9);
            this.txtBox_BikeCode.Name = "txtBox_BikeCode";
            this.txtBox_BikeCode.Size = new System.Drawing.Size(114, 28);
            this.txtBox_BikeCode.TabIndex = 2;
            this.txtBox_BikeCode.TextChanged += new System.EventHandler(this.txtBox_BikeCode_TextChanged);
            // 
            // lb_MemName
            // 
            this.lb_MemName.AutoSize = true;
            this.lb_MemName.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_MemName.Location = new System.Drawing.Point(7, 50);
            this.lb_MemName.Name = "lb_MemName";
            this.lb_MemName.Size = new System.Drawing.Size(78, 21);
            this.lb_MemName.TabIndex = 4;
            this.lb_MemName.Text = "회원이름";
            // 
            // label_BikeName
            // 
            this.label_BikeName.AutoSize = true;
            this.label_BikeName.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_BikeName.Location = new System.Drawing.Point(268, 16);
            this.label_BikeName.Name = "label_BikeName";
            this.label_BikeName.Size = new System.Drawing.Size(95, 21);
            this.label_BikeName.TabIndex = 5;
            this.label_BikeName.Text = "자전거코드";
            // 
            // lb_MemCode
            // 
            this.lb_MemCode.AutoSize = true;
            this.lb_MemCode.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_MemCode.Location = new System.Drawing.Point(7, 16);
            this.lb_MemCode.Name = "lb_MemCode";
            this.lb_MemCode.Size = new System.Drawing.Size(78, 21);
            this.lb_MemCode.TabIndex = 7;
            this.lb_MemCode.Text = "회원코드";
            // 
            // txtBox_MemCode
            // 
            this.txtBox_MemCode.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_MemCode.Location = new System.Drawing.Point(91, 9);
            this.txtBox_MemCode.Name = "txtBox_MemCode";
            this.txtBox_MemCode.Size = new System.Drawing.Size(157, 28);
            this.txtBox_MemCode.TabIndex = 6;
            this.txtBox_MemCode.TextChanged += new System.EventHandler(this.txtBox_MemCode_TextChanged);
            // 
            // lb_Sex
            // 
            this.lb_Sex.AutoSize = true;
            this.lb_Sex.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Sex.Location = new System.Drawing.Point(7, 84);
            this.lb_Sex.Name = "lb_Sex";
            this.lb_Sex.Size = new System.Drawing.Size(44, 21);
            this.lb_Sex.TabIndex = 9;
            this.lb_Sex.Text = "성별";
            // 
            // txtBox_MemSex
            // 
            this.txtBox_MemSex.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_MemSex.Location = new System.Drawing.Point(91, 77);
            this.txtBox_MemSex.Name = "txtBox_MemSex";
            this.txtBox_MemSex.ReadOnly = true;
            this.txtBox_MemSex.Size = new System.Drawing.Size(157, 28);
            this.txtBox_MemSex.TabIndex = 8;
            // 
            // lb_Tel
            // 
            this.lb_Tel.AutoSize = true;
            this.lb_Tel.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Tel.Location = new System.Drawing.Point(7, 118);
            this.lb_Tel.Name = "lb_Tel";
            this.lb_Tel.Size = new System.Drawing.Size(78, 21);
            this.lb_Tel.TabIndex = 11;
            this.lb_Tel.Text = "전화번호";
            // 
            // txtBox_MemTel
            // 
            this.txtBox_MemTel.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_MemTel.Location = new System.Drawing.Point(91, 111);
            this.txtBox_MemTel.Name = "txtBox_MemTel";
            this.txtBox_MemTel.ReadOnly = true;
            this.txtBox_MemTel.Size = new System.Drawing.Size(157, 28);
            this.txtBox_MemTel.TabIndex = 10;
            // 
            // lb_Address
            // 
            this.lb_Address.AutoSize = true;
            this.lb_Address.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Address.Location = new System.Drawing.Point(7, 152);
            this.lb_Address.Name = "lb_Address";
            this.lb_Address.Size = new System.Drawing.Size(44, 21);
            this.lb_Address.TabIndex = 13;
            this.lb_Address.Text = "주소";
            // 
            // txtBox_MemAddress
            // 
            this.txtBox_MemAddress.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_MemAddress.Location = new System.Drawing.Point(91, 145);
            this.txtBox_MemAddress.Name = "txtBox_MemAddress";
            this.txtBox_MemAddress.ReadOnly = true;
            this.txtBox_MemAddress.Size = new System.Drawing.Size(533, 28);
            this.txtBox_MemAddress.TabIndex = 12;
            // 
            // lb_BikeType
            // 
            this.lb_BikeType.AutoSize = true;
            this.lb_BikeType.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BikeType.Location = new System.Drawing.Point(268, 50);
            this.lb_BikeType.Name = "lb_BikeType";
            this.lb_BikeType.Size = new System.Drawing.Size(95, 21);
            this.lb_BikeType.TabIndex = 15;
            this.lb_BikeType.Text = "자전거타입";
            // 
            // txtBox_BikeType
            // 
            this.txtBox_BikeType.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_BikeType.Location = new System.Drawing.Point(369, 43);
            this.txtBox_BikeType.Name = "txtBox_BikeType";
            this.txtBox_BikeType.ReadOnly = true;
            this.txtBox_BikeType.Size = new System.Drawing.Size(114, 28);
            this.txtBox_BikeType.TabIndex = 14;
            // 
            // Form_Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 259);
            this.Controls.Add(this.lb_BikeType);
            this.Controls.Add(this.txtBox_BikeType);
            this.Controls.Add(this.lb_Address);
            this.Controls.Add(this.txtBox_MemAddress);
            this.Controls.Add(this.lb_Tel);
            this.Controls.Add(this.txtBox_MemTel);
            this.Controls.Add(this.lb_Sex);
            this.Controls.Add(this.txtBox_MemSex);
            this.Controls.Add(this.lb_MemCode);
            this.Controls.Add(this.txtBox_MemCode);
            this.Controls.Add(this.label_BikeName);
            this.Controls.Add(this.lb_MemName);
            this.Controls.Add(this.txtBox_BikeCode);
            this.Controls.Add(this.txtBox_MemName);
            this.Controls.Add(this.btn_Rent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form_Rent";
            this.Text = "Form_Rent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Rent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Rent;
        private System.Windows.Forms.TextBox txtBox_MemName;
        private System.Windows.Forms.TextBox txtBox_BikeCode;
        private System.Windows.Forms.Label lb_MemName;
        private System.Windows.Forms.Label label_BikeName;
        private System.Windows.Forms.Label lb_MemCode;
        private System.Windows.Forms.TextBox txtBox_MemCode;
        private System.Windows.Forms.Label lb_Sex;
        private System.Windows.Forms.TextBox txtBox_MemSex;
        private System.Windows.Forms.Label lb_Tel;
        private System.Windows.Forms.TextBox txtBox_MemTel;
        private System.Windows.Forms.Label lb_Address;
        private System.Windows.Forms.TextBox txtBox_MemAddress;
        private System.Windows.Forms.Label lb_BikeType;
        private System.Windows.Forms.TextBox txtBox_BikeType;
    }
}