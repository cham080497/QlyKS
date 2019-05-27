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
    public partial class KhachHang : Form
    {
        DbQLKS_TTN db = new DbQLKS_TTN();

        public void ShowKhachHang( string sql)
        {
            Connection.OpenConnection();
            dgvkhachhang.DataSource = Connection.LayDuLieu("select*from KHACHHANG");
        }

        public void Clear()
        {
            txtmakh.Clear();
            txttenkh.Clear();
            txtsdt.Clear();
            txtcmnd.Clear();
            txtdiachi.Clear();
            txtmakh.Focus();           
        }

        public string ChuanHoaChuoi(string a)
        {
            string s = "";
            if (a == "")
            {

            }
            else
            {
                a = a.Trim().ToLower();
                while(a.IndexOf("\t")>0)
                {
                    a = a.Replace("\t", " ");

                }
                while(a.IndexOf("  ")>=0)
                {
                    a = a.Replace("  ", "  ");
                }
                string[] arr = a.Split(' ');

                foreach(string item in arr)
                {
                    s += item.Substring(0, 1).ToLower() + item.Substring(1).ToLower() + " ";
                }
            }
            return s;
        }
        public KhachHang()
        {
            InitializeComponent();
            this.ShowKhachHang("select* from KHACHHANG");
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgvkhachhang.DataSource = db.KHACHHANGs.ToList();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                KHACHHANG kh = new KHACHHANG();
                kh.MAKH = int.Parse(txtmakh.Text);
                kh.TENKH = txttenkh.Text;
                kh.SDT = txtsdt.Text;
                kh.CMT = int.Parse(txtcmnd.Text);
                kh.DIACHI = txtdiachi.Text;
                db.KHACHHANGs.AddOrUpdate(kh);
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

        private void dgvkhachhang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvkhachhang.Rows[e.RowIndex].Cells["MAKH"].Value != null)
                {
                    txtmakh.Text = dgvkhachhang.Rows[e.RowIndex].Cells["MAKH"].Value.ToString();
                }
               if(dgvkhachhang.Rows[e.RowIndex].Cells["TENKH"].Value !=null)
                {
                    txttenkh.Text = dgvkhachhang.Rows[e.RowIndex].Cells["TENKH"].Value.ToString();
                }
               if(dgvkhachhang.Rows[e.RowIndex].Cells["SDT"].Value !=null)
                {
                    txtsdt.Text = dgvkhachhang.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                }
                if (dgvkhachhang.Rows[e.RowIndex].Cells["CMT"].Value != null)
                {
                    txtcmnd.Text = dgvkhachhang.Rows[e.RowIndex].Cells["CMT"].Value.ToString();
                }
                if (dgvkhachhang.Rows[e.RowIndex].Cells["DIACHI"].Value != null)
                {
                    txtdiachi.Text = dgvkhachhang.Rows[e.RowIndex].Cells["DIACHI"].Value.ToString();
                }

            }
            catch(Exception)
            {
                Clear();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK==MessageBox.Show("Bạn có chắc chắn xóa không?","Hỏi Xóa",MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
            {
                db.Database.ExecuteSqlCommand("UPDATE HOADON SET MAKH =NULL WHERE MAKH=" + txtmakh.Text);
                db.Database.ExecuteSqlCommand("DELETE KHACHHANG WHERE MAKH=" + txtmakh.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa khách hàng thành công!");
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
    }
    
}
