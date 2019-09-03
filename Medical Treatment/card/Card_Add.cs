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
    public partial class Card_Add : Form
    {
        public Card_Add()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtCardID.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("卡号和姓名不能为空","卡号添加",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string sql = string.Format(
@"INSERT INTO m_user (card_id, user_no, user_name, user_dept,user_sex)
VALUES ('{0}', '{1}', '{2}', '{3}','{4}')"
,txtCardID.Text,txtUserID.Text,txtUserName.Text,txtDept.Text,cboSex.Text);
            new DBFactory().ExecuteSQL(sql);
            this.Close();
        }
    }
}
