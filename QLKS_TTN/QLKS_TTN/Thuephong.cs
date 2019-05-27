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
    public partial class Thuephong : Form
    {
        DbQLKS_TTN db = new DbQLKS_TTN();

        public void ShowThuePhong(string sql)
        {
            Connection.OpenConnection();
            dgvthuephong.DataSource = Connection.LayDuLieu("select* from THUEPHONG");
            
        }

        public void Clear()
        {
            txtmakh.Clear();
            txtmaphong.Clear();           
            txtmakh.Focus();
        }
        public Thuephong()
        {
            InitializeComponent();
            this.ShowThuePhong("select* from THUEPHONG");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            DialogResult ret = MessageBox.Show("Bạn có muốn thoát hay không", "Hỏi Thoát",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)

            {
                frmMain f = new frmMain();
                f.Show();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult ret = MessageBox.Show("Bạn có muốn thoát hay không", "Hỏi Thoát",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)

            {
                frmMain f = new frmMain();
                f.Show();
                Close();
            }
        }
    }
}
