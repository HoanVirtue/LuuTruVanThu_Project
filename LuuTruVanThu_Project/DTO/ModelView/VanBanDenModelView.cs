using System;

namespace LuuTruVanThu_Project.DTO.ModelView
{
    internal class VanBanDenModelView
    {
        public string SoDen { get; set; }
        public string SoKyHieu { get; set; }
        public string TrichYeuNoiDung { get; set; }
        public string LoaiVanBan { get; set; }
        public string CoQuanBanHanh { get; set; }
        public Nullable<System.DateTime> NgayBanHanh { get; set; }
        public Nullable<System.DateTime> NgayDen { get; set; }
        public Nullable<System.DateTime> NgayXuLy { get; set; }
        public string NoiNhan { get; set; }
        public string NguoiNhan { get; set; }
        public string DoMat { get; set; }
        public string DoKhan { get; set; }
        public string TepTuLieu { get; set; }
    }
}
