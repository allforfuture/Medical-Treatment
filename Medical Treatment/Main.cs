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
        string register_date;
        public Main()
        {
            InitializeComponent();
            this.Text += "_" + Application.ProductVersion.ToString();
            dgv.RowHeadersWidth = 55;
            dtpStart.Value = DateTime.Today;//.AddDays(-0);
            dtpEnd.Value = DateTime.Today;//.AddHours(23).AddMinutes(59).AddSeconds(59);
            bool enabledPort = ConfigurationManager.AppSettings["enabledPort"] == "1" ? true : false;
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
            BtnQuery_Click(sender, e);
        }

        private void 添加卡号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "Card_Add")
                {
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                new card.Card_Add().Show();
            }
        }

        private void 修改卡号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Text == "Card_Update")
                {
                    isOpen = true;
                }
            }
            if (!isOpen)
            {
                new card.Card_Update().Show();
            }
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            //按钮功能是否启用
            gbxQuery.Enabled = dgv.Enabled = true; gbxHistory.Enabled = false;
            btnNew.Enabled = true; btnUpdate.Enabled = btnDelete.Enabled = btnSave.Enabled = btnCancel.Enabled = false;
            //控件(非Label控件)全部初始
            foreach (Control c in gbxHistory.Controls)
            {
                if (!(c is Label)) { c.Text = ""; }
            }

            StringBuilder sql = new StringBuilder();
            sql.AppendLine(
@"SELECT register_date AS 记录日期,
m.card_id AS 卡号,
u.user_no AS 工号,
user_name AS 姓名,
user_dept AS 部门,
user_sex AS 性别,
medicine_name AS 药品名称,
dose_specification AS 剂量规格,
outgoing_quantity AS 领出数量,
single_use AS 单次使用量,
batch_number AS 批号,
valid_date AS 有效期,
purpose AS 用途,
remark AS 备注
FROM t_history m
LEFT JOIN m_user u ON m.card_id = u.card_id
WHERE");
            bool isFirst = true;
            if (chkUserNO.Checked)
            {
                //if (txtUserNO_Q.Text == "")
                //{
                //    MessageBox.Show("条件查询中，工号不能为空", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                if (!isFirst) { sql.Append(" AND "); }
                sql.AppendLine(string.Format("m.user_no='{0}'", txtUserNO_Q.Text));
                isFirst = false;
            }

            if (chkMedicineName.Checked)
            {
                //if (txtMedicineName_Q.Text == "")
                //{
                //    MessageBox.Show("条件查询中，药品名称不能为空", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                if (!isFirst) { sql.Append(" AND "); }
                sql.AppendLine(string.Format("medicine_name~* '{0}'", txtMedicineName_Q.Text));
                isFirst = false;
            }

            if (chkTime.Checked)
            {
                if (!isFirst) { sql.Append(" AND "); }
                sql.AppendLine(string.Format("register_date::date between '{0}' and '{1}'",
                    dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd")));
                isFirst = false;
            }

            sql.AppendLine("Order By register_date Desc");

            if (isFirst)
                return;

            DataTable dt = new DataTable();
            dbFac.ExecuteDataTable(sql.ToString(), ref dt);
            dgv.DataSource = dt;
            dgv.AutoResizeColumns();
        }

        private void TxtCardID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            userInfo(txtCardID.Text);
            txtCardID.SelectAll();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            //按钮功能是否启用
            gbxHistory.Enabled = true; gbxQuery.Enabled = dgv.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = true; btnNew.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
            //控件全部打开且值为空
            foreach (Control c in gbxHistory.Controls)
            {
                c.Enabled = true;
                if (!(c is Label)) { c.Text = ""; }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            gbxHistory.Enabled = true; gbxQuery.Enabled = dgv.Enabled = false;
            btnNew.Enabled = btnUpdate.Enabled = btnDelete.Enabled = false;
            btnSave.Enabled = btnCancel.Enabled = true;
            //控件全部打开
            foreach (Control c in gbxHistory.Controls)
            {
                c.Enabled = true;
            }
            txtCardID.Enabled = txtUserNO.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确定删除该记录？", "删除:", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("Delete From t_history");
                sql.AppendFormat("Where register_date='{0}'\r\n", register_date);
                sql.AppendLine("And card_id='" + txtCardID.Text + "'");
                sql.AppendLine("And medicine_name='" + txtMedicineName.Text + "'");
                sql.AppendLine("And dose_specification='" + txtDosageSpecification.Text + "'");
                sql.AppendLine("And outgoing_quantity='" + txtQty.Text + "'");
                sql.AppendLine("And single_use='" + txtSingleUse.Text + "'");
                sql.AppendLine("And batch_number='" + txtLot.Text + "'");
                sql.AppendLine("And valid_date='" + dtpValidDate.Value.ToShortDateString() + " " + dtpValidDate.Value.TimeOfDay + "'");
                sql.AppendLine("And purpose='" + txtPurpose.Text + "'");
                sql.AppendLine("And remark='" + txtRemark.Text + "'");
                dbFac.ExecuteSQL(sql.ToString());
                BtnQuery_Click(sender, e);
                BtnCancel_Click(sender, e);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //值为空时返回
            if (txtCardID.Text == "" || txtMedicineName.Text == "")
            { MessageBox.Show("卡号和药品名称不能为空", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            StringBuilder sql = new StringBuilder();

            //增加记录
            if (txtCardID.Enabled)
            {
                sql.AppendLine("INSERT INTO t_history");
                sql.AppendLine("(card_id, register_date, medicine_name, dose_specification, outgoing_quantity, single_use, batch_number, valid_date, purpose, remark)");
                sql.AppendFormat("VALUES('{0}', Now(), '{1}', '{2}', '{3}', '{4}', '{5}', ('{6}')::TIMESTAMP, '{7}', '{8}')",
                    txtCardID.Text, txtMedicineName.Text, txtDosageSpecification.Text, txtQty.Text, txtSingleUse.Text, txtLot.Text, dtpValidDate.Value.ToString("yyyy-MM-dd"), txtPurpose.Text, txtRemark.Text);
            }
            //更改记录
            else
            {
                sql.AppendLine("UPDATE t_history");
                sql.AppendFormat("SET medicine_name ='{0}',dose_specification ='{1}',outgoing_quantity ='{2}',single_use ='{3}',batch_number ='{4}',valid_date ='{5}',purpose ='{6}',remark ='{7}'\r\n",
                    txtMedicineName.Text, txtDosageSpecification.Text, txtQty.Text, txtSingleUse.Text, txtLot.Text, dtpValidDate.Value.ToString("yyyy/MM/dd"), txtPurpose.Text, txtRemark.Text);
                sql.AppendFormat("WHERE card_id='{0}' AND register_date='{1}'",
                    txtCardID.Text, register_date);
            }
            dbFac.ExecuteSQL(sql.ToString());
            BtnQuery_Click(sender, e);
            BtnCancel_Click(sender, e);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //按钮功能是否启用
            gbxQuery.Enabled = dgv.Enabled = true; gbxHistory.Enabled = false;
            btnNew.Enabled = true; btnUpdate.Enabled = btnDelete.Enabled = btnSave.Enabled = btnCancel.Enabled = false;
            //控件(非Label控件)全部初始
            foreach (Control c in gbxHistory.Controls)
            {
                if (!(c is Label)) { c.Text = ""; }
            }
        }




        private void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
                if (i % 2 == 0)
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

        private void Dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nowRow = dgv.CurrentRow.Index;
            if (dgv.Rows.Count > 0)// && (dgv.Rows[0].Cells[0].Value)!="")
            {
                //DateTime all = Convert.ToDateTime(dgv.Rows[nowRow].Cells["记录日期"].Value);
                //TimeSpan time = all.TimeOfDay;
                //MessageBox.Show(all.ToShortDateString()+" "+time.ToString());

                DateTime temp = Convert.ToDateTime(dgv.Rows[nowRow].Cells["记录日期"].Value);

                register_date = temp.ToShortDateString() + " " + temp.TimeOfDay;
                txtCardID.Text = dgv.Rows[nowRow].Cells["卡号"].Value.ToString();
                txtUserNO.Text = dgv.Rows[nowRow].Cells["工号"].Value.ToString();
                txtUserName.Text = dgv.Rows[nowRow].Cells["姓名"].Value.ToString();
                txtSex.Text = dgv.Rows[nowRow].Cells["性别"].Value.ToString();
                txtDept.Text = dgv.Rows[nowRow].Cells["部门"].Value.ToString();
                txtMedicineName.Text = dgv.Rows[nowRow].Cells["药品名称"].Value.ToString();
                txtDosageSpecification.Text = dgv.Rows[nowRow].Cells["剂量规格"].Value.ToString();
                txtQty.Text = dgv.Rows[nowRow].Cells["领出数量"].Value.ToString();
                txtSingleUse.Text = dgv.Rows[nowRow].Cells["单次使用量"].Value.ToString();
                txtLot.Text = dgv.Rows[nowRow].Cells["批号"].Value.ToString();
                dtpValidDate.Value = Convert.ToDateTime(dgv.Rows[nowRow].Cells["有效期"].Value);
                txtPurpose.Text = dgv.Rows[nowRow].Cells["用途"].Value.ToString();
                txtRemark.Text = dgv.Rows[nowRow].Cells["备注"].Value.ToString();
                gbxHistory.Enabled = false;
                btnNew.Enabled = btnUpdate.Enabled = btnDelete.Enabled = true;
                btnCancel.Enabled = false;
            }
        }


        #region 串口接收动作
        string buffer;
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
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
        #endregion

        private void userInfo(string card_id)
        {
            string sql = String.Format("Select user_no,user_name,user_dept,user_sex From m_user Where card_id='{0}'", card_id);
            DataTable dt = new DataTable();
            dbFac.ExecuteDataTable(sql, ref dt);
            //查询成功，可能有数据也可能没数据
            if (dt.Rows.Count > 0)
            {
                txtUserNO.Text = dt.Rows[0]["user_no"].ToString();
                txtUserName.Text = dt.Rows[0]["user_name"].ToString();
                txtDept.Text = dt.Rows[0]["user_dept"].ToString();
                txtSex.Text = dt.Rows[0]["user_sex"].ToString();
                //dgv.DataSource = sqlDT;
            }
            else
            {
                txtUserNO.Text = txtUserName.Text = txtDept.Text = txtSex.Text = "";
                MessageBox.Show("该卡号没添加到数据库，请添加后再操作", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}