
namespace LuuTruVanThu_Project.GUI
{
    partial class fVanBanDi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fVanBanDi));
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.btNew = new System.Windows.Forms.Button();
            this.btnDocTuLieu = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btThemMoi = new System.Windows.Forms.Button();
            this.lbSoDi = new System.Windows.Forms.Label();
            this.lbKyHieu = new System.Windows.Forms.Label();
            this.lbTrichYeu = new System.Windows.Forms.Label();
            this.lbNgayBanHanh = new System.Windows.Forms.Label();
            this.lbNgayXuLy = new System.Windows.Forms.Label();
            this.lbCoQuanBanHanh = new System.Windows.Forms.Label();
            this.lbLoaiVanBan = new System.Windows.Forms.Label();
            this.lbNoiNhan = new System.Windows.Forms.Label();
            this.cbbLoaiVanBan = new System.Windows.Forms.ComboBox();
            this.cbbDonViBanHanh = new System.Windows.Forms.ComboBox();
            this.dtpNgayBanHanh = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayXuLy = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSoDi = new System.Windows.Forms.TextBox();
            this.tbSoKyHieu = new System.Windows.Forms.TextBox();
            this.rtbTrichYeu = new System.Windows.Forms.RichTextBox();
            this.cbCheckDuLieu = new System.Windows.Forms.CheckBox();
            this.btTuLieuCongVan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.tbTuLieu = new System.Windows.Forms.TextBox();
            this.tbNoiNhan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.gbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(12, 584);
            this.dgvDanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.RowHeadersWidth = 62;
            this.dgvDanhSach.RowTemplate.Height = 28;
            this.dgvDanhSach.Size = new System.Drawing.Size(1884, 285);
            this.dgvDanhSach.TabIndex = 7;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            // 
            // gbChucNang
            // 
            this.gbChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChucNang.Controls.Add(this.btNew);
            this.gbChucNang.Controls.Add(this.btnDocTuLieu);
            this.gbChucNang.Controls.Add(this.btLuu);
            this.gbChucNang.Controls.Add(this.btThemMoi);
            this.gbChucNang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChucNang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbChucNang.Location = new System.Drawing.Point(14, 451);
            this.gbChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChucNang.Size = new System.Drawing.Size(1884, 118);
            this.gbChucNang.TabIndex = 6;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức năng";
            // 
            // btNew
            // 
            this.btNew.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.Location = new System.Drawing.Point(1595, 41);
            this.btNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(251, 65);
            this.btNew.TabIndex = 11;
            this.btNew.Text = "Làm mới";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btnDocTuLieu
            // 
            this.btnDocTuLieu.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocTuLieu.Location = new System.Drawing.Point(55, 43);
            this.btnDocTuLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDocTuLieu.Name = "btnDocTuLieu";
            this.btnDocTuLieu.Size = new System.Drawing.Size(278, 60);
            this.btnDocTuLieu.TabIndex = 10;
            this.btnDocTuLieu.Text = "Đọc tư liệu";
            this.btnDocTuLieu.UseVisualStyleBackColor = true;
            this.btnDocTuLieu.Click += new System.EventHandler(this.btnDocTuLieu_Click);
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.Location = new System.Drawing.Point(1228, 38);
            this.btLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(254, 65);
            this.btLuu.TabIndex = 8;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btThemMoi
            // 
            this.btThemMoi.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemMoi.Location = new System.Drawing.Point(860, 38);
            this.btThemMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThemMoi.Name = "btThemMoi";
            this.btThemMoi.Size = new System.Drawing.Size(251, 65);
            this.btThemMoi.TabIndex = 6;
            this.btThemMoi.Text = "Thêm mới";
            this.btThemMoi.UseVisualStyleBackColor = true;
            this.btThemMoi.Click += new System.EventHandler(this.btThemMoi_Click);
            // 
            // lbSoDi
            // 
            this.lbSoDi.AutoSize = true;
            this.lbSoDi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbSoDi.Location = new System.Drawing.Point(21, 54);
            this.lbSoDi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSoDi.Name = "lbSoDi";
            this.lbSoDi.Size = new System.Drawing.Size(66, 27);
            this.lbSoDi.TabIndex = 31;
            this.lbSoDi.Text = "Số đi";
            // 
            // lbKyHieu
            // 
            this.lbKyHieu.AutoSize = true;
            this.lbKyHieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKyHieu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbKyHieu.Location = new System.Drawing.Point(22, 101);
            this.lbKyHieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKyHieu.Name = "lbKyHieu";
            this.lbKyHieu.Size = new System.Drawing.Size(93, 27);
            this.lbKyHieu.TabIndex = 32;
            this.lbKyHieu.Text = "Ký hiệu";
            // 
            // lbTrichYeu
            // 
            this.lbTrichYeu.AutoSize = true;
            this.lbTrichYeu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrichYeu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTrichYeu.Location = new System.Drawing.Point(730, 151);
            this.lbTrichYeu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTrichYeu.Name = "lbTrichYeu";
            this.lbTrichYeu.Size = new System.Drawing.Size(111, 27);
            this.lbTrichYeu.TabIndex = 33;
            this.lbTrichYeu.Text = "Trích yếu";
            // 
            // lbNgayBanHanh
            // 
            this.lbNgayBanHanh.AutoSize = true;
            this.lbNgayBanHanh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayBanHanh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbNgayBanHanh.Location = new System.Drawing.Point(24, 205);
            this.lbNgayBanHanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayBanHanh.Name = "lbNgayBanHanh";
            this.lbNgayBanHanh.Size = new System.Drawing.Size(178, 27);
            this.lbNgayBanHanh.TabIndex = 34;
            this.lbNgayBanHanh.Text = "Ngày ban hành";
            // 
            // lbNgayXuLy
            // 
            this.lbNgayXuLy.AutoSize = true;
            this.lbNgayXuLy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayXuLy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbNgayXuLy.Location = new System.Drawing.Point(20, 156);
            this.lbNgayXuLy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayXuLy.Name = "lbNgayXuLy";
            this.lbNgayXuLy.Size = new System.Drawing.Size(127, 27);
            this.lbNgayXuLy.TabIndex = 36;
            this.lbNgayXuLy.Text = "Ngày xử lý";
            // 
            // lbCoQuanBanHanh
            // 
            this.lbCoQuanBanHanh.AutoSize = true;
            this.lbCoQuanBanHanh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoQuanBanHanh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbCoQuanBanHanh.Location = new System.Drawing.Point(650, 49);
            this.lbCoQuanBanHanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCoQuanBanHanh.Name = "lbCoQuanBanHanh";
            this.lbCoQuanBanHanh.Size = new System.Drawing.Size(192, 27);
            this.lbCoQuanBanHanh.TabIndex = 38;
            this.lbCoQuanBanHanh.Text = "Đơn vị ban hành";
            // 
            // lbLoaiVanBan
            // 
            this.lbLoaiVanBan.AutoSize = true;
            this.lbLoaiVanBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiVanBan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbLoaiVanBan.Location = new System.Drawing.Point(673, 98);
            this.lbLoaiVanBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLoaiVanBan.Name = "lbLoaiVanBan";
            this.lbLoaiVanBan.Size = new System.Drawing.Size(149, 27);
            this.lbLoaiVanBan.TabIndex = 39;
            this.lbLoaiVanBan.Text = "Loại văn bản";
            // 
            // lbNoiNhan
            // 
            this.lbNoiNhan.AutoSize = true;
            this.lbNoiNhan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoiNhan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbNoiNhan.Location = new System.Drawing.Point(1357, 44);
            this.lbNoiNhan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNoiNhan.Name = "lbNoiNhan";
            this.lbNoiNhan.Size = new System.Drawing.Size(112, 27);
            this.lbNoiNhan.TabIndex = 42;
            this.lbNoiNhan.Text = "Nơi nhận";
            // 
            // cbbLoaiVanBan
            // 
            this.cbbLoaiVanBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoaiVanBan.FormattingEnabled = true;
            this.cbbLoaiVanBan.Items.AddRange(new object[] {
            "Đơn",
            "Gửi đích danh",
            "Loại khác"});
            this.cbbLoaiVanBan.Location = new System.Drawing.Point(896, 95);
            this.cbbLoaiVanBan.Margin = new System.Windows.Forms.Padding(4);
            this.cbbLoaiVanBan.Name = "cbbLoaiVanBan";
            this.cbbLoaiVanBan.Size = new System.Drawing.Size(343, 35);
            this.cbbLoaiVanBan.TabIndex = 43;
            // 
            // cbbDonViBanHanh
            // 
            this.cbbDonViBanHanh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDonViBanHanh.FormattingEnabled = true;
            this.cbbDonViBanHanh.Items.AddRange(new object[] {
            "Hỏa tốc",
            "Thượng khẩn",
            "Khẩn",
            "Có tư liệu khác"});
            this.cbbDonViBanHanh.Location = new System.Drawing.Point(896, 46);
            this.cbbDonViBanHanh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDonViBanHanh.Name = "cbbDonViBanHanh";
            this.cbbDonViBanHanh.Size = new System.Drawing.Size(343, 35);
            this.cbbDonViBanHanh.TabIndex = 44;
            // 
            // dtpNgayBanHanh
            // 
            this.dtpNgayBanHanh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBanHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBanHanh.Location = new System.Drawing.Point(279, 199);
            this.dtpNgayBanHanh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayBanHanh.Name = "dtpNgayBanHanh";
            this.dtpNgayBanHanh.Size = new System.Drawing.Size(340, 35);
            this.dtpNgayBanHanh.TabIndex = 47;
            // 
            // dtpNgayXuLy
            // 
            this.dtpNgayXuLy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuLy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuLy.Location = new System.Drawing.Point(279, 145);
            this.dtpNgayXuLy.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayXuLy.Name = "dtpNgayXuLy";
            this.dtpNgayXuLy.Size = new System.Drawing.Size(340, 35);
            this.dtpNgayXuLy.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(95, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 27);
            this.label13.TabIndex = 50;
            this.label13.Text = "(*)";
            // 
            // tbSoDi
            // 
            this.tbSoDi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoDi.Location = new System.Drawing.Point(279, 49);
            this.tbSoDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoDi.Name = "tbSoDi";
            this.tbSoDi.Size = new System.Drawing.Size(340, 35);
            this.tbSoDi.TabIndex = 54;
            // 
            // tbSoKyHieu
            // 
            this.tbSoKyHieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoKyHieu.Location = new System.Drawing.Point(279, 95);
            this.tbSoKyHieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoKyHieu.Name = "tbSoKyHieu";
            this.tbSoKyHieu.Size = new System.Drawing.Size(340, 35);
            this.tbSoKyHieu.TabIndex = 55;
            // 
            // rtbTrichYeu
            // 
            this.rtbTrichYeu.Location = new System.Drawing.Point(896, 151);
            this.rtbTrichYeu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbTrichYeu.Name = "rtbTrichYeu";
            this.rtbTrichYeu.Size = new System.Drawing.Size(952, 172);
            this.rtbTrichYeu.TabIndex = 57;
            this.rtbTrichYeu.Text = "";
            // 
            // cbCheckDuLieu
            // 
            this.cbCheckDuLieu.AutoSize = true;
            this.cbCheckDuLieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheckDuLieu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbCheckDuLieu.Location = new System.Drawing.Point(31, 265);
            this.cbCheckDuLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCheckDuLieu.Name = "cbCheckDuLieu";
            this.cbCheckDuLieu.Size = new System.Drawing.Size(314, 31);
            this.cbCheckDuLieu.TabIndex = 59;
            this.cbCheckDuLieu.Text = "Có dữ liệu đính kèm khác";
            this.cbCheckDuLieu.UseVisualStyleBackColor = true;
            this.cbCheckDuLieu.CheckedChanged += new System.EventHandler(this.cbCheckDuLieu_CheckedChanged);
            // 
            // btTuLieuCongVan
            // 
            this.btTuLieuCongVan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTuLieuCongVan.Location = new System.Drawing.Point(75, 307);
            this.btTuLieuCongVan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTuLieuCongVan.Name = "btTuLieuCongVan";
            this.btTuLieuCongVan.Size = new System.Drawing.Size(212, 48);
            this.btTuLieuCongVan.TabIndex = 60;
            this.btTuLieuCongVan.Text = "Tư liệu công văn";
            this.btTuLieuCongVan.UseVisualStyleBackColor = true;
            this.btTuLieuCongVan.Click += new System.EventHandler(this.btTuLieuCongVan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 307);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(110, 102);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 27);
            this.label14.TabIndex = 66;
            this.label14.Text = "(*)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(838, 49);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 27);
            this.label15.TabIndex = 67;
            this.label15.Text = "(*)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(820, 98);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 27);
            this.label16.TabIndex = 68;
            this.label16.Text = "(*)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(198, 205);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 27);
            this.label17.TabIndex = 69;
            this.label17.Text = "(*)";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThongTin.Controls.Add(this.tbTuLieu);
            this.gbThongTin.Controls.Add(this.tbNoiNhan);
            this.gbThongTin.Controls.Add(this.label17);
            this.gbThongTin.Controls.Add(this.label16);
            this.gbThongTin.Controls.Add(this.label15);
            this.gbThongTin.Controls.Add(this.label14);
            this.gbThongTin.Controls.Add(this.pictureBox1);
            this.gbThongTin.Controls.Add(this.btTuLieuCongVan);
            this.gbThongTin.Controls.Add(this.cbCheckDuLieu);
            this.gbThongTin.Controls.Add(this.rtbTrichYeu);
            this.gbThongTin.Controls.Add(this.tbSoKyHieu);
            this.gbThongTin.Controls.Add(this.tbSoDi);
            this.gbThongTin.Controls.Add(this.label13);
            this.gbThongTin.Controls.Add(this.dtpNgayXuLy);
            this.gbThongTin.Controls.Add(this.dtpNgayBanHanh);
            this.gbThongTin.Controls.Add(this.cbbDonViBanHanh);
            this.gbThongTin.Controls.Add(this.cbbLoaiVanBan);
            this.gbThongTin.Controls.Add(this.lbNoiNhan);
            this.gbThongTin.Controls.Add(this.lbLoaiVanBan);
            this.gbThongTin.Controls.Add(this.lbCoQuanBanHanh);
            this.gbThongTin.Controls.Add(this.lbNgayXuLy);
            this.gbThongTin.Controls.Add(this.lbNgayBanHanh);
            this.gbThongTin.Controls.Add(this.lbTrichYeu);
            this.gbThongTin.Controls.Add(this.lbKyHieu);
            this.gbThongTin.Controls.Add(this.lbSoDi);
            this.gbThongTin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbThongTin.Location = new System.Drawing.Point(12, 12);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTin.Size = new System.Drawing.Size(1886, 421);
            this.gbThongTin.TabIndex = 5;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin văn bản";
            // 
            // tbTuLieu
            // 
            this.tbTuLieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTuLieu.Location = new System.Drawing.Point(380, 312);
            this.tbTuLieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTuLieu.Name = "tbTuLieu";
            this.tbTuLieu.Size = new System.Drawing.Size(163, 35);
            this.tbTuLieu.TabIndex = 73;
            this.tbTuLieu.Visible = false;
            this.tbTuLieu.TextChanged += new System.EventHandler(this.tbTuLieu_TextChanged);
            // 
            // tbNoiNhan
            // 
            this.tbNoiNhan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoiNhan.Location = new System.Drawing.Point(1508, 41);
            this.tbNoiNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoiNhan.Name = "tbNoiNhan";
            this.tbNoiNhan.Size = new System.Drawing.Size(340, 35);
            this.tbNoiNhan.TabIndex = 70;
            // 
            // fVanBanDi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 881);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.gbThongTin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fVanBanDi";
            this.Text = "Văn Bản Đi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fVanBanDi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.gbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btThemMoi;
        private System.Windows.Forms.Label lbSoDi;
        private System.Windows.Forms.Label lbKyHieu;
        private System.Windows.Forms.Label lbTrichYeu;
        private System.Windows.Forms.Label lbNgayBanHanh;
        private System.Windows.Forms.Label lbNgayXuLy;
        private System.Windows.Forms.Label lbCoQuanBanHanh;
        private System.Windows.Forms.Label lbLoaiVanBan;
        private System.Windows.Forms.Label lbNoiNhan;
        private System.Windows.Forms.ComboBox cbbLoaiVanBan;
        private System.Windows.Forms.ComboBox cbbDonViBanHanh;
        private System.Windows.Forms.DateTimePicker dtpNgayBanHanh;
        private System.Windows.Forms.DateTimePicker dtpNgayXuLy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSoDi;
        private System.Windows.Forms.TextBox tbSoKyHieu;
        private System.Windows.Forms.RichTextBox rtbTrichYeu;
        private System.Windows.Forms.CheckBox cbCheckDuLieu;
        private System.Windows.Forms.Button btTuLieuCongVan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Button btnDocTuLieu;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.TextBox tbNoiNhan;
        private System.Windows.Forms.TextBox tbTuLieu;
    }
}