using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.CodeParser;

namespace QuanLyThuVien
{
    public partial class frmDatLaiMatKhau : Form
    {
        Con_CRUD con = new Con_CRUD();
        string sqlR = "select id_user, fullname, dob, number from users";
        public frmDatLaiMatKhau()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void frmDatLaiMatKhau_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DataTable dt = con.readData(sqlR);
            if (dt != null)
            {
                gcNhanVien.DataSource = dt;
            }
        }

        private void GcNhanVien_EmbeddedNavigator_ButtonClick(object sender, EventArgs e)
        {            
        }

        private void btnReset_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int row_index = gvNhanVien.FocusedRowHandle;
            string id_user = gvNhanVien.GetRowCellValue(row_index, "id_user").ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn đặt lại mật khẩu cho nhân viên đang chọn?\r\nMật khẩu sau khi đặt lại sẽ là: 123456", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlD = "update users set password = 'e1adc3949ba59abbe56e057f2f883e' where id_user = '" + id_user + "'";
                if (con.exeData(sqlD))
                {
                    loadData();
                    MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật mật khẩu thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void gcNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}