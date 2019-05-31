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
    public partial class Nhanvien : Form
    {
        
        DbQLKS_TTN db = new DbQLKS_TTN();
        SqlConnection conn = new SqlConnection();

        

        public void Clear()
        {
            txtmanv.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            
            txtmanv.Focus();
        }
       
        public string  ChuanHoachuoi( string a)
        {
            string s = "";
            if(a=="")
            {

            }
            else
            {
                a = a.Trim().ToLower();
                while (a.IndexOf( "\t")>=0)
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

        public Nhanvien()
        {
            InitializeComponent();
            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvnhanvien.DataSource = db.NHANVIENs.ToList();
        }
    
        private void txtmanv_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            
            Clear();
            if(txtmanv.Text==""||txthoten.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
            }
            else
            {
                btnlammoi_Click(sender, e);
            }
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgvnhanvien.DataSource = db.NHANVIENs.ToList();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
           
            try
            {
                NHANVIEN pra = new NHANVIEN();

                
                pra.MANV = int.Parse(txtmanv.Text);
                pra.HOTEN = txthoten.Text;
                pra.GIOITINH = cbxgioitinh.Text;
                pra.NGAYSINH = dtpngaysinh.Value;
                pra.SDT = txtsdt.Text;

                
                db.NHANVIENs.AddOrUpdate(pra);

                
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

        private void dgvnhanvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                if (dgvnhanvien.Rows[e.RowIndex].Cells["MANV"].Value != null)
                {
                    txtmanv.Text = dgvnhanvien.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                }
                if (dgvnhanvien.Rows[e.RowIndex].Cells["HOTEN"].Value != null)
                {
                    txthoten.Text = dgvnhanvien.Rows[e.RowIndex].Cells["HOTEN"].Value.ToString();
                }
                if (dgvnhanvien.Rows[e.RowIndex].Cells["DIACHI"].Value != null)
                {
                    txtdiachi.Text = dgvnhanvien.Rows[e.RowIndex].Cells["DIACHI"].Value.ToString();
                }
                if (dgvnhanvien.Rows[e.RowIndex].Cells["SDT"].Value != null)
                {
                    txtsdt.Text = dgvnhanvien.Rows[e.RowIndex].Cells["SDT"].Value.ToString();
                }
                if (dgvnhanvien.Rows[e.RowIndex].Cells["NGAYSINH"].Value != null)
                {
                    dtpngaysinh.Value = DateTime.Parse(dgvnhanvien.Rows[e.RowIndex].Cells["NGAYSINH"].Value.ToString());
                }
                if (dgvnhanvien.Rows[e.RowIndex].Cells["GIOITINH"].Value != null)
                {
                    cbxgioitinh.Text = dgvnhanvien.Rows[e.RowIndex].Cells["GIOITINH"].Value.ToString();
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
                

                db.Database.ExecuteSqlCommand("UPDATE TAIKHOAN SET MANV = NULL WHERE MANV = " + txtmanv.Text);
                db.Database.ExecuteSqlCommand("UPDATE HOADON SET MANV = NULL WHERE MANV = " + txtmanv.Text);
                db.Database.ExecuteSqlCommand("DELETE NHANVIEN WHERE MANV = " + txtmanv.Text);
                db.SaveChanges();
                MessageBox.Show("Xóa bản ghi thành công!");
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
        NHANVIEN nv = new NHANVIEN();
        private void btntim_Click_1(object sender, EventArgs e)
        {
           
            
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
