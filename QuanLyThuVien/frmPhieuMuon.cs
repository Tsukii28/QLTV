using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyThuVien.Report;

namespace QuanLyThuVien
{
    public partial class frmPhieuMuon : Form
    {
        rptPhieuMuon rpt = new rptPhieuMuon();
        public frmPhieuMuon()
        {
            InitializeComponent();
        }        

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            this.rpt = frmMuonSach.rpt;
            documentViewer1.PrintingSystem = rpt.PrintingSystem;
            rpt.CreateDocument();
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}