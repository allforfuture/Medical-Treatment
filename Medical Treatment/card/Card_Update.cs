using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Treatment.card
{
    public partial class Card_Update : Form
    {
        public Card_Update()
        {
            InitializeComponent();
        }

        private void TxtCardID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            StringBuilder sql = new StringBuilder();
            sql.AppendLine("SELECT user_no,user_name,user_dept,user_sex");
            sql.AppendLine(string.Format("FROM m_user WHERE card_id='{0}'",txtCardID.Text));
            DataTable dt = new DataTable();
            new DBFactory().ExecuteDataTable(sql.ToString(), ref dt);
            //查询成功，可能有数据也可能没数据
            if (dt.Rows.Count > 0)
            {
                txtUserID.Text = dt.Rows[0]["user_no"].ToString();
                txtUserName.Text = dt.Rows[0]["user_name"].ToString();
                txtDept.Text = dt.Rows[0]["user_dept"].ToString();
                cboSex.Text = dt.Rows[0]["user_sex"].ToString();

                txtCardID.Enabled = false;
                txtUserID.Enabled = true;
                txtUserName.Enabled = true;
                txtDept.Enabled = true;
                cboSex.Enabled = true;
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("根据条件查询，数据库没所需记录，请先添加IC卡", "查询", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCardID.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("卡号和姓名不能为空", "卡号修改", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sql = string.Format(
@"update m_user
set user_no='{0}',
user_name='{1}',
user_dept='{2}',
user_sex='{3}'
where card_id='{4}'"
, txtUserID.Text, txtUserName.Text, txtDept.Text, cboSex.Text, txtCardID.Text);
            new DBFactory().ExecuteSQL(sql);
            this.Close();
        }
    }
}
