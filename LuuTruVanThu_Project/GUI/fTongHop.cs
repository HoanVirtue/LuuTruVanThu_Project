using LuuTruVanThu_Project.DAO;
using LuuTruVanThu_Project.DTO.ModelView;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LuuTruVanThu_Project.GUI
{
    public partial class fTongHop : Form
    {
        private int soVanBanDen = 0, soVanBanDi = 0, tong = 0;
        #region Methods
        public fTongHop()
        {
            InitializeComponent();
        }

        private void LoadDSVanBanDi(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            List<TongHopVanBanDiModelView> listVanBan = VanBanDiDAO.Instance.SynthesizeData(ngayBatDau, ngayKetThuc);
            dgvDanhSachDi.DataSource = listVanBan;
            soVanBanDi = listVanBan.Count;
            tong += soVanBanDi;
        }

        private void LoadDSVanBanDen(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            List<TongHopVanBanDenModelView> listVanBan = VanBanDenDAO.Instance.SynthesizeData(ngayBatDau, ngayKetThuc);
            dgvDanhSachDen.DataSource = listVanBan;
            soVanBanDen = listVanBan.Count;
            tong += soVanBanDen;
        }

        private void FilterData()
        {
            tong = 0;
            soVanBanDen = 0;
            soVanBanDi = 0;
            DateTime ngayBatDau = DateTime.Parse(dtpNgayBatDau.Text);
            DateTime ngayKetThuc = DateTime.Parse(dtpNgayKetThuc.Text);
            LoadDSVanBanDi(ngayBatDau, ngayKetThuc);
            LoadDSVanBanDen(ngayBatDau, ngayKetThuc);
            tbSoVanBanDi.Text = soVanBanDi.ToString();
            tbSoVanBanDen.Text = soVanBanDen.ToString();
            tbTong.Text = tong.ToString();
        }
        #endregion

        #region Events
        private void btTimKiem_Click(object sender, EventArgs e)
        {
            FilterData();
        }
        #endregion
    }
}
