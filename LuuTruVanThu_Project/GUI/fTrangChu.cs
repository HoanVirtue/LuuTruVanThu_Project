using LuuTruVanThu_Project.Constant;
using System.Windows.Forms;

namespace LuuTruVanThu_Project.GUI
{
    public partial class fTrangChu : Form
    {
        #region Methods
        public fTrangChu()
        {
            InitializeComponent();
        }

        private void OpenForm(int nam)
        {
            Form form = null;
            switch (nam)
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
        #endregion

        #region Events
        private void msVanBanDen_Click(object sender, System.EventArgs e)
        {
            OpenForm(TrangChuConstant.FORM_VANBANDEN);
        }

        private void msVanBanDi_Click(object sender, System.EventArgs e)
        {
            OpenForm(TrangChuConstant.FORM_VANBANDI);
        }

        private void msThoat_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void msTimKiemVanBanDen_Click(object sender, System.EventArgs e)
        {
            OpenForm(TrangChuConstant.FORM_SEARCH_VANBANDEN);
        }

        private void msTimKiemVanBanDi_Click(object sender, System.EventArgs e)
        {
            OpenForm(TrangChuConstant.FORM_SEARCH_VANBANDI);
        }

        private void msTongHop_Click(object sender, System.EventArgs e)
        {
            OpenForm(TrangChuConstant.FORM_TONGHOP);
        }
        #endregion

    }
}
