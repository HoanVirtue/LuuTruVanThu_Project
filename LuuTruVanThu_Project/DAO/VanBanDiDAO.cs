﻿using LuuTruVanThu_Project.Constant;
using LuuTruVanThu_Project.Data;
using LuuTruVanThu_Project.DTO;
using LuuTruVanThu_Project.DTO.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LuuTruVanThu_Project.DAO
{
    internal class VanBanDiDAO
    {
        private static VanBanDiDAO instance;
        private VanThuDBEntities _context = new VanThuDBEntities();

        internal static VanBanDiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new VanBanDiDAO();
                return instance;
            }
            private set => instance = value;
        }
        private VanBanDiDAO() { }
        public List<VanBanDiModelView> GetData()
        {
            return _context.VanBanDis.Where(v => v.MaDonVi == DonViNamData.donVi.MaDonVi)
                                      .Select(v => new VanBanDiModelView
                                      {
                                          SoDi = v.SoDi,
                                          SoKyHieu = v.SoKyHieu,
                                          TrichYeuNoiDung = v.TrichYeuNoiDung,
                                          LoaiVanBan = v.LoaiVanBan,
                                          DonViBanHanh = v.DonViBanHanh,
                                          NgayBanHanh = v.NgayBanHanh,
                                          NoiNhan = v.NoiNhan,
                                          NgayXuLy = v.NgayXuLy,
                                          TepTuLieu = string.IsNullOrEmpty(v.TepTuLieu) ? "Không có" : v.TepTuLieu,
                                      }).ToList();
        }
        public int AddData(VanBanDis model)
        {
            VanBanDis vanBan = _context.VanBanDis.SingleOrDefault(m => m.SoDi.Equals(model.SoDi) && m.MaDonVi == DonViNamData.donVi.MaDonVi);
            if (vanBan != null)
            {
                return VanBanDiConstant.EXIST_SODI;
            }
            else
            {
                try
                {
                    model.MaDonVi = DonViNamData.donVi.MaDonVi;
                    _context.VanBanDis.Add(model);
                    _context.SaveChanges();
                    return VanBanDiConstant.ADD_SUCCESS;
                }
                catch (Exception ex)
                {
                    return VanBanDiConstant.ADD_FAIL;
                }

            }
        }

        public int EditData(VanBanDis model)
        {
            VanBanDis vanBan = _context.VanBanDis.SingleOrDefault(m => m.SoDi.Equals(model.SoDi) && m.MaDonVi == DonViNamData.donVi.MaDonVi);
            if (vanBan == null)
            {
                return VanBanDiConstant.NOT_EXIST_SODI;
            }
            else
            {
                try
                {
                    vanBan.SoKyHieu = model.SoKyHieu;
                    vanBan.TrichYeuNoiDung = model.TrichYeuNoiDung;
                    vanBan.LoaiVanBan = model.LoaiVanBan;
                    vanBan.DonViBanHanh = model.DonViBanHanh;
                    vanBan.NgayBanHanh = model.NgayBanHanh;
                    vanBan.NoiNhan = model.NoiNhan;
                    vanBan.NgayXuLy = model.NgayXuLy;
                    vanBan.TepTuLieu = model.TepTuLieu;
                    _context.SaveChanges();

                    return VanBanDiConstant.UPDATE_SUCCESS;
                }
                catch (Exception ex)
                {
                    return VanBanDiConstant.UPDATE_FAIL;
                }
            }
        }

        public List<VanBanDiModelView> GetData(string soKyHieu, DateTime ngayBanHanh)
        {
            return _context.VanBanDis.Where(v => v.MaDonVi == DonViNamData.donVi.MaDonVi && v.SoKyHieu.ToLower().Contains(soKyHieu.ToLower()) && v.NgayBanHanh == ngayBanHanh)
                                      .Select(v => new VanBanDiModelView
                                      {
                                          SoDi = v.SoDi,
                                          SoKyHieu = v.SoKyHieu,
                                          TrichYeuNoiDung = v.TrichYeuNoiDung,
                                          LoaiVanBan = v.LoaiVanBan,
                                          DonViBanHanh = v.DonViBanHanh,
                                          NgayBanHanh = v.NgayBanHanh,
                                          NoiNhan = v.NoiNhan,
                                          NgayXuLy = v.NgayXuLy,
                                          TepTuLieu = string.IsNullOrEmpty(v.TepTuLieu) ? "Không có" : v.TepTuLieu,
                                      }).ToList();
        }

        public List<TongHopVanBanDiModelView> SynthesizeData(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            return _context.VanBanDis.Where(v => v.MaDonVi == DonViNamData.donVi.MaDonVi && v.NgayBanHanh >= ngayBatDau && v.NgayBanHanh <= ngayKetThuc)
                                      .Select(v => new TongHopVanBanDiModelView
                                      {
                                          SoDi = v.SoDi,
                                          SoKyHieu = v.SoKyHieu,
                                          TrichYeuNoiDung = v.TrichYeuNoiDung,
                                          NgayBanHanh = v.NgayBanHanh,
                                      }).ToList();
        }
    }
}
