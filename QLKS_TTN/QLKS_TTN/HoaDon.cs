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
    public partial class HoaDon : Form
    {
        DbQLKS_TTN db = new DbQLKS_TTN();

        public void ShowHoaDon( string sql)
        {
            Connection.OpenConnection();
            dgvhoadon.DataSource = Connection.LayDuLieu("usp_hoadon");
        }

        public void Clear()
        {
            txtmahd.Clear();
            txtmahd.Clear();
            txtmanv.Clear();
            txtmaphong.Clear();
            txtmahd.Focus();

        }
        public HoaDon()
        {
            InitializeComponent();
            this.ShowHoaDon("usp_hoadon");
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

        private void btnthem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                HOADON hd = new HOADON();
                hd.MAHD = int.Parse(txtmahd.Text);
                hd.MAKH = int.Parse(txtmakh.Text);
                hd.MANV = int.Parse(txtmanv.Text);
                hd.MATHUEPHONG = int.Parse(txtmaphong.Text);

                db.HOADONs.AddOrUpdate(hd);
                db.SaveChanges();
                MessageBox.Show("Thêm mới thành công");

                btnlammoi_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.Vui lòng nhập lại!");
                return;
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgvhoadon.DataSource = db.HOADONs.ToList();
        }

        private void dgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
