namespace Medical_Treatment
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.query_gb = new System.Windows.Forms.GroupBox();
            this.query_btn = new System.Windows.Forms.Button();
            this.q_start_DTP = new System.Windows.Forms.DateTimePicker();
            this.q_time_CB = new System.Windows.Forms.CheckBox();
            this.q_medicineName_CB = new System.Windows.Forms.CheckBox();
            this.q_userNO_CB = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.q_end_DTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.q_medicineName_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.q_userNO_TB = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Management_gb = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cardID_TB = new System.Windows.Forms.TextBox();
            this.validDate_TP = new System.Windows.Forms.DateTimePicker();
            this.remark_TB = new System.Windows.Forms.TextBox();
            this.purpose_TB = new System.Windows.Forms.TextBox();
            this.batchNumber_TB = new System.Windows.Forms.TextBox();
            this.singleUse_TB = new System.Windows.Forms.TextBox();
            this.outgoingQuantity_TB = new System.Windows.Forms.TextBox();
            this.doseDpecification_TB = new System.Windows.Forms.TextBox();
            this.medicineName_TB = new System.Windows.Forms.TextBox();
            this.userDept_TB = new System.Windows.Forms.TextBox();
            this.userSex_TB = new System.Windows.Forms.TextBox();
            this.userName_TB = new System.Windows.Forms.TextBox();
            this.userNO_TB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._Edit = new System.Windows.Forms.Button();
            this._Cancel = new System.Windows.Forms.Button();
            this._Save = new System.Windows.Forms.Button();
            this._Delete = new System.Windows.Forms.Button();
            this._New = new System.Windows.Forms.Button();
            this.query_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.Management_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // query_gb
            // 
            this.query_gb.Controls.Add(this.query_btn);
            this.query_gb.Controls.Add(this.q_start_DTP);
            this.query_gb.Controls.Add(this.q_time_CB);
            this.query_gb.Controls.Add(this.q_medicineName_CB);
            this.query_gb.Controls.Add(this.q_userNO_CB);
            this.query_gb.Controls.Add(this.label6);
            this.query_gb.Controls.Add(this.q_end_DTP);
            this.query_gb.Controls.Add(this.label4);
            this.query_gb.Controls.Add(this.label3);
            this.query_gb.Controls.Add(this.q_medicineName_TB);
            this.query_gb.Controls.Add(this.label1);
            this.query_gb.Controls.Add(this.q_userNO_TB);
            this.query_gb.Location = new System.Drawing.Point(12, 7);
            this.query_gb.Name = "query_gb";
            this.query_gb.Size = new System.Drawing.Size(749, 80);
            this.query_gb.TabIndex = 5;
            this.query_gb.TabStop = false;
            this.query_gb.Text = "查询：";
            // 
            // query_btn
            // 
            this.query_btn.Location = new System.Drawing.Point(668, 16);
            this.query_btn.Name = "query_btn";
            this.query_btn.Size = new System.Drawing.Size(75, 55);
            this.query_btn.TabIndex = 13;
            this.query_btn.Text = "查询";
            this.query_btn.UseVisualStyleBackColor = true;
            this.query_btn.Click += new System.EventHandler(this.query_btn_Click);
            // 
            // q_start_DTP
            // 
            this.q_start_DTP.CustomFormat = "yyyy-MM-dd HH:mm";
            this.q_start_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.q_start_DTP.Location = new System.Drawing.Point(400, 15);
            this.q_start_DTP.Name = "q_start_DTP";
            this.q_start_DTP.Size = new System.Drawing.Size(94, 21);
            this.q_start_DTP.TabIndex = 24;
            // 
            // q_time_CB
            // 
            this.q_time_CB.AutoSize = true;
            this.q_time_CB.Location = new System.Drawing.Point(527, 20);
            this.q_time_CB.Name = "q_time_CB";
            this.q_time_CB.Size = new System.Drawing.Size(15, 14);
            this.q_time_CB.TabIndex = 23;
            this.q_time_CB.UseVisualStyleBackColor = true;
            // 
            // q_medicineName_CB
            // 
            this.q_medicineName_CB.AutoSize = true;
            this.q_medicineName_CB.Location = new System.Drawing.Point(265, 50);
            this.q_medicineName_CB.Name = "q_medicineName_CB";
            this.q_medicineName_CB.Size = new System.Drawing.Size(15, 14);
            this.q_medicineName_CB.TabIndex = 20;
            this.q_medicineName_CB.UseVisualStyleBackColor = true;
            // 
            // q_userNO_CB
            // 
            this.q_userNO_CB.AutoSize = true;
            this.q_userNO_CB.Location = new System.Drawing.Point(265, 20);
            this.q_userNO_CB.Name = "q_userNO_CB";
            this.q_userNO_CB.Size = new System.Drawing.Size(15, 14);
            this.q_userNO_CB.TabIndex = 19;
            this.q_userNO_CB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "to";
            // 
            // q_end_DTP
            // 
            this.q_end_DTP.CustomFormat = "yyyy-MM-dd HH:mm";
            this.q_end_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.q_end_DTP.Location = new System.Drawing.Point(400, 50);
            this.q_end_DTP.Name = "q_end_DTP";
            this.q_end_DTP.Size = new System.Drawing.Size(94, 21);
            this.q_end_DTP.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "药品名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "创建时间：";
            // 
            // q_medicineName_TB
            // 
            this.q_medicineName_TB.Location = new System.Drawing.Point(100, 45);
            this.q_medicineName_TB.Name = "q_medicineName_TB";
            this.q_medicineName_TB.Size = new System.Drawing.Size(132, 21);
            this.q_medicineName_TB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "工号：";
            // 
            // q_userNO_TB
            // 
            this.q_userNO_TB.Location = new System.Drawing.Point(100, 15);
            this.q_userNO_TB.Name = "q_userNO_TB";
            this.q_userNO_TB.Size = new System.Drawing.Size(132, 21);
            this.q_userNO_TB.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.LightSalmon;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Location = new System.Drawing.Point(12, 261);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(889, 323);
            this.dgv.TabIndex = 4;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // Management_gb
            // 
            this.Management_gb.Controls.Add(this.label2);
            this.Management_gb.Controls.Add(this.cardID_TB);
            this.Management_gb.Controls.Add(this.validDate_TP);
            this.Management_gb.Controls.Add(this.remark_TB);
            this.Management_gb.Controls.Add(this.purpose_TB);
            this.Management_gb.Controls.Add(this.batchNumber_TB);
            this.Management_gb.Controls.Add(this.singleUse_TB);
            this.Management_gb.Controls.Add(this.outgoingQuantity_TB);
            this.Management_gb.Controls.Add(this.doseDpecification_TB);
            this.Management_gb.Controls.Add(this.medicineName_TB);
            this.Management_gb.Controls.Add(this.userDept_TB);
            this.Management_gb.Controls.Add(this.userSex_TB);
            this.Management_gb.Controls.Add(this.userName_TB);
            this.Management_gb.Controls.Add(this.userNO_TB);
            this.Management_gb.Controls.Add(this.label18);
            this.Management_gb.Controls.Add(this.label17);
            this.Management_gb.Controls.Add(this.label16);
            this.Management_gb.Controls.Add(this.label15);
            this.Management_gb.Controls.Add(this.label14);
            this.Management_gb.Controls.Add(this.label13);
            this.Management_gb.Controls.Add(this.label12);
            this.Management_gb.Controls.Add(this.label11);
            this.Management_gb.Controls.Add(this.label10);
            this.Management_gb.Controls.Add(this.label9);
            this.Management_gb.Controls.Add(this.label8);
            this.Management_gb.Controls.Add(this.label7);
            this.Management_gb.Enabled = false;
            this.Management_gb.Location = new System.Drawing.Point(12, 93);
            this.Management_gb.Name = "Management_gb";
            this.Management_gb.Size = new System.Drawing.Size(813, 162);
            this.Management_gb.TabIndex = 6;
            this.Management_gb.TabStop = false;
            this.Management_gb.Text = "操作：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "刷卡处：";
            // 
            // cardID_TB
            // 
            this.cardID_TB.Location = new System.Drawing.Point(71, 15);
            this.cardID_TB.Name = "cardID_TB";
            this.cardID_TB.Size = new System.Drawing.Size(100, 21);
            this.cardID_TB.TabIndex = 26;
            this.cardID_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardID_TB_KeyDown);
            // 
            // validDate_TP
            // 
            this.validDate_TP.CustomFormat = "yyyy-MM-dd HH:mm";
            this.validDate_TP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.validDate_TP.Location = new System.Drawing.Point(503, 20);
            this.validDate_TP.Name = "validDate_TP";
            this.validDate_TP.Size = new System.Drawing.Size(100, 21);
            this.validDate_TP.TabIndex = 25;
            // 
            // remark_TB
            // 
            this.remark_TB.Location = new System.Drawing.Point(503, 74);
            this.remark_TB.Multiline = true;
            this.remark_TB.Name = "remark_TB";
            this.remark_TB.Size = new System.Drawing.Size(299, 78);
            this.remark_TB.TabIndex = 22;
            // 
            // purpose_TB
            // 
            this.purpose_TB.Location = new System.Drawing.Point(503, 47);
            this.purpose_TB.Name = "purpose_TB";
            this.purpose_TB.Size = new System.Drawing.Size(299, 21);
            this.purpose_TB.TabIndex = 21;
            // 
            // batchNumber_TB
            // 
            this.batchNumber_TB.Location = new System.Drawing.Point(300, 135);
            this.batchNumber_TB.Name = "batchNumber_TB";
            this.batchNumber_TB.Size = new System.Drawing.Size(100, 21);
            this.batchNumber_TB.TabIndex = 20;
            // 
            // singleUse_TB
            // 
            this.singleUse_TB.Location = new System.Drawing.Point(300, 105);
            this.singleUse_TB.Name = "singleUse_TB";
            this.singleUse_TB.Size = new System.Drawing.Size(100, 21);
            this.singleUse_TB.TabIndex = 19;
            // 
            // outgoingQuantity_TB
            // 
            this.outgoingQuantity_TB.Location = new System.Drawing.Point(300, 75);
            this.outgoingQuantity_TB.Name = "outgoingQuantity_TB";
            this.outgoingQuantity_TB.Size = new System.Drawing.Size(100, 21);
            this.outgoingQuantity_TB.TabIndex = 18;
            // 
            // doseDpecification_TB
            // 
            this.doseDpecification_TB.Location = new System.Drawing.Point(300, 45);
            this.doseDpecification_TB.Name = "doseDpecification_TB";
            this.doseDpecification_TB.Size = new System.Drawing.Size(100, 21);
            this.doseDpecification_TB.TabIndex = 17;
            // 
            // medicineName_TB
            // 
            this.medicineName_TB.Location = new System.Drawing.Point(300, 15);
            this.medicineName_TB.Name = "medicineName_TB";
            this.medicineName_TB.Size = new System.Drawing.Size(100, 21);
            this.medicineName_TB.TabIndex = 16;
            // 
            // userDept_TB
            // 
            this.userDept_TB.Location = new System.Drawing.Point(71, 135);
            this.userDept_TB.Name = "userDept_TB";
            this.userDept_TB.ReadOnly = true;
            this.userDept_TB.Size = new System.Drawing.Size(100, 21);
            this.userDept_TB.TabIndex = 15;
            // 
            // userSex_TB
            // 
            this.userSex_TB.Location = new System.Drawing.Point(71, 105);
            this.userSex_TB.Name = "userSex_TB";
            this.userSex_TB.ReadOnly = true;
            this.userSex_TB.Size = new System.Drawing.Size(100, 21);
            this.userSex_TB.TabIndex = 14;
            // 
            // userName_TB
            // 
            this.userName_TB.Location = new System.Drawing.Point(71, 75);
            this.userName_TB.Name = "userName_TB";
            this.userName_TB.ReadOnly = true;
            this.userName_TB.Size = new System.Drawing.Size(100, 21);
            this.userName_TB.TabIndex = 13;
            // 
            // userNO_TB
            // 
            this.userNO_TB.Location = new System.Drawing.Point(71, 45);
            this.userNO_TB.Name = "userNO_TB";
            this.userNO_TB.Size = new System.Drawing.Size(100, 21);
            this.userNO_TB.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 11;
            this.label18.Text = "性别：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 10;
            this.label17.Text = "部门：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 12);
            this.label16.TabIndex = 9;
            this.label16.Text = "姓名：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 12);
            this.label15.TabIndex = 8;
            this.label15.Text = "工号：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(450, 80);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 7;
            this.label14.Text = "备注：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(450, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 6;
            this.label13.Text = "用途：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(450, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = "有效期：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 4;
            this.label11.Text = "批号：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "单次使用量：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "领出数量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "剂量规格：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "药品名称：";
            // 
            // _Edit
            // 
            this._Edit.Enabled = false;
            this._Edit.Location = new System.Drawing.Point(832, 140);
            this._Edit.Name = "_Edit";
            this._Edit.Size = new System.Drawing.Size(75, 21);
            this._Edit.TabIndex = 212;
            this._Edit.Text = "修改";
            this._Edit.UseVisualStyleBackColor = true;
            this._Edit.Click += new System.EventHandler(this._Edit_Click);
            // 
            // _Cancel
            // 
            this._Cancel.Enabled = false;
            this._Cancel.Location = new System.Drawing.Point(832, 230);
            this._Cancel.Name = "_Cancel";
            this._Cancel.Size = new System.Drawing.Size(75, 21);
            this._Cancel.TabIndex = 214;
            this._Cancel.Text = "取消";
            this._Cancel.UseVisualStyleBackColor = true;
            this._Cancel.Click += new System.EventHandler(this._Cancel_Click);
            // 
            // _Save
            // 
            this._Save.Enabled = false;
            this._Save.Location = new System.Drawing.Point(832, 200);
            this._Save.Name = "_Save";
            this._Save.Size = new System.Drawing.Size(75, 21);
            this._Save.TabIndex = 213;
            this._Save.Text = "保存";
            this._Save.UseVisualStyleBackColor = true;
            this._Save.Click += new System.EventHandler(this._Save_Click);
            // 
            // _Delete
            // 
            this._Delete.Enabled = false;
            this._Delete.Location = new System.Drawing.Point(832, 170);
            this._Delete.Name = "_Delete";
            this._Delete.Size = new System.Drawing.Size(75, 21);
            this._Delete.TabIndex = 211;
            this._Delete.Text = "删除";
            this._Delete.UseVisualStyleBackColor = true;
            this._Delete.Click += new System.EventHandler(this._Delete_Click);
            // 
            // _New
            // 
            this._New.Location = new System.Drawing.Point(832, 110);
            this._New.Name = "_New";
            this._New.Size = new System.Drawing.Size(75, 21);
            this._New.TabIndex = 210;
            this._New.Text = "新建";
            this._New.UseVisualStyleBackColor = true;
            this._New.Click += new System.EventHandler(this._New_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 590);
            this.Controls.Add(this._Edit);
            this.Controls.Add(this._Cancel);
            this.Controls.Add(this._Save);
            this.Controls.Add(this.Management_gb);
            this.Controls.Add(this._Delete);
            this.Controls.Add(this._New);
            this.Controls.Add(this.query_gb);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Medical Treatment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.query_gb.ResumeLayout(false);
            this.query_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.Management_gb.ResumeLayout(false);
            this.Management_gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox query_gb;
        private System.Windows.Forms.DateTimePicker q_start_DTP;
        private System.Windows.Forms.CheckBox q_time_CB;
        private System.Windows.Forms.CheckBox q_medicineName_CB;
        private System.Windows.Forms.CheckBox q_userNO_CB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker q_end_DTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox q_medicineName_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox q_userNO_TB;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox Management_gb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker validDate_TP;
        private System.Windows.Forms.TextBox remark_TB;
        private System.Windows.Forms.TextBox batchNumber_TB;
        private System.Windows.Forms.TextBox singleUse_TB;
        private System.Windows.Forms.TextBox outgoingQuantity_TB;
        private System.Windows.Forms.TextBox doseDpecification_TB;
        private System.Windows.Forms.TextBox medicineName_TB;
        private System.Windows.Forms.TextBox userDept_TB;
        private System.Windows.Forms.TextBox userSex_TB;
        private System.Windows.Forms.TextBox userName_TB;
        private System.Windows.Forms.TextBox userNO_TB;
        private System.Windows.Forms.Button query_btn;
        private System.Windows.Forms.TextBox cardID_TB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox purpose_TB;
        private System.Windows.Forms.Button _Edit;
        private System.Windows.Forms.Button _Cancel;
        private System.Windows.Forms.Button _Save;
        private System.Windows.Forms.Button _Delete;
        private System.Windows.Forms.Button _New;
    }
}

