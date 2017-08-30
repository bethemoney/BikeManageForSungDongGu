namespace BikeManagerProgram
{
    partial class Form_Return
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
            this.txtBox_BikeCode = new System.Windows.Forms.TextBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.lb_BikeCode = new System.Windows.Forms.Label();
            this.lb_BikeStatus = new System.Windows.Forms.Label();
            this.txtBox_BikeStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_BikeCode
            // 
            this.txtBox_BikeCode.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_BikeCode.Location = new System.Drawing.Point(131, 8);
            this.txtBox_BikeCode.Name = "txtBox_BikeCode";
            this.txtBox_BikeCode.Size = new System.Drawing.Size(183, 28);
            this.txtBox_BikeCode.TabIndex = 0;
            this.txtBox_BikeCode.TextChanged += new System.EventHandler(this.txtBox_BikeCode_TextChanged);
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Return.Location = new System.Drawing.Point(239, 80);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 31);
            this.btn_Return.TabIndex = 1;
            this.btn_Return.Text = "반납";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // lb_BikeCode
            // 
            this.lb_BikeCode.AutoSize = true;
            this.lb_BikeCode.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BikeCode.Location = new System.Drawing.Point(12, 11);
            this.lb_BikeCode.Name = "lb_BikeCode";
            this.lb_BikeCode.Size = new System.Drawing.Size(113, 21);
            this.lb_BikeCode.TabIndex = 2;
            this.lb_BikeCode.Text = "자전거 코드: ";
            // 
            // lb_BikeStatus
            // 
            this.lb_BikeStatus.AutoSize = true;
            this.lb_BikeStatus.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BikeStatus.Location = new System.Drawing.Point(12, 49);
            this.lb_BikeStatus.Name = "lb_BikeStatus";
            this.lb_BikeStatus.Size = new System.Drawing.Size(113, 21);
            this.lb_BikeStatus.TabIndex = 4;
            this.lb_BikeStatus.Text = "자전거 상태: ";
            // 
            // txtBox_BikeStatus
            // 
            this.txtBox_BikeStatus.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBox_BikeStatus.Location = new System.Drawing.Point(131, 42);
            this.txtBox_BikeStatus.Name = "txtBox_BikeStatus";
            this.txtBox_BikeStatus.ReadOnly = true;
            this.txtBox_BikeStatus.Size = new System.Drawing.Size(183, 28);
            this.txtBox_BikeStatus.TabIndex = 3;
            // 
            // Form_Return
            // 
            this.AcceptButton = this.btn_Return;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 123);
            this.Controls.Add(this.lb_BikeStatus);
            this.Controls.Add(this.txtBox_BikeStatus);
            this.Controls.Add(this.lb_BikeCode);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.txtBox_BikeCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Return";
            this.Text = "Form_Return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_BikeCode;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label lb_BikeCode;
        private System.Windows.Forms.Label lb_BikeStatus;
        private System.Windows.Forms.TextBox txtBox_BikeStatus;
    }
}