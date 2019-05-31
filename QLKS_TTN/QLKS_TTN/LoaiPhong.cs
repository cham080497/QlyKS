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
    public partial class LoaiPhong : Form
    {
        DbQLKS_TTN db = new DbQLKS_TTN();

       

        public void Clear()
        {
            txtmaloai.Clear();
            txttenloai.Clear();
            txtgia.Clear();
            txtghichu.Clear();
            txtmaloai.Focus();
        }
        public LoaiPhong()
        {
            InitializeComponent();
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgvloaiphong.DataSource = db.LOAIPHONGs.ToList();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                LOAIPHONG lp = new LOAIPHONG();
                lp.MALOAI = int.Parse(txtmaloai.Text);
                lp.TENLOAI = txttenloai.Text;
                lp.GIA =int.Parse( txtgia.Text);
                lp.GHICHU = txtghichu.Text;

                db.LOAIPHONGs.AddOrUpdate(lp);
                db.SaveChanges();
                MessageBox.Show("Thêm mới thành công!");
                btnlammoi_Click(sender, e);
            }
            catch(Exception)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin.Vui lòng nhập lại!");
                return;
            }

        }

        private void dgvloaiphong_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvloaiphong.Rows[e.RowIndex].Cells["MALOAI"].Value != null)
                {
                   txtmaloai.Text= dgvloaiphong.Rows[e.RowIndex].Cells["MALOAI"].Value.ToString();
                }
                if (dgvloaiphong.Rows[e.RowIndex].Cells["TENLOAI"].Value != null)
                {
                   txttenloai.Text = dgvloaiphong.Rows[e.RowIndex].Cells["TENLOAI"].Value.ToString();
                }
                if (dgvloaiphong.Rows[e.RowIndex].Cells["GIA"].Value != null)
                {
                    txtgia.Text = dgvloaiphong.Rows[e.RowIndex].Cells["GIA"].Value.ToString();
                }
                if (dgvloaiphong.Rows[e.RowIndex].Cells["GHICHU"].Value != null)
                {
                   txtghichu.Text = dgvloaiphong.Rows[e.RowIndex].Cells["GHICHU"].Value.ToString();
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
                db.Database.ExecuteSqlCommand("update PHONG set MALOAI=NULL WHERE MALOAI= " + txtmaloai.Text);
                db.Database.ExecuteSqlCommand("DELETE  PHONG WHERE MAPHONG=" + txtmaloai.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa phòng thành công!");
                btnlammoi_Click(sender, e);
            }
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

        private void dgvloaiphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvloaiphong.DataSource = db.LOAIPHONGs.ToList();
        }

        private void LoaiPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
