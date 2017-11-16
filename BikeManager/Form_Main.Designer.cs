using System;
namespace BikeManagerProgram
{
    partial class Form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Rent = new System.Windows.Forms.TabPage();
            this.radioBtn_Returned = new System.Windows.Forms.RadioButton();
            this.radioBtn_Renting = new System.Windows.Forms.RadioButton();
            this.radioBtn_All = new System.Windows.Forms.RadioButton();
            this.btn_Return = new System.Windows.Forms.Button();
            this.dataGridView_Rent = new System.Windows.Forms.DataGridView();
            this.dgv_RentList_RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_RentList_ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_RentList_Bike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_RentList_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_RentList_MemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_RentList_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_RentList_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_Rent_BikeName = new System.Windows.Forms.Label();
            this.txtBox_Rent_BikeName = new System.Windows.Forms.TextBox();
            this.lb_Rent_MemName = new System.Windows.Forms.Label();
            this.txtBox_Rent_MemName = new System.Windows.Forms.TextBox();
            this.btn_Rent = new System.Windows.Forms.Button();
            this.tabPage_MemberManage = new System.Windows.Forms.TabPage();
            this.btn_MemReg = new System.Windows.Forms.Button();
            this.lb_MemList_Name = new System.Windows.Forms.Label();
            this.txtBox_MemList_Name = new System.Windows.Forms.TextBox();
            this.dataGridView_MemList = new System.Windows.Forms.DataGridView();
            this.dgv_MemList_Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MemList_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MemList_RegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MemList_TelNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MemList_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_MemList_ETC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_BikeManage = new System.Windows.Forms.TabPage();
            this.btn_BikeReg = new System.Windows.Forms.Button();
            this.lb_BikeList_Code = new System.Windows.Forms.Label();
            this.txtBox_BikeList_Code = new System.Windows.Forms.TextBox();
            this.dataGridView_BikeList = new System.Windows.Forms.DataGridView();
            this.dgv_BikeList_BikeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BikeList_BikeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BikeList_InitialRentalShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BikeList_CurrentRentalShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BikeList_ETC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_BikeList_BikeRegDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Statistic = new System.Windows.Forms.TabPage();
            this.btn_export_member = new System.Windows.Forms.Button();
            this.cmboBox_Statistic_BikeType = new System.Windows.Forms.ComboBox();
            this.cmboBox_Statistic_Sex = new System.Windows.Forms.ComboBox();
            this.dataGridView_Statistic = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmboBox_Statistic_RentalShop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_Statistic_End = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Statistic_Start = new System.Windows.Forms.DateTimePicker();
            this.dgv_Rent_RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Rent_ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Rent_RentBike = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Rent_RentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Rent_MemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Rent_MemNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Rent_MemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Rent_MemTelNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Rent_MemAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_export_bike = new System.Windows.Forms.Button();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Rent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rent)).BeginInit();
            this.tabPage_MemberManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MemList)).BeginInit();
            this.tabPage_BikeManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BikeList)).BeginInit();
            this.tabPage_Statistic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Statistic)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl_Main.Controls.Add(this.tabPage_Rent);
            this.tabControl_Main.Controls.Add(this.tabPage_MemberManage);
            this.tabControl_Main.Controls.Add(this.tabPage_BikeManage);
            this.tabControl_Main.Controls.Add(this.tabPage_Statistic);
            this.tabControl_Main.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl_Main.HotTrack = true;
            this.tabControl_Main.ItemSize = new System.Drawing.Size(150, 70);
            this.tabControl_Main.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1055, 579);
            this.tabControl_Main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Main.TabIndex = 5;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.tabControl_Main_SelectedIndexChanged);
            this.tabControl_Main.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabControl_Main_KeyPress);
            // 
            // tabPage_Rent
            // 
            this.tabPage_Rent.Controls.Add(this.radioBtn_Returned);
            this.tabPage_Rent.Controls.Add(this.radioBtn_Renting);
            this.tabPage_Rent.Controls.Add(this.radioBtn_All);
            this.tabPage_Rent.Controls.Add(this.btn_Return);
            this.tabPage_Rent.Controls.Add(this.dataGridView_Rent);
            this.tabPage_Rent.Controls.Add(this.lb_Rent_BikeName);
            this.tabPage_Rent.Controls.Add(this.txtBox_Rent_BikeName);
            this.tabPage_Rent.Controls.Add(this.lb_Rent_MemName);
            this.tabPage_Rent.Controls.Add(this.txtBox_Rent_MemName);
            this.tabPage_Rent.Controls.Add(this.btn_Rent);
            this.tabPage_Rent.Location = new System.Drawing.Point(4, 74);
            this.tabPage_Rent.Name = "tabPage_Rent";
            this.tabPage_Rent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Rent.Size = new System.Drawing.Size(1047, 501);
            this.tabPage_Rent.TabIndex = 0;
            this.tabPage_Rent.Text = "대여";
            this.tabPage_Rent.UseVisualStyleBackColor = true;
            this.tabPage_Rent.Enter += new System.EventHandler(this.tabPage_Rent_Enter);
            // 
            // radioBtn_Returned
            // 
            this.radioBtn_Returned.AutoSize = true;
            this.radioBtn_Returned.Location = new System.Drawing.Point(693, 15);
            this.radioBtn_Returned.Name = "radioBtn_Returned";
            this.radioBtn_Returned.Size = new System.Drawing.Size(96, 25);
            this.radioBtn_Returned.TabIndex = 5;
            this.radioBtn_Returned.TabStop = true;
            this.radioBtn_Returned.Text = "반납완료";
            this.radioBtn_Returned.UseVisualStyleBackColor = true;
            this.radioBtn_Returned.Click += new System.EventHandler(this.radioBtn_Returned_Click);
            // 
            // radioBtn_Renting
            // 
            this.radioBtn_Renting.AutoSize = true;
            this.radioBtn_Renting.Location = new System.Drawing.Point(608, 15);
            this.radioBtn_Renting.Name = "radioBtn_Renting";
            this.radioBtn_Renting.Size = new System.Drawing.Size(79, 25);
            this.radioBtn_Renting.TabIndex = 4;
            this.radioBtn_Renting.TabStop = true;
            this.radioBtn_Renting.Text = "대여중";
            this.radioBtn_Renting.UseVisualStyleBackColor = true;
            this.radioBtn_Renting.Click += new System.EventHandler(this.radioBtn_Renting_Click);
            // 
            // radioBtn_All
            // 
            this.radioBtn_All.AutoSize = true;
            this.radioBtn_All.Location = new System.Drawing.Point(540, 15);
            this.radioBtn_All.Name = "radioBtn_All";
            this.radioBtn_All.Size = new System.Drawing.Size(62, 25);
            this.radioBtn_All.TabIndex = 3;
            this.radioBtn_All.TabStop = true;
            this.radioBtn_All.Text = "전체";
            this.radioBtn_All.UseVisualStyleBackColor = true;
            this.radioBtn_All.Click += new System.EventHandler(this.radioBtn_All_Click);
            // 
            // btn_Return
            // 
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Return.Location = new System.Drawing.Point(946, 9);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(95, 31);
            this.btn_Return.TabIndex = 7;
            this.btn_Return.Text = "반납";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // dataGridView_Rent
            // 
            this.dataGridView_Rent.AllowUserToAddRows = false;
            this.dataGridView_Rent.AllowUserToDeleteRows = false;
            this.dataGridView_Rent.AllowUserToResizeColumns = false;
            this.dataGridView_Rent.AllowUserToResizeRows = false;
            this.dataGridView_Rent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Rent.ColumnHeadersHeight = 30;
            this.dataGridView_Rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Rent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_RentList_RentDate,
            this.dgv_RentList_ReturnDate,
            this.dgv_RentList_Bike,
            this.dgv_RentList_Status,
            this.dgv_RentList_MemName,
            this.dgv_RentList_Tel,
            this.dgv_RentList_Address});
            this.dataGridView_Rent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Rent.Location = new System.Drawing.Point(6, 46);
            this.dataGridView_Rent.MultiSelect = false;
            this.dataGridView_Rent.Name = "dataGridView_Rent";
            this.dataGridView_Rent.ReadOnly = true;
            this.dataGridView_Rent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_Rent.RowHeadersVisible = false;
            this.dataGridView_Rent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Rent.RowTemplate.Height = 25;
            this.dataGridView_Rent.RowTemplate.ReadOnly = true;
            this.dataGridView_Rent.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Rent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Rent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Rent.Size = new System.Drawing.Size(1035, 447);
            this.dataGridView_Rent.TabIndex = 10;
            this.dataGridView_Rent.TabStop = false;
            // 
            // dgv_RentList_RentDate
            // 
            this.dgv_RentList_RentDate.HeaderText = "대여일시";
            this.dgv_RentList_RentDate.Name = "dgv_RentList_RentDate";
            this.dgv_RentList_RentDate.ReadOnly = true;
            // 
            // dgv_RentList_ReturnDate
            // 
            this.dgv_RentList_ReturnDate.HeaderText = "반납일시";
            this.dgv_RentList_ReturnDate.Name = "dgv_RentList_ReturnDate";
            this.dgv_RentList_ReturnDate.ReadOnly = true;
            // 
            // dgv_RentList_Bike
            // 
            this.dgv_RentList_Bike.HeaderText = "대여자전거";
            this.dgv_RentList_Bike.Name = "dgv_RentList_Bike";
            this.dgv_RentList_Bike.ReadOnly = true;
            // 
            // dgv_RentList_Status
            // 
            this.dgv_RentList_Status.HeaderText = "대여현황";
            this.dgv_RentList_Status.Name = "dgv_RentList_Status";
            this.dgv_RentList_Status.ReadOnly = true;
            // 
            // dgv_RentList_MemName
            // 
            this.dgv_RentList_MemName.HeaderText = "회원명";
            this.dgv_RentList_MemName.Name = "dgv_RentList_MemName";
            this.dgv_RentList_MemName.ReadOnly = true;
            // 
            // dgv_RentList_Tel
            // 
            this.dgv_RentList_Tel.HeaderText = "전화번호";
            this.dgv_RentList_Tel.Name = "dgv_RentList_Tel";
            this.dgv_RentList_Tel.ReadOnly = true;
            // 
            // dgv_RentList_Address
            // 
            this.dgv_RentList_Address.HeaderText = "주소";
            this.dgv_RentList_Address.Name = "dgv_RentList_Address";
            this.dgv_RentList_Address.ReadOnly = true;
            // 
            // lb_Rent_BikeName
            // 
            this.lb_Rent_BikeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Rent_BikeName.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Rent_BikeName.Location = new System.Drawing.Point(273, 9);
            this.lb_Rent_BikeName.Name = "lb_Rent_BikeName";
            this.lb_Rent_BikeName.Size = new System.Drawing.Size(106, 31);
            this.lb_Rent_BikeName.TabIndex = 9;
            this.lb_Rent_BikeName.Text = "자전거코드";
            this.lb_Rent_BikeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_Rent_BikeName
            // 
            this.txtBox_Rent_BikeName.Location = new System.Drawing.Point(385, 9);
            this.txtBox_Rent_BikeName.Name = "txtBox_Rent_BikeName";
            this.txtBox_Rent_BikeName.Size = new System.Drawing.Size(149, 28);
            this.txtBox_Rent_BikeName.TabIndex = 2;
            this.txtBox_Rent_BikeName.TextChanged += new System.EventHandler(this.txtBox_Rent_BikeName_TextChanged);
            // 
            // lb_Rent_MemName
            // 
            this.lb_Rent_MemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Rent_MemName.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_Rent_MemName.Location = new System.Drawing.Point(6, 9);
            this.lb_Rent_MemName.Name = "lb_Rent_MemName";
            this.lb_Rent_MemName.Size = new System.Drawing.Size(106, 31);
            this.lb_Rent_MemName.TabIndex = 8;
            this.lb_Rent_MemName.Text = "회원명/코드";
            this.lb_Rent_MemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_Rent_MemName
            // 
            this.txtBox_Rent_MemName.Location = new System.Drawing.Point(118, 9);
            this.txtBox_Rent_MemName.Name = "txtBox_Rent_MemName";
            this.txtBox_Rent_MemName.Size = new System.Drawing.Size(149, 28);
            this.txtBox_Rent_MemName.TabIndex = 1;
            this.txtBox_Rent_MemName.TextChanged += new System.EventHandler(this.txtBox_Rent_MemName_TextChanged);
            // 
            // btn_Rent
            // 
            this.btn_Rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rent.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Rent.Location = new System.Drawing.Point(845, 9);
            this.btn_Rent.Name = "btn_Rent";
            this.btn_Rent.Size = new System.Drawing.Size(95, 31);
            this.btn_Rent.TabIndex = 6;
            this.btn_Rent.Text = "대여";
            this.btn_Rent.UseVisualStyleBackColor = true;
            this.btn_Rent.Click += new System.EventHandler(this.btn_Rent_Click);
            // 
            // tabPage_MemberManage
            // 
            this.tabPage_MemberManage.Controls.Add(this.btn_MemReg);
            this.tabPage_MemberManage.Controls.Add(this.lb_MemList_Name);
            this.tabPage_MemberManage.Controls.Add(this.txtBox_MemList_Name);
            this.tabPage_MemberManage.Controls.Add(this.dataGridView_MemList);
            this.tabPage_MemberManage.Location = new System.Drawing.Point(4, 74);
            this.tabPage_MemberManage.Name = "tabPage_MemberManage";
            this.tabPage_MemberManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_MemberManage.Size = new System.Drawing.Size(1047, 501);
            this.tabPage_MemberManage.TabIndex = 2;
            this.tabPage_MemberManage.Text = "회원관리";
            this.tabPage_MemberManage.UseVisualStyleBackColor = true;
            // 
            // btn_MemReg
            // 
            this.btn_MemReg.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_MemReg.Location = new System.Drawing.Point(894, 9);
            this.btn_MemReg.Name = "btn_MemReg";
            this.btn_MemReg.Size = new System.Drawing.Size(138, 31);
            this.btn_MemReg.TabIndex = 15;
            this.btn_MemReg.Text = "회원 등록";
            this.btn_MemReg.UseVisualStyleBackColor = true;
            this.btn_MemReg.Click += new System.EventHandler(this.btn_MemReg_Click);
            // 
            // lb_MemList_Name
            // 
            this.lb_MemList_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_MemList_Name.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_MemList_Name.Location = new System.Drawing.Point(6, 9);
            this.lb_MemList_Name.Name = "lb_MemList_Name";
            this.lb_MemList_Name.Size = new System.Drawing.Size(141, 31);
            this.lb_MemList_Name.TabIndex = 13;
            this.lb_MemList_Name.Text = "회원명";
            this.lb_MemList_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_MemList_Name
            // 
            this.txtBox_MemList_Name.Location = new System.Drawing.Point(153, 9);
            this.txtBox_MemList_Name.Name = "txtBox_MemList_Name";
            this.txtBox_MemList_Name.Size = new System.Drawing.Size(222, 28);
            this.txtBox_MemList_Name.TabIndex = 12;
            this.txtBox_MemList_Name.TextChanged += new System.EventHandler(this.txtBox_MemList_Name_TextChanged);
            // 
            // dataGridView_MemList
            // 
            this.dataGridView_MemList.AllowUserToAddRows = false;
            this.dataGridView_MemList.AllowUserToDeleteRows = false;
            this.dataGridView_MemList.AllowUserToResizeColumns = false;
            this.dataGridView_MemList.AllowUserToResizeRows = false;
            this.dataGridView_MemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_MemList.ColumnHeadersHeight = 30;
            this.dataGridView_MemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_MemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_MemList_Num,
            this.dgv_MemList_Name,
            this.dgv_MemList_RegDate,
            this.dgv_MemList_TelNum,
            this.dgv_MemList_Address,
            this.dgv_MemList_ETC});
            this.dataGridView_MemList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_MemList.GridColor = System.Drawing.Color.Silver;
            this.dataGridView_MemList.Location = new System.Drawing.Point(6, 46);
            this.dataGridView_MemList.MultiSelect = false;
            this.dataGridView_MemList.Name = "dataGridView_MemList";
            this.dataGridView_MemList.RowHeadersVisible = false;
            this.dataGridView_MemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_MemList.RowTemplate.Height = 25;
            this.dataGridView_MemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_MemList.Size = new System.Drawing.Size(1026, 452);
            this.dataGridView_MemList.TabIndex = 11;
            this.dataGridView_MemList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MemList_CellDoubleClick);
            // 
            // dgv_MemList_Num
            // 
            this.dgv_MemList_Num.HeaderText = "회원번호";
            this.dgv_MemList_Num.Name = "dgv_MemList_Num";
            this.dgv_MemList_Num.ReadOnly = true;
            // 
            // dgv_MemList_Name
            // 
            this.dgv_MemList_Name.HeaderText = "회원이름";
            this.dgv_MemList_Name.Name = "dgv_MemList_Name";
            this.dgv_MemList_Name.ReadOnly = true;
            // 
            // dgv_MemList_RegDate
            // 
            this.dgv_MemList_RegDate.HeaderText = "등록일";
            this.dgv_MemList_RegDate.Name = "dgv_MemList_RegDate";
            this.dgv_MemList_RegDate.ReadOnly = true;
            // 
            // dgv_MemList_TelNum
            // 
            this.dgv_MemList_TelNum.HeaderText = "전화번호";
            this.dgv_MemList_TelNum.Name = "dgv_MemList_TelNum";
            this.dgv_MemList_TelNum.ReadOnly = true;
            // 
            // dgv_MemList_Address
            // 
            this.dgv_MemList_Address.HeaderText = "주소";
            this.dgv_MemList_Address.Name = "dgv_MemList_Address";
            this.dgv_MemList_Address.ReadOnly = true;
            // 
            // dgv_MemList_ETC
            // 
            this.dgv_MemList_ETC.HeaderText = "기타";
            this.dgv_MemList_ETC.Name = "dgv_MemList_ETC";
            this.dgv_MemList_ETC.ReadOnly = true;
            // 
            // tabPage_BikeManage
            // 
            this.tabPage_BikeManage.Controls.Add(this.btn_BikeReg);
            this.tabPage_BikeManage.Controls.Add(this.lb_BikeList_Code);
            this.tabPage_BikeManage.Controls.Add(this.txtBox_BikeList_Code);
            this.tabPage_BikeManage.Controls.Add(this.dataGridView_BikeList);
            this.tabPage_BikeManage.Location = new System.Drawing.Point(4, 74);
            this.tabPage_BikeManage.Name = "tabPage_BikeManage";
            this.tabPage_BikeManage.Size = new System.Drawing.Size(1047, 501);
            this.tabPage_BikeManage.TabIndex = 3;
            this.tabPage_BikeManage.Text = "자전거\n관리";
            this.tabPage_BikeManage.UseVisualStyleBackColor = true;
            // 
            // btn_BikeReg
            // 
            this.btn_BikeReg.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_BikeReg.Location = new System.Drawing.Point(894, 9);
            this.btn_BikeReg.Name = "btn_BikeReg";
            this.btn_BikeReg.Size = new System.Drawing.Size(138, 31);
            this.btn_BikeReg.TabIndex = 15;
            this.btn_BikeReg.Text = "자전거등록";
            this.btn_BikeReg.UseVisualStyleBackColor = true;
            this.btn_BikeReg.Click += new System.EventHandler(this.btn_BikeReg_Click);
            // 
            // lb_BikeList_Code
            // 
            this.lb_BikeList_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_BikeList_Code.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_BikeList_Code.Location = new System.Drawing.Point(6, 9);
            this.lb_BikeList_Code.Name = "lb_BikeList_Code";
            this.lb_BikeList_Code.Size = new System.Drawing.Size(142, 31);
            this.lb_BikeList_Code.TabIndex = 13;
            this.lb_BikeList_Code.Text = "자전거 코드";
            this.lb_BikeList_Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBox_BikeList_Code
            // 
            this.txtBox_BikeList_Code.Location = new System.Drawing.Point(154, 9);
            this.txtBox_BikeList_Code.Name = "txtBox_BikeList_Code";
            this.txtBox_BikeList_Code.Size = new System.Drawing.Size(222, 28);
            this.txtBox_BikeList_Code.TabIndex = 12;
            this.txtBox_BikeList_Code.TextChanged += new System.EventHandler(this.txtBox_BikeList_Code_TextChanged);
            // 
            // dataGridView_BikeList
            // 
            this.dataGridView_BikeList.AllowUserToAddRows = false;
            this.dataGridView_BikeList.AllowUserToDeleteRows = false;
            this.dataGridView_BikeList.AllowUserToResizeColumns = false;
            this.dataGridView_BikeList.AllowUserToResizeRows = false;
            this.dataGridView_BikeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BikeList.ColumnHeadersHeight = 30;
            this.dataGridView_BikeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_BikeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_BikeList_BikeCode,
            this.dgv_BikeList_BikeType,
            this.dgv_BikeList_InitialRentalShop,
            this.dgv_BikeList_CurrentRentalShop,
            this.dgv_BikeList_ETC,
            this.dgv_BikeList_BikeRegDate});
            this.dataGridView_BikeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_BikeList.GridColor = System.Drawing.Color.Silver;
            this.dataGridView_BikeList.Location = new System.Drawing.Point(6, 46);
            this.dataGridView_BikeList.MultiSelect = false;
            this.dataGridView_BikeList.Name = "dataGridView_BikeList";
            this.dataGridView_BikeList.RowHeadersVisible = false;
            this.dataGridView_BikeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_BikeList.RowTemplate.Height = 25;
            this.dataGridView_BikeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BikeList.Size = new System.Drawing.Size(1026, 452);
            this.dataGridView_BikeList.TabIndex = 11;
            this.dataGridView_BikeList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_BikeList_CellDoubleClick);
            // 
            // dgv_BikeList_BikeCode
            // 
            this.dgv_BikeList_BikeCode.HeaderText = "자전거코드";
            this.dgv_BikeList_BikeCode.Name = "dgv_BikeList_BikeCode";
            this.dgv_BikeList_BikeCode.ReadOnly = true;
            // 
            // dgv_BikeList_BikeType
            // 
            this.dgv_BikeList_BikeType.HeaderText = "자전거타입";
            this.dgv_BikeList_BikeType.Name = "dgv_BikeList_BikeType";
            this.dgv_BikeList_BikeType.ReadOnly = true;
            // 
            // dgv_BikeList_InitialRentalShop
            // 
            this.dgv_BikeList_InitialRentalShop.HeaderText = "최초등록지";
            this.dgv_BikeList_InitialRentalShop.Name = "dgv_BikeList_InitialRentalShop";
            this.dgv_BikeList_InitialRentalShop.ReadOnly = true;
            // 
            // dgv_BikeList_CurrentRentalShop
            // 
            this.dgv_BikeList_CurrentRentalShop.HeaderText = "현재 자전거 위치";
            this.dgv_BikeList_CurrentRentalShop.Name = "dgv_BikeList_CurrentRentalShop";
            this.dgv_BikeList_CurrentRentalShop.ReadOnly = true;
            // 
            // dgv_BikeList_ETC
            // 
            this.dgv_BikeList_ETC.HeaderText = "기타";
            this.dgv_BikeList_ETC.Name = "dgv_BikeList_ETC";
            this.dgv_BikeList_ETC.ReadOnly = true;
            // 
            // dgv_BikeList_BikeRegDate
            // 
            this.dgv_BikeList_BikeRegDate.HeaderText = "등록일";
            this.dgv_BikeList_BikeRegDate.Name = "dgv_BikeList_BikeRegDate";
            this.dgv_BikeList_BikeRegDate.ReadOnly = true;
            // 
            // tabPage_Statistic
            // 
            this.tabPage_Statistic.Controls.Add(this.btn_export_bike);
            this.tabPage_Statistic.Controls.Add(this.btn_export_member);
            this.tabPage_Statistic.Controls.Add(this.cmboBox_Statistic_BikeType);
            this.tabPage_Statistic.Controls.Add(this.cmboBox_Statistic_Sex);
            this.tabPage_Statistic.Controls.Add(this.dataGridView_Statistic);
            this.tabPage_Statistic.Controls.Add(this.cmboBox_Statistic_RentalShop);
            this.tabPage_Statistic.Controls.Add(this.label2);
            this.tabPage_Statistic.Controls.Add(this.label1);
            this.tabPage_Statistic.Controls.Add(this.dateTimePicker_Statistic_End);
            this.tabPage_Statistic.Controls.Add(this.dateTimePicker_Statistic_Start);
            this.tabPage_Statistic.Location = new System.Drawing.Point(4, 74);
            this.tabPage_Statistic.Name = "tabPage_Statistic";
            this.tabPage_Statistic.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Statistic.Size = new System.Drawing.Size(1047, 501);
            this.tabPage_Statistic.TabIndex = 4;
            this.tabPage_Statistic.Text = "통계";
            this.tabPage_Statistic.UseVisualStyleBackColor = true;
            // 
            // btn_export_member
            // 
            this.btn_export_member.Location = new System.Drawing.Point(6, 6);
            this.btn_export_member.Name = "btn_export_member";
            this.btn_export_member.Size = new System.Drawing.Size(240, 30);
            this.btn_export_member.TabIndex = 86;
            this.btn_export_member.Text = "회원정보 엑셀로 내보내기";
            this.btn_export_member.UseVisualStyleBackColor = true;
            this.btn_export_member.Click += new System.EventHandler(this.btn_export_member_Click);
            // 
            // cmboBox_Statistic_BikeType
            // 
            this.cmboBox_Statistic_BikeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox_Statistic_BikeType.FormattingEnabled = true;
            this.cmboBox_Statistic_BikeType.Location = new System.Drawing.Point(673, 50);
            this.cmboBox_Statistic_BikeType.Name = "cmboBox_Statistic_BikeType";
            this.cmboBox_Statistic_BikeType.Size = new System.Drawing.Size(121, 29);
            this.cmboBox_Statistic_BikeType.TabIndex = 85;
            this.cmboBox_Statistic_BikeType.SelectedIndexChanged += new System.EventHandler(this.cmboBox_Statistic_BikeType_SelectedIndexChanged);
            // 
            // cmboBox_Statistic_Sex
            // 
            this.cmboBox_Statistic_Sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox_Statistic_Sex.FormattingEnabled = true;
            this.cmboBox_Statistic_Sex.Location = new System.Drawing.Point(546, 49);
            this.cmboBox_Statistic_Sex.Name = "cmboBox_Statistic_Sex";
            this.cmboBox_Statistic_Sex.Size = new System.Drawing.Size(121, 29);
            this.cmboBox_Statistic_Sex.TabIndex = 84;
            this.cmboBox_Statistic_Sex.SelectedIndexChanged += new System.EventHandler(this.cmboBox_Statistic_Sex_SelectedIndexChanged);
            // 
            // dataGridView_Statistic
            // 
            this.dataGridView_Statistic.AllowUserToAddRows = false;
            this.dataGridView_Statistic.AllowUserToDeleteRows = false;
            this.dataGridView_Statistic.AllowUserToResizeColumns = false;
            this.dataGridView_Statistic.AllowUserToResizeRows = false;
            this.dataGridView_Statistic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Statistic.ColumnHeadersHeight = 30;
            this.dataGridView_Statistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_Statistic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView_Statistic.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Statistic.Location = new System.Drawing.Point(6, 84);
            this.dataGridView_Statistic.MultiSelect = false;
            this.dataGridView_Statistic.Name = "dataGridView_Statistic";
            this.dataGridView_Statistic.ReadOnly = true;
            this.dataGridView_Statistic.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView_Statistic.RowHeadersVisible = false;
            this.dataGridView_Statistic.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView_Statistic.RowTemplate.Height = 25;
            this.dataGridView_Statistic.RowTemplate.ReadOnly = true;
            this.dataGridView_Statistic.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Statistic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Statistic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Statistic.Size = new System.Drawing.Size(1035, 411);
            this.dataGridView_Statistic.TabIndex = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "대여일시";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "반납일시";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "대여자전거";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "대여현황";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "회원명";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "전화번호";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "주소";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // cmboBox_Statistic_RentalShop
            // 
            this.cmboBox_Statistic_RentalShop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBox_Statistic_RentalShop.FormattingEnabled = true;
            this.cmboBox_Statistic_RentalShop.Location = new System.Drawing.Point(419, 49);
            this.cmboBox_Statistic_RentalShop.Name = "cmboBox_Statistic_RentalShop";
            this.cmboBox_Statistic_RentalShop.Size = new System.Drawing.Size(121, 29);
            this.cmboBox_Statistic_RentalShop.TabIndex = 79;
            this.cmboBox_Statistic_RentalShop.SelectedIndexChanged += new System.EventHandler(this.cmboBox_Statistic_RentalShop_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 78;
            this.label2.Text = "까지";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 77;
            this.label1.Text = "부터";
            // 
            // dateTimePicker_Statistic_End
            // 
            this.dateTimePicker_Statistic_End.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker_Statistic_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Statistic_End.Location = new System.Drawing.Point(213, 51);
            this.dateTimePicker_Statistic_End.Name = "dateTimePicker_Statistic_End";
            this.dateTimePicker_Statistic_End.Size = new System.Drawing.Size(150, 28);
            this.dateTimePicker_Statistic_End.TabIndex = 76;
            this.dateTimePicker_Statistic_End.ValueChanged += new System.EventHandler(this.dateTimePicker_Statistic_End_ValueChanged);
            // 
            // dateTimePicker_Statistic_Start
            // 
            this.dateTimePicker_Statistic_Start.Font = new System.Drawing.Font("KoPub돋움체 Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker_Statistic_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Statistic_Start.Location = new System.Drawing.Point(6, 49);
            this.dateTimePicker_Statistic_Start.Name = "dateTimePicker_Statistic_Start";
            this.dateTimePicker_Statistic_Start.Size = new System.Drawing.Size(151, 28);
            this.dateTimePicker_Statistic_Start.TabIndex = 60;
            this.dateTimePicker_Statistic_Start.ValueChanged += new System.EventHandler(this.dateTimePicker_Statistic_Start_ValueChanged);
            // 
            // dgv_Rent_RentDate
            // 
            this.dgv_Rent_RentDate.HeaderText = "대여일시";
            this.dgv_Rent_RentDate.Name = "dgv_Rent_RentDate";
            this.dgv_Rent_RentDate.ReadOnly = true;
            // 
            // dgv_Rent_ReturnDate
            // 
            this.dgv_Rent_ReturnDate.HeaderText = "반납일시";
            this.dgv_Rent_ReturnDate.Name = "dgv_Rent_ReturnDate";
            this.dgv_Rent_ReturnDate.ReadOnly = true;
            // 
            // dgv_Rent_RentBike
            // 
            this.dgv_Rent_RentBike.HeaderText = "대여자전거";
            this.dgv_Rent_RentBike.Name = "dgv_Rent_RentBike";
            this.dgv_Rent_RentBike.ReadOnly = true;
            // 
            // dgv_Rent_RentStatus
            // 
            this.dgv_Rent_RentStatus.HeaderText = "대여현황";
            this.dgv_Rent_RentStatus.Name = "dgv_Rent_RentStatus";
            this.dgv_Rent_RentStatus.ReadOnly = true;
            // 
            // dgv_Rent_MemName
            // 
            this.dgv_Rent_MemName.HeaderText = "회원명";
            this.dgv_Rent_MemName.Name = "dgv_Rent_MemName";
            this.dgv_Rent_MemName.ReadOnly = true;
            // 
            // dgv_Rent_MemNum
            // 
            this.dgv_Rent_MemNum.HeaderText = "회원번호";
            this.dgv_Rent_MemNum.Name = "dgv_Rent_MemNum";
            this.dgv_Rent_MemNum.ReadOnly = true;
            // 
            // dgv_Rent_MemID
            // 
            this.dgv_Rent_MemID.HeaderText = "주민번호";
            this.dgv_Rent_MemID.Name = "dgv_Rent_MemID";
            this.dgv_Rent_MemID.ReadOnly = true;
            // 
            // dgv_Rent_MemTelNum
            // 
            this.dgv_Rent_MemTelNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Rent_MemTelNum.HeaderText = "전화번호";
            this.dgv_Rent_MemTelNum.Name = "dgv_Rent_MemTelNum";
            this.dgv_Rent_MemTelNum.ReadOnly = true;
            // 
            // dgv_Rent_MemAddress
            // 
            this.dgv_Rent_MemAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Rent_MemAddress.HeaderText = "주소";
            this.dgv_Rent_MemAddress.Name = "dgv_Rent_MemAddress";
            this.dgv_Rent_MemAddress.ReadOnly = true;
            // 
            // btn_export_bike
            // 
            this.btn_export_bike.Location = new System.Drawing.Point(252, 6);
            this.btn_export_bike.Name = "btn_export_bike";
            this.btn_export_bike.Size = new System.Drawing.Size(240, 30);
            this.btn_export_bike.TabIndex = 87;
            this.btn_export_bike.Text = "자전거정보 엑셀로 내보내기";
            this.btn_export_bike.UseVisualStyleBackColor = true;
            this.btn_export_bike.Click += new System.EventHandler(this.btn_export_bike_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1079, 603);
            this.Controls.Add(this.tabControl_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Rent.ResumeLayout(false);
            this.tabPage_Rent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rent)).EndInit();
            this.tabPage_MemberManage.ResumeLayout(false);
            this.tabPage_MemberManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MemList)).EndInit();
            this.tabPage_BikeManage.ResumeLayout(false);
            this.tabPage_BikeManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BikeList)).EndInit();
            this.tabPage_Statistic.ResumeLayout(false);
            this.tabPage_Statistic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Statistic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Rent;
        private System.Windows.Forms.Button btn_Rent;
        private System.Windows.Forms.TextBox txtBox_Rent_MemName;
        private System.Windows.Forms.TabPage tabPage_MemberManage;
        private System.Windows.Forms.Label lb_Rent_BikeName;
        private System.Windows.Forms.TextBox txtBox_Rent_BikeName;
        private System.Windows.Forms.Label lb_Rent_MemName;
        private System.Windows.Forms.DataGridView dataGridView_Rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Rent_RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Rent_ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Rent_RentBike;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Rent_RentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Rent_MemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Rent_MemNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Rent_MemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Rent_MemTelNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Rent_MemAddress;
        private System.Windows.Forms.TabPage tabPage_BikeManage;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_MemReg;
        private System.Windows.Forms.Label lb_MemList_Name;
        private System.Windows.Forms.TextBox txtBox_MemList_Name;
        private System.Windows.Forms.DataGridView dataGridView_MemList;
        private System.Windows.Forms.Button btn_BikeReg;
        private System.Windows.Forms.Label lb_BikeList_Code;
        private System.Windows.Forms.TextBox txtBox_BikeList_Code;
        private System.Windows.Forms.DataGridView dataGridView_BikeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BikeList_BikeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BikeList_BikeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BikeList_InitialRentalShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BikeList_CurrentRentalShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BikeList_ETC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_BikeList_BikeRegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RentList_RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RentList_ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RentList_Bike;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RentList_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RentList_MemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RentList_Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_RentList_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_MemList_Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_MemList_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_MemList_RegDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_MemList_TelNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_MemList_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_MemList_ETC;
        private System.Windows.Forms.TabPage tabPage_Statistic;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Statistic_Start;
        private System.Windows.Forms.DataGridView dataGridView_Statistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox cmboBox_Statistic_RentalShop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Statistic_End;
        private System.Windows.Forms.ComboBox cmboBox_Statistic_BikeType;
        private System.Windows.Forms.ComboBox cmboBox_Statistic_Sex;
        private System.Windows.Forms.RadioButton radioBtn_Returned;
        private System.Windows.Forms.RadioButton radioBtn_Renting;
        private System.Windows.Forms.RadioButton radioBtn_All;
        private System.Windows.Forms.Button btn_export_member;
        private System.Windows.Forms.Button btn_export_bike;
    }
}

