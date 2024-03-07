using LuuTruVanThu_Project.Constant;
using LuuTruVanThu_Project.DAO;
using LuuTruVanThu_Project.Data;
using LuuTruVanThu_Project.DTO;
using LuuTruVanThu_Project.DTO.ModelView;
using LuuTruVanThu_Project.Message;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace LuuTruVanThu_Project.GUI
{
    public partial class fVanBanDi : Form
    {

        private List<VanBanDiModelView> listVanBan;
        string installedPath = Path.GetFullPath(@"../../TepTuLieuCongVanDi");
        private int position = -1;
        #region Methods
        public fVanBanDi()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            cbbLoaiVanBan.DataSource = VanBanDiData.loaiVanBans;
            cbbDonViBanHanh.DataSource = VanBanDiData.donViBanHanhs;
            btTuLieuCongVan.Enabled = false;
            btnDocTuLieu.Enabled = false;

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
            dgvDanhSach.Columns[5].Width = 150;
            dgvDanhSach.Columns[8].Width = 200;
        }
        private static void ShowMessage(string message, string title = null)
        {
            if (title != null)
                MessageBox.Show(message, title);
            else
                MessageBox.Show(message);
        }

        private void LoadDSVanBanDi()
        {
            dgvDanhSach.DataSource = listVanBan;
        }

        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(tbSoDi.Text) || string.IsNullOrEmpty(tbSoKyHieu.Text))
            {
                ShowMessage(VanBanDiMessage.VALIDATE_DATA, TitleMessage.WARNING_MESSAGE);
                return false;
            }
            return true;
        }

        private VanBanDis GetDataForm()
        {
            VanBanDis vanBan = new VanBanDis();
            vanBan.SoDi = tbSoDi.Text;
            vanBan.SoKyHieu = tbSoKyHieu.Text;
            vanBan.DonViBanHanh = VanBanDiData.donViBanHanhs[cbbDonViBanHanh.SelectedIndex];
            vanBan.NgayXuLy = dtpNgayXuLy.Value;
            vanBan.LoaiVanBan = VanBanDiData.loaiVanBans[cbbLoaiVanBan.SelectedIndex];
            vanBan.NoiNhan = tbNoiNhan.Text;
            vanBan.NgayBanHanh = dtpNgayBanHanh.Value;
            vanBan.TrichYeuNoiDung = rtbTrichYeu.Text;
            if (cbCheckDuLieu.Checked && !string.IsNullOrEmpty(tbTuLieu.Text))
            {
                vanBan.TepTuLieu = SaveFile();
            }
            return vanBan;
        }

        private void SetDataForm(VanBanDiModelView vanBan = null)
        {
            if (vanBan != null)
            {
                tbSoDi.Text = vanBan.SoDi;
                tbSoKyHieu.Text = vanBan.SoKyHieu;
                cbbDonViBanHanh.SelectedItem = vanBan.DonViBanHanh;
                dtpNgayXuLy.Value = vanBan.NgayXuLy.Value;
                cbbLoaiVanBan.SelectedItem = vanBan.LoaiVanBan;
                tbNoiNhan.Text = vanBan.NoiNhan;
                dtpNgayBanHanh.Value = vanBan.NgayBanHanh.Value;
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
                tbSoDi.Text = "";
                tbSoKyHieu.Text = "";
                cbbDonViBanHanh.SelectedIndex = 0;
                cbbLoaiVanBan.SelectedIndex = 0;
                tbNoiNhan.Text = "";
                rtbTrichYeu.Text = "";
                cbCheckDuLieu.Checked = false;
                tbTuLieu.Text = "";
            }
        }

        private void AddData()
        {
            VanBanDis vanBan = GetDataForm();
            if (!ValidateData())
                return;
            int result = VanBanDiDAO.Instance.AddData(vanBan);
            if (result == VanBanDiConstant.EXIST_SODI)
            {
                ShowMessage(VanBanDiMessage.EXIST_SODI, TitleMessage.WARNING_MESSAGE);
            }
            else if (result == VanBanDiConstant.ADD_SUCCESS)
            {
                ShowMessage(VanBanDiMessage.ADD_SUCCESS, TitleMessage.INFO_MESSAGE);
                SetDataForm(null);
                listVanBan = VanBanDiDAO.Instance.GetData();
                LoadDSVanBanDi();
            }
            else
            {
                ShowMessage(VanBanDiMessage.ADD_FAIL, TitleMessage.ERROR_MESSAGE);
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
            VanBanDis vanBan = GetDataForm();
            ValidateData();
            int result = VanBanDiDAO.Instance.EditData(vanBan);
            if (result == VanBanDiConstant.NOT_EXIST_SODI)
            {
                ShowMessage(VanBanDiMessage.NOT_EXIST_SODI, TitleMessage.WARNING_MESSAGE);
            }
            else if (result == VanBanDiConstant.UPDATE_SUCCESS)
            {
                ShowMessage(VanBanDiMessage.UPDATE_SUCCESS, TitleMessage.INFO_MESSAGE);
                listVanBan = VanBanDiDAO.Instance.GetData();
                LoadDSVanBanDi();
            }
            else
            {
                ShowMessage(VanBanDiMessage.UPDATE_FAIL, TitleMessage.ERROR_MESSAGE);
            }
        }
        #endregion

        #region Events
        private void cbCheckDuLieu_CheckedChanged(object sender, System.EventArgs e)
        {
            btTuLieuCongVan.Enabled = cbCheckDuLieu.Checked;
        }

        private void btTuLieuCongVan_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"All Files|*.docx;*.doc;*.pdf*.xls|Word File (.docx ,.doc)|*.docx;*.doc|PDF (.pdf)|*.pdf";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                tbTuLieu.Text = openFileDialog.FileName;
            }
        }

        private void btnDocTuLieu_Click(object sender, System.EventArgs e)
        {
            Process.Start(tbTuLieu.Text);
        }

        private void btThemMoi_Click(object sender, System.EventArgs e)
        {
            AddData();
        }

        private void btLuu_Click(object sender, System.EventArgs e)
        {
            EditData();
        }

        private void btNew_Click(object sender, System.EventArgs e)
        {
            SetDataForm(null);
            btThemMoi.Enabled = true;
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
        private void fVanBanDi_Load(object sender, System.EventArgs e)
        {
            LoadForm();
            listVanBan = VanBanDiDAO.Instance.GetData();
            LoadDSVanBanDi();
        }
        private void tbTuLieu_TextChanged(object sender, System.EventArgs e)
        {
            btnDocTuLieu.Enabled = !string.IsNullOrEmpty(tbTuLieu.Text);
        }
        #endregion
    }
}
