using LuuTruVanThu_Project.DAO;
using LuuTruVanThu_Project.Data;
using LuuTruVanThu_Project.DTO;
using LuuTruVanThu_Project.DTO.ModelView;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LuuTruVanThu_Project.GUI
{
    public partial class fTimKiemVanBanDen : Form
    {
        private List<VanBanDenModelView> listVanBan;
        #region Methods
        public fTimKiemVanBanDen()
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
            dgvDanhSach.ColumnCount = 13;
            dgvDanhSach.Columns[0].HeaderText = "Số đến";
            dgvDanhSach.Columns[1].HeaderText = "Số ký hiệu";
            dgvDanhSach.Columns[2].HeaderText = "Trích yếu nội dung";
            dgvDanhSach.Columns[3].HeaderText = "Loại văn bản";
            dgvDanhSach.Columns[4].HeaderText = "Cơ quan ban hành";
            dgvDanhSach.Columns[5].HeaderText = "Ngày ban hành";
            dgvDanhSach.Columns[6].HeaderText = "Ngày đến";
            dgvDanhSach.Columns[7].HeaderText = "Ngày xử lý";
            dgvDanhSach.Columns[8].HeaderText = "Nơi nhận";
            dgvDanhSach.Columns[9].HeaderText = "Người nhận";
            dgvDanhSach.Columns[10].HeaderText = "Độ mật";
            dgvDanhSach.Columns[11].HeaderText = "Độ khẩn";
            dgvDanhSach.Columns[12].HeaderText = "Tệp dữ liệu đính kèm";

            dgvDanhSach.Columns[0].DataPropertyName = "SoDen";
            dgvDanhSach.Columns[1].DataPropertyName = "SoKyHieu";
            dgvDanhSach.Columns[2].DataPropertyName = "TrichYeuNoiDung";
            dgvDanhSach.Columns[3].DataPropertyName = "LoaiVanBan";
            dgvDanhSach.Columns[4].DataPropertyName = "CoQuanBanHanh";
            dgvDanhSach.Columns[5].DataPropertyName = "NgayBanHanh";
            dgvDanhSach.Columns[6].DataPropertyName = "NgayDen";
            dgvDanhSach.Columns[7].DataPropertyName = "NgayXuLy";
            dgvDanhSach.Columns[8].DataPropertyName = "NoiNhan";
            dgvDanhSach.Columns[9].DataPropertyName = "NguoiNhan";
            dgvDanhSach.Columns[10].DataPropertyName = "DoMat";
            dgvDanhSach.Columns[11].DataPropertyName = "DoKhan";
            dgvDanhSach.Columns[12].DataPropertyName = "TepTuLieu";
        }

        private void LoadDSVanBan()
        {
            dgvDanhSach.DataSource = listVanBan;
        }

        private void SearchVanBanDen()
        {
            string soKyHieu = txbSoKyHieu.Text;
            DateTime ngayBanHanh = DateTime.Parse(dtpNgayBanHanh.Text);
            listVanBan = VanBanDenDAO.Instance.GetData(soKyHieu, ngayBanHanh);
            LoadDSVanBan();
        }
        #endregion

        #region Events
        private void fTimKiemVanBanDen_Load(object sender, EventArgs e)
        {
            LoadForm();
            listVanBan = VanBanDenDAO.Instance.GetData();
            LoadDSVanBan();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SearchVanBanDen();
        }


        #endregion


    }
}
