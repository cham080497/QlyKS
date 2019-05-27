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
    public partial class DichVu : Form
    {

        DbQLKS_TTN db = new DbQLKS_TTN();
        public void ShowDichVu(string sql)
        {
            Connection.OpenConnection();
            dgvdichvu.DataSource = Connection.LayDuLieu("Select* from DICHVU");
        }

        public void Clear()
        {
            txtmadv.Clear();
            txttendv.Clear();
            txtgiatien.Clear();
            txtmadv.Focus();

        }
        public DichVu()
        {
            InitializeComponent();
            this.ShowDichVu("select* from DICHVU");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                DICHVU dv = new DICHVU();
                dv.MADV = int.Parse(txtmadv.Text);
                dv.TENDV = txttendv.Text;
                dv.GIATIEN = int.Parse(txtgiatien.Text);

                db.DICHVUs.AddOrUpdate(dv);
                db.SaveChanges();
                MessageBox.Show("Thêm mới thành công!");
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
            dgvdichvu.DataSource = db.DICHVUs.ToList();
        }

        /*  private void dgvdichvu_RowEnter(object sender, DataGridViewCellEventArgs e)
          {
              try
              {
                  if (dgvdichvu.Rows[e.RowIndex].Cells["MADV"].Value !=null)
                      {
                      txttendv.Text = dgvdichvu.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
                  }
                  if (dgvdichvu.Rows[e.RowIndex].Cells["TENDV"].Value != null)
                  {
                      txttendv.Text = dgvdichvu.Rows[e.RowIndex].Cells["TENDV"].Value.ToString();
                  }
                  if (dgvdichvu.Rows[e.RowIndex].Cells["GIATIEN"].Value != null)
                  {
                      txtgiatien.Text= dgvdichvu.Rows[e.RowIndex].Cells["GIAITEN"].Value.ToString();
                  }
              }
              catch (Exception)
              {
                  Clear();
              }
          }*/



        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Bạn có chắc chắn thoát không?", "Hỏi thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {

                db.Database.ExecuteSqlCommand("DELETE  DICHVU WHERE MADV=" + txtmadv.Text);
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

        private void DichVu_Load(object sender, EventArgs e)
        {

        }

        private void dgvdichvu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //
            /*  private void dgvdichvu_RowEnter(object sender, DataGridViewCellEventArgs e)
              {
                  try
                  {
                      if (dgvdichvu.Rows[e.RowIndex].Cells["MADV"].Value !=null)
                          {
                          txttendv.Text = dgvdichvu.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
                      }*/
            try
            {
                if (dgvdichvu.Rows[e.RowIndex].Cells["MaDV"].Value != null)
                {
                    txtmadv.Text = dgvdichvu.Rows[e.RowIndex].Cells["MADV"].Value.ToString();
                }
                if(dgvdichvu.Rows[e.RowIndex].Cells["TENDV"].Value!=null)
                {
                    txttendv.Text = dgvdichvu.Rows[e.RowIndex].Cells["TENDV"].Value.ToString();

                }
                if(dgvdichvu.Rows[e.RowIndex].Cells["GIATIEN"].Value!=null)
                {
                    txtgiatien.Text = dgvdichvu.Rows[e.RowIndex].Cells["GIATIEN"].Value.ToString();
                }
            }
            catch(Exception)
            {
                Clear();
            }
        }
    }
}

