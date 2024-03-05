using LuuTruVanThu_Project.Data;
using LuuTruVanThu_Project.DTO;
using System;
using System.Windows.Forms;

namespace LuuTruVanThu_Project.GUI
{
    public partial class fVanBanDen : Form
    {
        #region Methods
        public fVanBanDen()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            cbbDoMat.DataSource = VanBanDenData.doMats;
            cbbDoKhan.DataSource = VanBanDenData.doKhans;
            cbbLoaiVanBan.DataSource = VanBanDenData.loaiVanBans;
            cbbNoiNhan.DataSource = VanBanDenData.noiNhans;
            btTuLieuCongVan.Enabled = false;
        }
        private static void ShowMessage(string message, string title = null)
        {
            if (title != null)
                MessageBox.Show(message, title);
            else
                MessageBox.Show(message);
        }

        private void LoadDSVanBanDen()
        {

        }

        private VanBanDens GetDataForm()
        {
            VanBanDens vanBan = new VanBanDens();
            vanBan.SoDen = tbSoDen.Text;
            vanBan.SoKyHieu = tbKyHieu.Text;
            vanBan.CoQuanBanHanh = tbCoQuanBanHanh.Text;
            vanBan.NgayDen = DateTime.Parse(dtpNgayDen.Text);
            vanBan.NgayXuLy = DateTime.Parse(dtpNgayXuLy.Text);
            vanBan.DoMat = VanBanDenData.doMats[cbbDoMat.SelectedIndex];
            vanBan.DoKhan = VanBanDenData.doKhans[cbbDoKhan.SelectedIndex];
            vanBan.LoaiVanBan = VanBanDenData.loaiVanBans[cbbLoaiVanBan.SelectedIndex];
            vanBan.NoiNhan = VanBanDenData.noiNhans[cbbNoiNhan.SelectedIndex];
            vanBan.NgayBanHanh = DateTime.Parse(dtpNgayBanHanh.Text);
            vanBan.NguoiNhan = tbNguoiNhan.Text;
            vanBan.TrichYeuNoiDung = rtbTrichYeu.Text;
            return vanBan;
        }
        #endregion

        #region Events
        private void cbCheckDuLieu_CheckedChanged(object sender, EventArgs e)
        {
            btTuLieuCongVan.Enabled = cbCheckDuLieu.Checked;
        }

        private void fVanBanDen_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void btThemMoi_Click(object sender, EventArgs e)
        {
        }
        #endregion


    }
}
