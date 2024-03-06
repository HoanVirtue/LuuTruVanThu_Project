using LuuTruVanThu_Project.Constant;
using System;
using System.Windows.Forms;

namespace LuuTruVanThu_Project.GUI
{
    public partial class fTrangChu : Form
    {

        public fTrangChu()
        {
            InitializeComponent();
        }

        private void OpenForm(int name)
        {
            Form form = null;
            switch (name)
            {
                case TrangChuConstant.FORM_VANBANDEN:
                    form = new fVanBanDen();
                    break;
                case TrangChuConstant.FORM_VANBANDI:
                    form = new fVanBanDi();
                    break;
                case TrangChuConstant.FORM_SEARCH_VANBANDEN:
                    form = new fTimKiemVanBanDen();
                    break;
                case TrangChuConstant.FORM_SEARCH_VANBANDI:
                    form = new fTimKiemVanBanDi();
                    break;
                case TrangChuConstant.FORM_TONGHOP:
                    form = new fTongHop();
                    break;
            }
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void vănBảnĐếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(TrangChuConstant.FORM_VANBANDEN);

        }

        private void vănBảnĐiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(TrangChuConstant.FORM_VANBANDI);
        }

        private void tìmKiếmVănBảnĐếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(TrangChuConstant.FORM_SEARCH_VANBANDEN);
        }

        private void tìmKiếmVănBảnĐiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(TrangChuConstant.FORM_SEARCH_VANBANDI);
        }

        private void tổngHợpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(TrangChuConstant.FORM_TONGHOP);
        }
    }
}
