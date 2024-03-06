using LuuTruVanThu_Project.DAO;
using LuuTruVanThu_Project.DTO;
using LuuTruVanThu_Project.Message;
using System;
using System.Windows.Forms;

namespace LuuTruVanThu_Project.GUI
{
    public partial class fDangNhap : Form
    {
        #region Methods
        public fDangNhap()
        {
            InitializeComponent();
        }
        private void ValidateData()
        {
            if (string.IsNullOrEmpty(tvNam.Text))
            {
                ShowMessage(DangNhapMessage.VALIDATE_DATA, TitleMessage.WARNING_MESSAGE);
                return;
            }
        }

        private static void ShowMessage(string message, string title = null)
        {
            if (title != null)
                MessageBox.Show(message, title);
            else
                MessageBox.Show(message);
        }
        #endregion

        #region Events
        private void fDangNhap_Load(object sender, EventArgs e)
        {
            cbDonVi.DataSource = DonViDAO.Instance.GetData();
            cbDonVi.DisplayMember = "TenDonVi";
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DonVis donVi = cbDonVi.SelectedItem as DonVis;
            int nam = int.Parse(tvNam.Text);
            ValidateData();
            if (DonViDAO.Instance.CheckLogin(donVi, nam))
            {
                ShowMessage(DangNhapMessage.LOGIN_SUCCESS, TitleMessage.INFO_MESSAGE);
                fTrangChu form = new fTrangChu();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                ShowMessage(DangNhapMessage.LOGIN_FAIL, TitleMessage.WARNING_MESSAGE);
            }
        }
        #endregion

    }
}
