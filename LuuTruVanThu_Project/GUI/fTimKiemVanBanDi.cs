using LuuTruVanThu_Project.DAO;
using LuuTruVanThu_Project.Data;
using LuuTruVanThu_Project.DTO;
using LuuTruVanThu_Project.DTO.ModelView;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LuuTruVanThu_Project.GUI
{
    public partial class fTimKiemVanBanDi : Form
    {
        private List<VanBanDiModelView> listVanBan;
        #region Methods
        public fTimKiemVanBanDi()
        {
            InitializeComponent();
            DonViNamData.donVi = new DonVi_Nam()
            {
                Id = 1,
                MaDonVi = 1,
                Nam = 2024
            };
        }

        private void LoadForm()
        {
            dgvDanhSach.ColumnCount = 9;
            dgvDanhSach.Columns[0].HeaderText = "Số đi";
            dgvDanhSach.Columns[1].HeaderText = "Số ký hiệu";
            dgvDanhSach.Columns[2].HeaderText = "Trích yếu nội dung";
            dgvDanhSach.Columns[3].HeaderText = "Loại văn bản";
            dgvDanhSach.Columns[4].HeaderText = "Đơn vị ban hành";
            dgvDanhSach.Columns[5].HeaderText = "Ngày ban hành";
            dgvDanhSach.Columns[6].HeaderText = "Nơi nhận";
            dgvDanhSach.Columns[7].HeaderText = "Ngày xử lý";
            dgvDanhSach.Columns[8].HeaderText = "Tệp dữ liệu đính kèm";

            dgvDanhSach.Columns[0].DataPropertyName = "SoDi";
            dgvDanhSach.Columns[1].DataPropertyName = "SoKyHieu";
            dgvDanhSach.Columns[2].DataPropertyName = "TrichYeuNoiDung";
            dgvDanhSach.Columns[3].DataPropertyName = "LoaiVanBan";
            dgvDanhSach.Columns[4].DataPropertyName = "DonViBanHanh";
            dgvDanhSach.Columns[5].DataPropertyName = "NgayBanHanh";
            dgvDanhSach.Columns[6].DataPropertyName = "NoiNhan";
            dgvDanhSach.Columns[7].DataPropertyName = "NgayXuLy";
            dgvDanhSach.Columns[8].DataPropertyName = "TepTuLieu";

            dgvDanhSach.Columns[2].Width = 200;
            dgvDanhSach.Columns[4].Width = 150;
            dgvDanhSach.Columns[8].Width = 200;
        }

        private void LoadDSVanBan()
        {
            dgvDanhSach.DataSource = listVanBan;
        }

        private void SearchVanBanDen()
        {
            string soKyHieu = txbSoKyHieu.Text;
            DateTime ngayBanHanh = DateTime.Parse(dtpNgayBanHanh.Text);
            listVanBan = VanBanDiDAO.Instance.GetData(soKyHieu, ngayBanHanh);
            LoadDSVanBan();
        }
        #endregion

        #region Events
        private void fTimKiemVanBanDi_Load(object sender, EventArgs e)
        {
            LoadForm();
            listVanBan = VanBanDiDAO.Instance.GetData();
            LoadDSVanBan();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchVanBanDen();
        }
        #endregion

    }
}
