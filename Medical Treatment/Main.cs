using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.IO.Ports;
using System.IO;


namespace Medical_Treatment
{
    public partial class Main : Form
    {
        DBFactory dbFac = new DBFactory();        
        static string portName = ConfigurationManager.AppSettings["portName"];
        static int baudRate = int.Parse(ConfigurationManager.AppSettings["baudRate"]);
        SerialPort mySerialPort = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One);
        string sql_Q;
        string register_date;
        public Main()
        {
            InitializeComponent();
            this.Text += "_" + Application.ProductVersion.ToString();
            dgv.RowHeadersWidth = 55;
            q_start_DTP.Value = DateTime.Today;//.AddDays(-0);
            q_end_DTP.Value = DateTime.Today;//.AddHours(23).AddMinutes(59).AddSeconds(59);
            bool enabledPort = ConfigurationManager.AppSettings["enabledPort"] == "true" ? true : false;
            if (enabledPort)
            {
                try
                {
                    mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    mySerialPort.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show("串口出现问题\r\n" + e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CheckForIllegalCrossThreadCalls = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataTable sqlDT = new DataTable();
            //sqlDT.Clear();
            //sqlDT.Columns.Clear();
            //显示t_record记录表的所有当天记录，即使没有m_user表的用户信息
            sql_Q = "Select register_date as \"记录日期\",m.user_no as \"工号\",user_name as \"姓名\",user_dept as \"部门\",user_sex as \"性别\",medicine_name as \"药品名称\",dose_specification as \"剂量规格\",outgoing_quantity as \"领出数量\",single_use as \"单次使用量\",batch_number as \"批号\",valid_date as \"有效期\",purpose as \"用途\",remark as \"备注\""
            + " From t_record m Left Join m_user u on m.user_no = u.user_no"
            + " Where CAST(register_date AS DATE)= current_date Order By register_date Desc";
            dbFac.ExecuteDataTable(sql_Q, ref sqlDT);
            //查询成功，可能有数据也可能没数据
            if (sqlDT.Rows.Count > 0)
            {
                //sqlDT.Columns["原来的列名"].ColumnName = "新的列名";
                dgv.DataSource = sqlDT;
            }
            else { dgv.DataSource = null; }
        }

        private void query_btn_Click(object sender, EventArgs e)
        {
            //按钮功能是否启用
            query_gb.Enabled = dgv.Enabled = true; Management_gb.Enabled = false;
            _New.Enabled = true; _Edit.Enabled = _Delete.Enabled = _Save.Enabled = _Cancel.Enabled = false;
            //控件(非Label控件)全部初始
            foreach (Control c in Management_gb.Controls)
            {
                if (!(c is Label)) { c.Text = ""; }
            }

            if (!q_userNO_CB.Checked&&!q_medicineName_CB.Checked&&!q_time_CB.Checked)
            {
                MessageBox.Show("没有选择查询条件", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DataTable sqlDT = new DataTable();
            //显示t_record记录表的所有当天记录，即使没有m_user表的用户信息
            sql_Q = "Select register_date as \"记录日期\",m.user_no as \"工号\",user_name as \"姓名\",user_dept as \"部门\",user_sex as \"性别\",medicine_name as \"药品名称\",dose_specification as \"剂量规格\",outgoing_quantity as \"领出数量\",single_use as \"单次使用量\",batch_number as \"批号\",valid_date as \"有效期\",purpose as \"用途\",remark as \"备注\""
            + " From t_record m Left Join m_user u on m.user_no = u.user_no"
            + " Where";
            bool addStr = false;
            if (q_userNO_CB.Checked)
            {
                sql_Q += " m.user_no='" + q_userNO_TB.Text + "'";
                addStr = true;
            }
             if (q_medicineName_CB.Checked)
            {
                if (addStr) { sql_Q += " And"; }
                if (q_medicineName_TB.Text == "")
                {
                    ////sql += " medicine_name is NULL";
                    //sql += " medicine_name ='"+q_medicineName_TB.Text+"'";
                    MessageBox.Show("条件查询中，药品名称不能为空", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    sql_Q += " medicine_name~* '" + q_medicineName_TB.Text + "'";
                }
                addStr = true;
            }
            if (q_time_CB.Checked)
            {
                if (addStr) { sql_Q += " And"; }
                sql_Q += " register_date::date between '" + q_start_DTP.Value.ToString("yyyy-MM-dd")+"' and '"+q_end_DTP.Value.ToString("yyyy-MM-dd")+"'";
                addStr = true;
            }
            sql_Q += " Order By register_date Desc";
            dbFac.ExecuteDataTable(sql_Q, ref sqlDT);
            //查询成功，可能有数据也可能没数据
            if (sqlDT.Rows.Count > 0)
            {
                dgv.DataSource = sqlDT;
            }
            else
            {
                dgv.DataSource = null;
                MessageBox.Show("根据条件查询，数据库没所需记录", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {            
            if (userNO_TB.Text==""||medicineName_TB.Text=="") { MessageBox.Show("工号和药品名称不能为空" , "信息", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            string sql = "Insert Into t_record(user_no, register_date, medicine_name, dose_specification, outgoing_quantity, single_use, batch_number, valid_date, purpose, remark)"
 + "Values('"+userNO_TB.Text+"', Now(), '"+ medicineName_TB.Text+ "', '" + doseDpecification_TB.Text + "', '" + outgoingQuantity_TB.Text + "', '" + singleUse_TB.Text + "', '" 
 + batchNumber_TB.Text + "', ('"+ validDate_TP .Value.ToString("yyyy-MM-dd")+ "')::timestamp, '" + purpose_TB.Text + "', '" + remark_TB.Text + "')";
            dbFac.ExecuteSQL(sql);
            Main_Load(sender,e);
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //for (int i = 0; i < dgv.Columns.Count; i++)
            //{
            //    dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            //}
            //if (dgv.DataSource != null)
            //{
            //	dgv.Columns[4].Width = 110;
            //}

            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].HeaderCell.Value = ((dgv.RowCount - i).ToString());
                if (i%2==0)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightBlue;
                }
                else { dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.GreenYellow; }
                
                if (dgv.Rows[i].Cells["姓名"].Value.ToString() == "")
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nowRow = dgv.CurrentRow.Index;
            if (dgv.Rows.Count > 0)// && (dgv.Rows[0].Cells[0].Value)!="")
            {
                //DateTime all = Convert.ToDateTime(dgv.Rows[nowRow].Cells["记录日期"].Value);
                //TimeSpan time = all.TimeOfDay;
                //MessageBox.Show(all.ToShortDateString()+" "+time.ToString());

                DateTime temp = Convert.ToDateTime(dgv.Rows[nowRow].Cells["记录日期"].Value);
                
                register_date = temp.ToShortDateString()+" "+temp.TimeOfDay;
                userNO_TB.Text = dgv.Rows[nowRow].Cells["工号"].Value.ToString();
                userName_TB.Text = dgv.Rows[nowRow].Cells["姓名"].Value.ToString();
                userSex_TB.Text = dgv.Rows[nowRow].Cells["性别"].Value.ToString();
                userDept_TB.Text = dgv.Rows[nowRow].Cells["部门"].Value.ToString();
                medicineName_TB.Text = dgv.Rows[nowRow].Cells["药品名称"].Value.ToString();
                doseDpecification_TB.Text = dgv.Rows[nowRow].Cells["剂量规格"].Value.ToString();
                outgoingQuantity_TB.Text = dgv.Rows[nowRow].Cells["领出数量"].Value.ToString();
                singleUse_TB.Text = dgv.Rows[nowRow].Cells["单次使用量"].Value.ToString();
                batchNumber_TB.Text = dgv.Rows[nowRow].Cells["批号"].Value.ToString();
                validDate_TP.Value = Convert.ToDateTime(dgv.Rows[nowRow].Cells["有效期"].Value);
                purpose_TB.Text = dgv.Rows[nowRow].Cells["用途"].Value.ToString();
                remark_TB.Text = dgv.Rows[nowRow].Cells["备注"].Value.ToString();
                Management_gb.Enabled =false;
                _New.Enabled = _Edit.Enabled = _Delete.Enabled =  true;
                 _Cancel.Enabled = false;
            }
            //if (DataInformation.Proc_Data_Point != "")
            //{ _New.Enabled = true; }
        }

        private void cardID_TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            userInfo(cardID_TB.Text);
            cardID_TB.Text = "";
        }

        string buffer;
        void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            //接收到的信息
            string indata = sp.ReadExisting();
            //MessageBox.Show("来源于：" + sp.PortName+ "\r\n接收到："+indata);
            #region 要是不能接收到完整的记录就存起来(最后一位是终止符",")
            if (indata.Substring(indata.Length - 1, 1) != "\u0003")
            {
                buffer += indata;
                return;
            }
            string card_id = (buffer + indata).Replace("\u0002", "").Replace("\u0003", "").Replace("\r\n", "");
            buffer = "";
            #endregion


            if (card_id.Length != 10)
            {
                using (StreamWriter file = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"log\ErrorString" + ".txt", true))
                {
                    file.WriteLine(DateTime.Now.ToString("yyyy/MM/dd,HH:mm:ss,") + card_id);// 直接追加文件末尾，换行 
                }
            }
            userInfo(card_id);
        }

        void userInfo(string card_id)
        {
            string sql = String.Format("Select user_no,user_name,user_dept,user_sex From m_user Where card_id='{0}'", card_id);
            DataTable sqlDT = new DataTable();
            dbFac.ExecuteDataTable(sql, ref sqlDT);
            //查询成功，可能有数据也可能没数据
            if (sqlDT.Rows.Count > 0)
            {
                userNO_TB.Text = sqlDT.Rows[0]["user_no"].ToString();
                userName_TB.Text = sqlDT.Rows[0]["user_name"].ToString();
                userDept_TB.Text = sqlDT.Rows[0]["user_dept"].ToString();
                userSex_TB.Text = sqlDT.Rows[0]["user_sex"].ToString();
                //dgv.DataSource = sqlDT;
            }
            else
            {
                userNO_TB.Text = userName_TB.Text = userDept_TB.Text = userSex_TB.Text = "";
                MessageBox.Show("该工号没添加到数据库", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void _New_Click(object sender, EventArgs e)
        {
            //按钮功能是否启用
            Management_gb.Enabled = true; query_gb.Enabled=dgv.Enabled = false;
            _Save.Enabled = _Cancel.Enabled = true; _New.Enabled = _Edit.Enabled = _Delete.Enabled = false;
            //控件全部打开且值为空
            foreach (Control c in Management_gb.Controls)
            {
                c.Enabled = true;
                if (!(c is Label)) { c.Text = ""; }
            }
        }

        private void _Edit_Click(object sender, EventArgs e)
        {
            Management_gb.Enabled = true; query_gb.Enabled = dgv.Enabled = false;
            _New.Enabled =_Edit.Enabled= _Delete.Enabled = false;
            _Save.Enabled = _Cancel.Enabled = true;
            //控件全部打开
            foreach (Control c in Management_gb.Controls)
            {
                c.Enabled = true;
            }
            cardID_TB.Enabled = userNO_TB.Enabled = false;
        }

        private void _Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定删除该记录？", "删除:", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("Delete From t_record");
                sql.AppendFormat(" Where register_date='{0}'", register_date);
                sql.Append(" And user_no='"+userNO_TB.Text+"'");
                sql.Append(" And medicine_name='"+medicineName_TB.Text+"'");
                sql.Append(" And dose_specification='"+doseDpecification_TB.Text+"'");
                sql.Append(" And outgoing_quantity='"+outgoingQuantity_TB.Text+"'");
                sql.Append(" And single_use='"+singleUse_TB.Text+"'");
                sql.Append(" And batch_number='"+batchNumber_TB.Text+"'");
                sql.Append(" And valid_date='"+validDate_TP.Value.ToShortDateString()+" "+ validDate_TP.Value.TimeOfDay+ "'");
                sql.Append(" And purpose='"+purpose_TB.Text+"'");
                sql.Append(" And remark='"+remark_TB.Text+"'");
                dbFac.ExecuteSQL(sql.ToString());
                //MessageBox.Show("已删除,"+ dbFac.ExecuteSQL(sql.ToString()).ToString() + "条记录");
                lastQuery();
                _Cancel_Click(sender, e);
            }
        }

        private void _Save_Click(object sender, EventArgs e)
        {
            //值为空时返回
            if (userNO_TB.Text == "" || medicineName_TB.Text == "") { MessageBox.Show("工号和药品名称不能为空", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            string sql="";
            //增加记录
            if (userNO_TB.Enabled)
            {
                sql = "Insert Into t_record(user_no, register_date, medicine_name, dose_specification, outgoing_quantity, single_use, batch_number, valid_date, purpose, remark)"
+ "Values('" + userNO_TB.Text + "', Now(), '" + medicineName_TB.Text + "', '" + doseDpecification_TB.Text + "', '" + outgoingQuantity_TB.Text + "', '" + singleUse_TB.Text + "', '"
+ batchNumber_TB.Text + "', ('" + validDate_TP.Value.ToString("yyyy-MM-dd") + "')::timestamp, '" + purpose_TB.Text + "', '" + remark_TB.Text + "')";
            }
            //更改记录
            else
            {
                sql = string.Format("Update t_record Set medicine_name ='{0}'," +
                    "dose_specification ='{1}'," +
                    "outgoing_quantity ='{2}'," +
                    "single_use ='{3}'," +
                    "batch_number ='{4}'," +
                    "valid_date ='{5}'," +
                    "purpose ='{6}'," +
                    "remark ='{7}'" +
                    "Where user_no='{8}' And register_date='{9}'",medicineName_TB.Text,doseDpecification_TB.Text,outgoingQuantity_TB.Text,
                    singleUse_TB.Text,batchNumber_TB.Text,validDate_TP.Value.ToShortDateString(),
                    purpose_TB.Text,remark_TB.Text,userNO_TB.Text,register_date);
            }
            dbFac.ExecuteSQL(sql);
            lastQuery();
            _Cancel_Click(sender, e);
        }

        private void _Cancel_Click(object sender, EventArgs e)
        {
            //按钮功能是否启用
            query_gb.Enabled = dgv.Enabled = true; Management_gb.Enabled = false;
            _New.Enabled = true;_Edit.Enabled = _Delete.Enabled = _Save.Enabled = _Cancel.Enabled = false;
            //控件(非Label控件)全部初始
            foreach (Control c in Management_gb.Controls)
            {
                if (!(c is Label)) { c.Text = ""; }
            }
        }

        void lastQuery()
        {
            DataTable sqlDT = new DataTable();
            dbFac.ExecuteDataTable(sql_Q, ref sqlDT);
            //查询成功，可能有数据也可能没数据
            if (sqlDT.Rows.Count > 0)
            {
                dgv.DataSource = sqlDT;
            }
            else { dgv.DataSource = null; }
        }
    }
}
