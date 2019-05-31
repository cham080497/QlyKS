using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS_TTN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            nv.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.Show();
        }

        
        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong ph = new Phong();
            ph.Show();
        }

        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loạiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiPhong lp = new LoaiPhong();
            lp.Show();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DichVu dv = new DichVu();
            dv.Show();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thuephong tp = new Thuephong();
            tp.Show();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.Show();
        }
    }
}
