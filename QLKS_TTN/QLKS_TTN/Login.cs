using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLKS_TTN.Models;
using System.Data.Entity.Migrations;

namespace QLKS_TTN
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@" Data Source = CHAMVU\CHAMVU; Initial Catalog = QLKS_TTN; Integrated Security = True");
            try
            {
                conn.Open();
                string tk = txtusername.Text;
                string mk = txtpass.Text;
                string sql = "select * from TAIKHOAN where USERNAME='" + tk + "' and MATKHAU='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read() == true)
                {
                    frmMain m = new frmMain();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kêt nối");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn thoát hay không", "Hỏi Thoát",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)

            {
                Close();
            }
        }

        private void chkhienthi_CheckedChanged(object sender, EventArgs e)
        {
            if(chkhienthi.Checked == true)
            { 
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }
    }
}




