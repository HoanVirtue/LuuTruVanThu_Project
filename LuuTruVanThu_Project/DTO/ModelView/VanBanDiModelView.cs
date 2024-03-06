using System;

namespace LuuTruVanThu_Project.DTO.ModelView
{
    internal class VanBanDiModelView
    {
        public string SoDi { get; set; }
        public string SoKyHieu { get; set; }
        public string TrichYeuNoiDung { get; set; }
        public string LoaiVanBan { get; set; }
        public string DonViBanHanh { get; set; }
        public Nullable<System.DateTime> NgayBanHanh { get; set; }
        public string NoiNhan { get; set; }
        public Nullable<System.DateTime> NgayXuLy { get; set; }
        public string TepTuLieu { get; set; }
    }
}
