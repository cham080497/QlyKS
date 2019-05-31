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
    
    public partial class Phong : Form
    {
        DbQLKS_TTN db = new DbQLKS_TTN();
        public void ShowPhong(string sql)
        {
            Connection.OpenConnection();
            dgvphong.DataSource = Connection.LayDuLieu("Select MAPHONG as 'Mã phòng ',TENPHONG as'Tên phòng',LOAIPHONG as 'Loại phòng',TRANGTHAI as 'Trạng thái' from PHONG");
        }
        public void Clear()
        {
            txtmaphong.Clear();
            txttenphong.Clear();
            txtloaiphong.Clear();
            txttrangthai.Clear();
            txtmaphong.Focus();
        }

        
        public Phong()
        {
            InitializeComponent();
            this.ShowPhong("select*from PHONG");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgvphong.DataSource = db.PHONGs.ToList();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                PHONG ph = new PHONG();
                ph.MAPHONG = int.Parse(txtmaphong.Text);
                ph.MALOAI = int.Parse(txtloaiphong.Text);
                ph.TENPHONG = txttenphong.Text;
                ph.TRANGTHAI = txttrangthai.Text;

                db.PHONGs.AddOrUpdate(ph);
                db.SaveChanges();
                MessageBox.Show("Thêm mới thành công!");
                btnlammoi_Click(sender, e);
            }
            catch(Exception)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.Vui lòng nhập lại");
                return;
            }
        }

        private void dgvphong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvphong.Rows[e.RowIndex].Cells["MAPHONG"].Value != null)
                {
                    txtmaphong.Text = dgvphong.Rows[e.RowIndex].Cells["MAPHONG"].Value.ToString();
                }
                if (dgvphong.Rows[e.RowIndex].Cells["TENPHONG"].Value != null)
                {
                    txttenphong.Text = dgvphong.Rows[e.RowIndex].Cells["TENPHONG"].Value.ToString();
                }
                if (dgvphong.Rows[e.RowIndex].Cells["MALOAI"].Value != null)
                {
                    txtloaiphong.Text = dgvphong.Rows[e.RowIndex].Cells["MALOAI"].Value.ToString();
                }
                if (dgvphong.Rows[e.RowIndex].Cells["TRANGTHAI"].Value != null)
                {
                    txttrangthai.Text = dgvphong.Rows[e.RowIndex].Cells["TRANGTHAI"].Value.ToString();
                }

            }
            catch(Exception)
            {
                Clear();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn có chắc chắn thoát không?", "Hỏi thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                db.Database.ExecuteSqlCommand("update HOADON set MAPHONG=NULL WHERE MAPHONG= " + txtmaphong.Text);
                db.Database.ExecuteSqlCommand("DELETE  PHONG WHERE MAPHONG=" + txtmaphong.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa phòng thành công!");
                btnlammoi_Click(sender, e);
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
