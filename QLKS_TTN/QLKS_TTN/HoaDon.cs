using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKS_TTN.Models;
using System.Data.Entity.Migrations;

namespace QLKS_TTN
{
    public partial class HoaDon : Form
    {
        DbQLKS_TTN db = new DbQLKS_TTN();
        public HoaDon()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtMaHD.Clear();
            txtMaTP.Clear();
            txtMaNV.Clear();
            txtMaKH.Clear();
            txtThanhTien.Clear();
            txtGhiChu.Clear();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = db.HOADONs.ToList();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = db.HOADONs.ToList();
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

                // gán giá trị từ textbox vào biến

                hd.MAHD = int.Parse(txtMaHD.Text);
                hd.MATHUEPHONG = int.Parse(txtMaTP.Text);
                hd.MANV = int.Parse(txtMaNV.Text);
                hd.MAKH = int.Parse(txtMaKH.Text);
                hd.THANHTIEN = int.Parse(txtThanhTien.Text);
                hd.GHICHU = txtGhiChu.Text;
                // thêm hoặc update bản ghi của nhân viên từ biến
                db.HOADONs.AddOrUpdate(hd);

                // lưu thay đổi -- cái này quan trọng nhá, không có là sẽ không có trong csdl đâu
                db.SaveChanges();
                MessageBox.Show("Thêm dữ bản ghi mới thành công!");

                btnlammoi_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Một hoặc nhiều thông tin đang để trống!\nXin hãy kiểm tra lại!");
                return;
            }
        }

        private void dgvHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHoaDon.Rows[e.RowIndex].Cells["MAHD"].Value != null)
                {
                    txtMaHD.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MAHD"].Value.ToString();
                }
                if (dgvHoaDon.Rows[e.RowIndex].Cells["MATHUEPHONG"].Value != null)
                {
                    txtMaTP.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MATHUEPHONG"].Value.ToString();
                }
                if (dgvHoaDon.Rows[e.RowIndex].Cells["MANV"].Value != null)
                {
                    txtMaNV.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                }
                if (dgvHoaDon.Rows[e.RowIndex].Cells["MAKH"].Value != null)
                {
                    txtMaKH.Text = dgvHoaDon.Rows[e.RowIndex].Cells["MAKH"].Value.ToString();
                }
                if (dgvHoaDon.Rows[e.RowIndex].Cells["THANHTIEN"].Value != null)
                {
                    txtThanhTien.Text = dgvHoaDon.Rows[e.RowIndex].Cells["THANHTIEN"].Value.ToString();
                }
                if (dgvHoaDon.Rows[e.RowIndex].Cells["GHICHU"].Value != null)
                {
                    txtGhiChu.Text = dgvHoaDon.Rows[e.RowIndex].Cells["GHICHU"].Value.ToString();
                }
            }
            catch (Exception)
            {
                Clear();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Xóa bản ghi hiện tại sẽ làm thay đổi hoặc xóa các bản ghi liên kết!\nBạn có muốn tiếp tục không?"
                , "Cảnh báo xóa!", MessageBoxButtons.OKCancel))
            {
                db.Database.ExecuteSqlCommand("DELETE HOADON SET MAHD = NULL WHERE MANV = " + txtMaHD.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa bản ghi thành công!");
                btnlammoi_Click(sender, e);
            }
        }
    }
}
