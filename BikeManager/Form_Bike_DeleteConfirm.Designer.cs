namespace BikeManagerProgram
{
    partial class Form_Bike_DeleteConfirm
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.lb_Warning = new System.Windows.Forms.Label();
            this.txtBox_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_OK.Location = new System.Drawing.Point(367, 71);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 28);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "확인";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // lb_Warning
            // 
            this.lb_Warning.AutoSize = true;
            this.lb_Warning.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Warning.Location = new System.Drawing.Point(12, 9);
            this.lb_Warning.Name = "lb_Warning";
            this.lb_Warning.Size = new System.Drawing.Size(431, 42);
            this.lb_Warning.TabIndex = 1;
            this.lb_Warning.Text = "정말로 자전거를 삭제하시겠습니까?\r\n삭제하시려면 아래에 대여소 비밀번호를 입력하십시오.";
            // 
            // txtBox_Password
            // 
            this.txtBox_Password.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_Password.Location = new System.Drawing.Point(16, 71);
            this.txtBox_Password.Name = "txtBox_Password";
            this.txtBox_Password.Size = new System.Drawing.Size(345, 28);
            this.txtBox_Password.TabIndex = 2;
            // 
            // Form_Bike_DeleteConfirm
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 115);
            this.Controls.Add(this.txtBox_Password);
            this.Controls.Add(this.lb_Warning);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Bike_DeleteConfirm";
            this.Text = "Form_MemberDeleteConfirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Label lb_Warning;
        private System.Windows.Forms.TextBox txtBox_Password;
    }
}