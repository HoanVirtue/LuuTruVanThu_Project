using LuuTruVanThu_Project.Constant;
using LuuTruVanThu_Project.Data;
using LuuTruVanThu_Project.DTO;
using LuuTruVanThu_Project.DTO.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LuuTruVanThu_Project.DAO
{
    internal class VanBanDenDAO
    {
        private static VanBanDenDAO instance;
        private VanThuDBEntities _context = new VanThuDBEntities();

        internal static VanBanDenDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new VanBanDenDAO();
                return instance;
            }
            private set => instance = value;
        }
        private VanBanDenDAO() { }
        public List<VanBanDenModelView> GetData()
        {
            return _context.VanBanDens.Where(v => v.MaDonVi == DonViNamData.donVi.MaDonVi)
                                      .Select(v => new VanBanDenModelView
                                      {
                                          SoDen = v.SoDen,
                                          SoKyHieu = v.SoKyHieu,
                                          TrichYeuNoiDung = v.TrichYeuNoiDung,
                                          LoaiVanBan = v.LoaiVanBan,
                                          CoQuanBanHanh = v.CoQuanBanHanh,
                                          NgayBanHanh = v.NgayBanHanh,
                                          NgayDen = v.NgayDen,
                                          NgayXuLy = v.NgayXuLy,
                                          NoiNhan = v.NoiNhan,
                                          NguoiNhan = v.NguoiNhan,
                                          DoMat = v.DoMat,
                                          DoKhan = v.DoKhan,
                                          TepTuLieu = string.IsNullOrEmpty(v.TepTuLieu) ? "Không có" : v.TepTuLieu,
                                      }).ToList();
        }
        public int AddData(VanBanDens model)
        {
            VanBanDens vanBan = _context.VanBanDens.SingleOrDefault(m => m.SoDen.Equals(model.SoDen) && m.MaDonVi == DonViNamData.donVi.MaDonVi);
            if (vanBan != null)
            {
                return VanBanDenConstant.EXIST_SODEN;
            }
            else
            {
                try
                {
                    model.MaDonVi = DonViNamData.donVi.MaDonVi;
                    _context.VanBanDens.Add(model);
                    _context.SaveChanges();
                    return VanBanDenConstant.ADD_SUCCESS;
                }
                catch (Exception ex)
                {
                    return VanBanDenConstant.ADD_FAIL;
                }

            }
        }

        public int EditData(VanBanDens model)
        {
            VanBanDens vanBan = _context.VanBanDens.SingleOrDefault(m => m.SoDen.Equals(model.SoDen) && m.MaDonVi == DonViNamData.donVi.MaDonVi);
            if (vanBan == null)
            {
                return VanBanDenConstant.NOT_EXIST_SODEN;
            }
            else
            {
                try
                {
                    vanBan.SoKyHieu = model.SoKyHieu;
                    vanBan.TrichYeuNoiDung = model.TrichYeuNoiDung;
                    vanBan.LoaiVanBan = model.LoaiVanBan;
                    vanBan.CoQuanBanHanh = model.CoQuanBanHanh;
                    vanBan.NgayBanHanh = model.NgayBanHanh;
                    vanBan.NgayDen = model.NgayDen;
                    vanBan.NgayXuLy = model.NgayXuLy;
                    vanBan.NoiNhan = model.NoiNhan;
                    vanBan.NguoiNhan = model.NguoiNhan;
                    vanBan.DoMat = model.DoMat;
                    vanBan.DoKhan = model.DoKhan;
                    vanBan.TepTuLieu = model.TepTuLieu;
                    _context.SaveChanges();

                    return VanBanDenConstant.UPDATE_SUCCESS;
                }
                catch (Exception ex)
                {
                    return VanBanDenConstant.UPDATE_FAIL;
                }
            }
        }
    }
}
