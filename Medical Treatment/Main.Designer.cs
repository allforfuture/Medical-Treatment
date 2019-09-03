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
            this.gbxQuery = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.chkTime = new System.Windows.Forms.CheckBox();
            this.chkMedicineName = new System.Windows.Forms.CheckBox();
            this.chkUserNO = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedicineName_Q = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserNO_Q = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gbxHistory = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.dtpValidDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.txtSingleUse = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtDosageSpecification = new System.Windows.Forms.TextBox();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserNO = new System.Windows.Forms.TextBox();
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.卡号管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加卡号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改卡号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gbxHistory.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxQuery
            // 
            this.gbxQuery.Controls.Add(this.btnQuery);
            this.gbxQuery.Controls.Add(this.dtpStart);
            this.gbxQuery.Controls.Add(this.chkTime);
            this.gbxQuery.Controls.Add(this.chkMedicineName);
            this.gbxQuery.Controls.Add(this.chkUserNO);
            this.gbxQuery.Controls.Add(this.label6);
            this.gbxQuery.Controls.Add(this.dtpEnd);
            this.gbxQuery.Controls.Add(this.label4);
            this.gbxQuery.Controls.Add(this.label3);
            this.gbxQuery.Controls.Add(this.txtMedicineName_Q);
            this.gbxQuery.Controls.Add(this.label1);
            this.gbxQuery.Controls.Add(this.txtUserNO_Q);
            this.gbxQuery.Location = new System.Drawing.Point(12, 35);
            this.gbxQuery.Name = "gbxQuery";
            this.gbxQuery.Size = new System.Drawing.Size(749, 80);
            this.gbxQuery.TabIndex = 5;
            this.gbxQuery.TabStop = false;
            this.gbxQuery.Text = "查询：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(668, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 55);
            this.btnQuery.TabIndex = 13;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(400, 15);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(94, 21);
            this.dtpStart.TabIndex = 24;
            // 
            // chkTime
            // 
            this.chkTime.AutoSize = true;
            this.chkTime.Checked = true;
            this.chkTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTime.Location = new System.Drawing.Point(527, 20);
            this.chkTime.Name = "chkTime";
            this.chkTime.Size = new System.Drawing.Size(15, 14);
            this.chkTime.TabIndex = 23;
            this.chkTime.UseVisualStyleBackColor = true;
            // 
            // chkMedicineName
            // 
            this.chkMedicineName.AutoSize = true;
            this.chkMedicineName.Location = new System.Drawing.Point(265, 50);
            this.chkMedicineName.Name = "chkMedicineName";
            this.chkMedicineName.Size = new System.Drawing.Size(15, 14);
            this.chkMedicineName.TabIndex = 20;
            this.chkMedicineName.UseVisualStyleBackColor = true;
            // 
            // chkUserNO
            // 
            this.chkUserNO.AutoSize = true;
            this.chkUserNO.Location = new System.Drawing.Point(265, 20);
            this.chkUserNO.Name = "chkUserNO";
            this.chkUserNO.Size = new System.Drawing.Size(15, 14);
            this.chkUserNO.TabIndex = 19;
            this.chkUserNO.UseVisualStyleBackColor = true;
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
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(400, 50);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(94, 21);
            this.dtpEnd.TabIndex = 14;
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
            // txtMedicineName_Q
            // 
            this.txtMedicineName_Q.Location = new System.Drawing.Point(100, 45);
            this.txtMedicineName_Q.Name = "txtMedicineName_Q";
            this.txtMedicineName_Q.Size = new System.Drawing.Size(132, 21);
            this.txtMedicineName_Q.TabIndex = 5;
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
            // txtUserNO_Q
            // 
            this.txtUserNO_Q.Location = new System.Drawing.Point(100, 15);
            this.txtUserNO_Q.Name = "txtUserNO_Q";
            this.txtUserNO_Q.Size = new System.Drawing.Size(132, 21);
            this.txtUserNO_Q.TabIndex = 1;
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
            this.dgv.Location = new System.Drawing.Point(12, 296);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(889, 288);
            this.dgv.TabIndex = 4;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CellClick);
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.Dgv_DataBindingComplete);
            // 
            // gbxHistory
            // 
            this.gbxHistory.Controls.Add(this.label2);
            this.gbxHistory.Controls.Add(this.txtCardID);
            this.gbxHistory.Controls.Add(this.dtpValidDate);
            this.gbxHistory.Controls.Add(this.txtRemark);
            this.gbxHistory.Controls.Add(this.txtPurpose);
            this.gbxHistory.Controls.Add(this.txtLot);
            this.gbxHistory.Controls.Add(this.txtSingleUse);
            this.gbxHistory.Controls.Add(this.txtQty);
            this.gbxHistory.Controls.Add(this.txtDosageSpecification);
            this.gbxHistory.Controls.Add(this.txtMedicineName);
            this.gbxHistory.Controls.Add(this.txtDept);
            this.gbxHistory.Controls.Add(this.txtSex);
            this.gbxHistory.Controls.Add(this.txtUserName);
            this.gbxHistory.Controls.Add(this.txtUserNO);
            this.gbxHistory.Controls.Add(this.label18);
            this.gbxHistory.Controls.Add(this.label17);
            this.gbxHistory.Controls.Add(this.label16);
            this.gbxHistory.Controls.Add(this.label15);
            this.gbxHistory.Controls.Add(this.label14);
            this.gbxHistory.Controls.Add(this.label13);
            this.gbxHistory.Controls.Add(this.label12);
            this.gbxHistory.Controls.Add(this.label11);
            this.gbxHistory.Controls.Add(this.label10);
            this.gbxHistory.Controls.Add(this.label9);
            this.gbxHistory.Controls.Add(this.label8);
            this.gbxHistory.Controls.Add(this.label7);
            this.gbxHistory.Enabled = false;
            this.gbxHistory.Location = new System.Drawing.Point(12, 121);
            this.gbxHistory.Name = "gbxHistory";
            this.gbxHistory.Size = new System.Drawing.Size(813, 162);
            this.gbxHistory.TabIndex = 6;
            this.gbxHistory.TabStop = false;
            this.gbxHistory.Text = "操作：";
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
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(71, 15);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(100, 21);
            this.txtCardID.TabIndex = 26;
            this.txtCardID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCardID_KeyDown);
            // 
            // dtpValidDate
            // 
            this.dtpValidDate.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtpValidDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidDate.Location = new System.Drawing.Point(503, 20);
            this.dtpValidDate.Name = "dtpValidDate";
            this.dtpValidDate.Size = new System.Drawing.Size(100, 21);
            this.dtpValidDate.TabIndex = 25;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(503, 74);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(299, 78);
            this.txtRemark.TabIndex = 22;
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(503, 47);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(299, 21);
            this.txtPurpose.TabIndex = 21;
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(300, 135);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(100, 21);
            this.txtLot.TabIndex = 20;
            // 
            // txtSingleUse
            // 
            this.txtSingleUse.Location = new System.Drawing.Point(300, 105);
            this.txtSingleUse.Name = "txtSingleUse";
            this.txtSingleUse.Size = new System.Drawing.Size(100, 21);
            this.txtSingleUse.TabIndex = 19;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(300, 75);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 21);
            this.txtQty.TabIndex = 18;
            // 
            // txtDosageSpecification
            // 
            this.txtDosageSpecification.Location = new System.Drawing.Point(300, 45);
            this.txtDosageSpecification.Name = "txtDosageSpecification";
            this.txtDosageSpecification.Size = new System.Drawing.Size(100, 21);
            this.txtDosageSpecification.TabIndex = 17;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(300, 15);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(100, 21);
            this.txtMedicineName.TabIndex = 16;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(71, 135);
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = true;
            this.txtDept.Size = new System.Drawing.Size(100, 21);
            this.txtDept.TabIndex = 15;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(71, 105);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(100, 21);
            this.txtSex.TabIndex = 14;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(71, 75);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 13;
            // 
            // txtUserNO
            // 
            this.txtUserNO.Location = new System.Drawing.Point(71, 45);
            this.txtUserNO.Name = "txtUserNO";
            this.txtUserNO.ReadOnly = true;
            this.txtUserNO.Size = new System.Drawing.Size(100, 21);
            this.txtUserNO.TabIndex = 12;
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
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(832, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnUpdate.TabIndex = 212;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(832, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 21);
            this.btnCancel.TabIndex = 214;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(832, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 21);
            this.btnSave.TabIndex = 213;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(832, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 21);
            this.btnDelete.TabIndex = 211;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(832, 138);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 21);
            this.btnNew.TabIndex = 210;
            this.btnNew.Text = "新建";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.卡号管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 25);
            this.menuStrip1.TabIndex = 215;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 卡号管理ToolStripMenuItem
            // 
            this.卡号管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加卡号ToolStripMenuItem,
            this.修改卡号ToolStripMenuItem});
            this.卡号管理ToolStripMenuItem.Name = "卡号管理ToolStripMenuItem";
            this.卡号管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.卡号管理ToolStripMenuItem.Text = "卡号管理";
            // 
            // 添加卡号ToolStripMenuItem
            // 
            this.添加卡号ToolStripMenuItem.Name = "添加卡号ToolStripMenuItem";
            this.添加卡号ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加卡号ToolStripMenuItem.Text = "添加卡号";
            this.添加卡号ToolStripMenuItem.Click += new System.EventHandler(this.添加卡号ToolStripMenuItem_Click);
            // 
            // 修改卡号ToolStripMenuItem
            // 
            this.修改卡号ToolStripMenuItem.Name = "修改卡号ToolStripMenuItem";
            this.修改卡号ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改卡号ToolStripMenuItem.Text = "修改卡号";
            this.修改卡号ToolStripMenuItem.Click += new System.EventHandler(this.修改卡号ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 590);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbxHistory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.gbxQuery);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Medical Treatment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.gbxQuery.ResumeLayout(false);
            this.gbxQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gbxHistory.ResumeLayout(false);
            this.gbxHistory.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxQuery;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.CheckBox chkTime;
        private System.Windows.Forms.CheckBox chkMedicineName;
        private System.Windows.Forms.CheckBox chkUserNO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedicineName_Q;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserNO_Q;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gbxHistory;
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
        private System.Windows.Forms.DateTimePicker dtpValidDate;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.TextBox txtSingleUse;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtDosageSpecification;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtUserNO;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 卡号管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加卡号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改卡号ToolStripMenuItem;
    }
}

