using LuuTruVanThu_Project.Constant;
using LuuTruVanThu_Project.DAO;
using LuuTruVanThu_Project.Data;
using LuuTruVanThu_Project.DTO;
using LuuTruVanThu_Project.DTO.ModelView;
using LuuTruVanThu_Project.Message;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LuuTruVanThu_Project.GUI
{
    public partial class fVanBanDen : Form
    {
        private List<VanBanDenModelView> listVanBan;
        string installedPath = Path.GetFullPath(@"../../TepTuLieuCongVan");
        private int position = -1;
        #region Methods
        public fVanBanDen()
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
            cbbDoMat.DataSource = VanBanDenData.doMats;
            cbbDoKhan.DataSource = VanBanDenData.doKhans;
            cbbLoaiVanBan.DataSource = VanBanDenData.loaiVanBans;
            cbbNoiNhan.DataSource = VanBanDenData.noiNhans;
            btTuLieuCongVan.Enabled = false;
            btnDocTuLieu.Enabled = false;

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
        private static void ShowMessage(string message, string title = null)
        {
            if (title != null)
                MessageBox.Show(message, title);
            else
                MessageBox.Show(message);
        }

        private void LoadDSVanBanDen()
        {
            dgvDanhSach.DataSource = listVanBan;
        }

        private void ValidateData()
        {
            if (string.IsNullOrEmpty(tbSoDen.Text) || string.IsNullOrEmpty(tbKyHieu.Text)
                || string.IsNullOrEmpty(tbCoQuanBanHanh.Text))
            {
                ShowMessage(VanBanDenMessage.VALIDATE_DATA, TitleMessage.WARNING_MESSAGE);
                return;
            }
        }

        private VanBanDens GetDataForm()
        {
            VanBanDens vanBan = new VanBanDens();
            vanBan.SoDen = tbSoDen.Text;
            vanBan.SoKyHieu = tbKyHieu.Text;
            vanBan.CoQuanBanHanh = tbCoQuanBanHanh.Text;
            vanBan.NgayDen = dtpNgayDen.Value;
            vanBan.NgayXuLy = dtpNgayXuLy.Value;
            vanBan.DoMat = VanBanDenData.doMats[cbbDoMat.SelectedIndex];
            vanBan.DoKhan = VanBanDenData.doKhans[cbbDoKhan.SelectedIndex];
            vanBan.LoaiVanBan = VanBanDenData.loaiVanBans[cbbLoaiVanBan.SelectedIndex];
            vanBan.NoiNhan = VanBanDenData.noiNhans[cbbNoiNhan.SelectedIndex];
            vanBan.NgayBanHanh = dtpNgayBanHanh.Value;
            vanBan.NguoiNhan = tbNguoiNhan.Text;
            vanBan.TrichYeuNoiDung = rtbTrichYeu.Text;
            if (cbCheckDuLieu.Checked && !string.IsNullOrEmpty(tbTuLieu.Text))
            {
                vanBan.TepTuLieu = SaveFile();
            }
            return vanBan;
        }

        private void SetDataForm(VanBanDenModelView vanBan = null)
        {
            if (vanBan != null)
            {
                tbSoDen.Text = vanBan.SoDen;
                tbKyHieu.Text = vanBan.SoKyHieu;
                tbCoQuanBanHanh.Text = vanBan.CoQuanBanHanh;
                dtpNgayDen.Value = vanBan.NgayDen.Value;
                dtpNgayXuLy.Value = vanBan.NgayXuLy.Value;
                cbbDoMat.SelectedItem = vanBan.DoMat;
                cbbDoKhan.SelectedItem = vanBan.DoKhan;
                cbbLoaiVanBan.SelectedItem = vanBan.LoaiVanBan;
                cbbNoiNhan.SelectedItem = vanBan.NoiNhan;
                dtpNgayBanHanh.Value = vanBan.NgayBanHanh.Value;
                tbNguoiNhan.Text = vanBan.NguoiNhan;
                rtbTrichYeu.Text = vanBan.TrichYeuNoiDung;
                if (!string.IsNullOrEmpty(vanBan.TepTuLieu) && !vanBan.TepTuLieu.Equals("Không có"))
                {
                    cbCheckDuLieu.Checked = true;
                    tbTuLieu.Text = Path.Combine(installedPath, vanBan.TepTuLieu);
                }
                else
                {
                    cbCheckDuLieu.Checked = false;
                    tbTuLieu.Text = "";
                }
            }
            else
            {
                tbSoDen.Text = "";
                tbKyHieu.Text = "";
                tbCoQuanBanHanh.Text = "";
                cbbDoMat.SelectedIndex = 0;
                cbbDoKhan.SelectedIndex = 0;
                cbbLoaiVanBan.SelectedIndex = 0;
                cbbNoiNhan.SelectedIndex = 0;
                tbNguoiNhan.Text = "";
                rtbTrichYeu.Text = "";
                cbCheckDuLieu.Checked = false;
                tbTuLieu.Text = "";

            }
        }

        private void AddData()
        {
            VanBanDens vanBan = GetDataForm();
            ValidateData();
            int result = VanBanDenDAO.Instance.AddData(vanBan);
            if (result == VanBanDenConstant.EXIST_SODEN)
            {
                ShowMessage(VanBanDenMessage.EXIST_SODEN, TitleMessage.WARNING_MESSAGE);
            }
            else if (result == VanBanDenConstant.ADD_SUCCESS)
            {
                ShowMessage(VanBanDenMessage.ADD_SUCCESS, TitleMessage.INFO_MESSAGE);
                SetDataForm(null);
                listVanBan = VanBanDenDAO.Instance.GetData();
                LoadDSVanBanDen();
            }
            else
            {
                ShowMessage(VanBanDenMessage.ADD_FAIL, TitleMessage.ERROR_MESSAGE);
            }
        }

        private string SaveFile()
        {

            if (!Directory.Exists(installedPath))
            {
                Directory.CreateDirectory(installedPath);
            }

            string filePathName = tbTuLieu.Text;
            string fileName = Path.GetFileName(filePathName);
            string destinationFileName = Path.Combine(installedPath, fileName);
            string fileNameNotExtension = Path.GetFileNameWithoutExtension(destinationFileName);
            string extensionFile = Path.GetExtension(destinationFileName);
            string fileNameNew = fileNameNotExtension;
            if (File.Exists(destinationFileName))
            {
                int index = 1;
                string[] files = Directory.GetFiles(installedPath);
                foreach (string file in files)
                {
                    string fileInFolder = Path.GetFileNameWithoutExtension(file);
                    fileNameNew = fileNameNotExtension + "_" + index;
                    if (file.Equals(fileNameNew))
                    {
                        index++;
                    }
                }
            }
            destinationFileName = Path.Combine(installedPath, fileNameNew + extensionFile);
            File.Copy(filePathName, destinationFileName);
            return fileNameNew + extensionFile;
        }
        private void EditData()
        {
            VanBanDens vanBan = GetDataForm();
            ValidateData();
            int result = VanBanDenDAO.Instance.EditData(vanBan);
            if (result == VanBanDenConstant.NOT_EXIST_SODEN)
            {
                ShowMessage(VanBanDenMessage.NOT_EXIST_SODEN, TitleMessage.WARNING_MESSAGE);
            }
            else if (result == VanBanDenConstant.UPDATE_SUCCESS)
            {
                ShowMessage(VanBanDenMessage.UPDATE_SUCCESS, TitleMessage.INFO_MESSAGE);
                listVanBan = VanBanDenDAO.Instance.GetData();
                LoadDSVanBanDen();
            }
            else
            {
                ShowMessage(VanBanDenMessage.UPDATE_FAIL, TitleMessage.ERROR_MESSAGE);
            }
        }
        #endregion

        #region Events
        private void cbCheckDuLieu_CheckedChanged(object sender, EventArgs e)
        {
            btTuLieuCongVan.Enabled = cbCheckDuLieu.Checked;
        }

        private void fVanBanDen_Load(object sender, EventArgs e)
        {
            listVanBan = VanBanDenDAO.Instance.GetData();
            LoadForm();
            LoadDSVanBanDen();
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            btThemMoi.Enabled = true;
            AddData();
        }

        private void btTuLieuCongVan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"All Files|*.docx;*.doc;*.pdf*.xls|Word File (.docx ,.doc)|*.docx;*.doc|PDF (.pdf)|*.pdf";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                tbTuLieu.Text = openFileDialog.FileName;
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position < 0)
            {
                return;
            }
            SetDataForm(listVanBan[position]);
            btThemMoi.Enabled = false;
        }
        private void btnDocTuLieu_Click(object sender, EventArgs e)
        {
            Process.Start(tbTuLieu.Text);

        }
        private void tbTuLieu_TextChanged(object sender, EventArgs e)
        {
            btnDocTuLieu.Enabled = !string.IsNullOrEmpty(tbTuLieu.Text);
        }
        private void btNew_Click(object sender, EventArgs e)
        {
            SetDataForm(null);
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            EditData();
        }
        #endregion


    }
}
