using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyThuChi
{
    public partial class frmQL_NguoiDung : DevExpress.XtraEditors.XtraForm
    {

        public frmQL_NguoiDung()
        {
            InitializeComponent();
        }

        private void frmQL_NguoiDung_Load(object sender, EventArgs e)
        {
            this.qL_NGUOI_DUNGTableAdapter1.Fill(this.qltC_DataSet1.QL_NGUOI_DUNG);
            gridControl1.DataSource = qL_NGUOI_DUNGTableAdapter1.GetData();
            txt_tenDN.Enabled = false;
            txt_MK.Enabled = false;
            btn_Luu.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //gridView1.AddNewRow();
            txt_tenDN.Enabled = true;
            txt_MK.Enabled = true;
            btn_them.Enabled = false;
            btn_Luu.Enabled = true;


        }

        public DataTable Load_DL()
        {
            return qL_NGUOI_DUNGTableAdapter1.GetData();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            try
            {
                string mk = txt_MK.Text;
                bool hoatdong = checkEdit1.Checked ? true : false;
                if (qL_NGUOI_DUNGTableAdapter1.KT_KHoaChinh(txt_tenDN.Text) == 0)
                {
                    qL_NGUOI_DUNGTableAdapter1.Insert(txt_tenDN.Text, txt_MK.Text, hoatdong);
                    this.qL_NGUOI_DUNGTableAdapter1.Fill(this.qltC_DataSet1.QL_NGUOI_DUNG);
                    btn_them.Enabled = true;
                    txt_tenDN.Enabled = false;
                    txt_MK.Enabled = false;
                    btn_Luu.Enabled = false;
                    MessageBox.Show("Thêm người dùng thành công!");
                    txt_tenDN.Text = string.Empty;
                    txt_MK.Text = string.Empty;

                    gridControl1.DataSource = qL_NGUOI_DUNGTableAdapter1.GetData();
                }
                else
                {
                    MessageBox.Show("Người dùng đã tồn tại!!");
                    txt_tenDN.Text = string.Empty;
                    txt_tenDN.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Không thể thêm người dùng mới!!!! ");
            }


        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn muốn xóa người dùng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    bool hoatdong = checkEdit1.Checked ? true : false;
                    qL_NGUOI_DUNGTableAdapter1.Delete(txt_tenDN.Text, txt_MK.Text, hoatdong);
                    this.qL_NGUOI_DUNGTableAdapter1.Fill(this.qltC_DataSet1.QL_NGUOI_DUNG);

                    gridControl1.DataSource = qL_NGUOI_DUNGTableAdapter1.GetData();
                }
            }
            catch
            {
                XtraMessageBox.Show("Tài khoản đang dược sử dụng!!!!");
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            txt_tenDN.Text=gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tên đăng nhập").ToString();
        }

        //private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        //{
        //    //txt_tenDN.Text = gridView1.GetRowCellValue(e.RowHandle, "gridColumn1").ToString();
        //    //txt_MK.Text = gridView1.GetRowCellValue(e.RowHandle, "gridColumn2").ToString();
        //    ////checkEdit1.Checked=gridView1.GetRowCellValue(e.RowHandle, "Hoạt động").Ch

        //}
    }
}