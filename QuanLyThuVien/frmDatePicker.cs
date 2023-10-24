using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// đéo ổn r



namespace QuanLyThuVien
{
    public partial class frmDatePicker : Form
    {
        public static string date = "";

        public DialogResult DialogResult { get; private set; }

        public frmDatePicker()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if((txtDate.EditValue == null) || (txtDate.EditValue.ToString().Equals("")))
            {
                MessageBox.Show("Bạn chưa chọn ngày hẹn trả sách\r\nVui lòng chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(Convert.ToDateTime(txtDate.EditValue.ToString()).CompareTo(DateTime.Now.Date) < 0)
            {
                MessageBox.Show("Ngày hẹn trả sách không được nhỏ hơn ngày hiện tại\r\nVui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            date = txtDate.EditValue.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Close()
        {
            throw new NotImplementedException();// no là cái đéo gì thế này
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmDatePicker_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
    }
}