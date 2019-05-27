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
        // cái biến này để kết nối tới csdl
        DbQLKS_TTN db = new DbQLKS_TTN();

        public void ShowNhanVien(string sql)
        {
            Connection.OpenConnection();
            dgvnhanvien.DataSource = Connection.LayDuLieu("USP_GetAllNV");

        }

        public void Clear()
        {
            txtmanv.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            txtsdt.Clear();
            
            txtmanv.Focus();
        }
        //tạo hàm chuẩn hóa chuối để chuẩn hóa chuỗi nhaaoj vào trong tên nhân viên
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

        //hàm kiểm tra chuỗi xem có rỗng hay k
        public bool KiemTraChuoi( string a,string b)
        {
            if(a==""&&b=="")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin");
                txtmanv.Focus();
                return true;
            }
            else if(a=="")
            {
                MessageBox.Show("chưa nhập mã nhân viên");
                txtmanv.Focus();
                return true;
            }
            else if(b=="")
            {
                MessageBox.Show("chưa nhập tên nhân viên");
                txthoten.Focus();
                return true;
            }
            return true;
        }

        //kiểm tra trùng mã
        public bool KiemTraTrungMa(string a)
        {
            //lay ra mã khoa của từng ô
            int chiso = dgvnhanvien.CurrentRow.Index;
            for(int i=0;i<dgvnhanvien.Rows.Count;i++)
            {
                if(a==dgvnhanvien[a,chiso].Value.ToString())
                {

                    MessageBox.Show("Trùng mã nhân viên");
                    return false;
                }
            }
            return true;
        }

        //thêm mới dữ liệu
        public Nhanvien()
        {
            InitializeComponent();
            this.ShowNhanVien("USP_GetAllNV");
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
           
        }
    
        private void txtmanv_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // khi bấm vào nút lưu thì nó sẽ làm trống các ô để mình nhập vào
            Clear();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgvnhanvien.DataSource = db.NHANVIENs.ToList();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            // bấm nút lưu thì nó sẽ lưu bản ghi
            try
            {
                NHANVIEN pra = new NHANVIEN();

                // gán giá trị từ textbox vào biến
                pra.MANV = int.Parse(txtmanv.Text);
                pra.HOTEN = txthoten.Text;
                pra.GIOITINH = cbxgioitinh.Text;
                pra.NGAYSINH = dtpngaysinh.Value;
                pra.SDT = txtsdt.Text;

                // thêm hoặc update bản ghi của nhân viên từ biến
                db.NHANVIENs.AddOrUpdate(pra);

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

        private void dgvnhanvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // cái này để xử lý nếu mình click vào một ô trong datagridview
            try
            {
                // cái này là xét dòng vừa click vào, hoặc vừa chọn vào: dgvnhanvien.SelectedRows[0]

                // cái này để gán vào textbox
                // mấy cái if này là để xét nếu cái ô = null
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
                // nếu gặp trường hợp không thể load được -> làm trống tất cả các ô
                Clear();
            }
}

        private void btnxoa_Click(object sender, EventArgs e)
        {
            // cái dòng này để hỏi có chắc chắn muốn xóa không, nếu bấm vào ok -> xóa, còn ko thì out
            if (DialogResult.OK == MessageBox.Show("Xóa bản ghi hiện tại sẽ làm thay đổi hoặc xóa các bản ghi liên kết!\nBạn có muốn tiếp tục không?"
                , "Cảnh báo xóa!", MessageBoxButtons.OKCancel))
            {
                // muốn xóa thằng nhân viên này thì phải xóa các bản ghi dùng mã nhân viên làm khóa chính (trong bảng khác)
                // và thay đổi các bản ghi dùng mã nhân viên làm khóa phụ (có thể update cho nó = null, hoặc nếu xóa luôn nếu thích)

                // trong bảng nhân viên thì có bảng hóa đơn + tài khoản lấy mã nhân viên làm khóa phụ
                // có thể sửa thành null các bản ghi dùng mã nhân viên, hoặc xóa cmn đi nếu cần

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

        private void btntim_Click(object sender, EventArgs e)
        {
            txttim.ShortcutsEnabled.ToString();
        }
    }
}
