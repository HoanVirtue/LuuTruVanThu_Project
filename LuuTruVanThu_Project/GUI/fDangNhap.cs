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

        private void LoadDonVi()
        {
            cbbDonVi.DataSource = DonViDAO.Instance.GetData();
            cbbDonVi.DisplayMember = "TenDonVi";
        }

        private void ValidateData()
        {
            if (string.IsNullOrEmpty(txbNam.Text))
            {
                ShowMessage(DangNhapMessage.VALIDATE_NAM_MESSAGE, TitleMessage.INFO_MESSAGE);
                return;
            }
        }

        private void ShowMessage(string message, string title = null)
        {
            MessageBox.Show(message, title);
        }
        #endregion


        #region Events
        private void fDangNhap_Load(object sender, EventArgs e)
        {
            LoadDonVi();
        }
        private void btnChon_Click(object sender, EventArgs e)
        {
            DonVis donVi = cbbDonVi.SelectedItem as DonVis;
            int nam = int.Parse(txbNam.Text);
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
