using LuuTruVanThu_Project.Constant;
using LuuTruVanThu_Project.Data;
using LuuTruVanThu_Project.DTO;
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
        public List<VanBanDens> GetData()
        {
            return _context.VanBanDens.Where(v => v.MaDonVi == DonViNamData.donVi.MaDonVi).ToList();
        }
        public bool CheckExistSoDen(string soDen)
        {
            return _context.VanBanDens.SingleOrDefault(v => v.SoDen.Equals(soDen)) != null;
        }
        public int AddData(VanBanDens model)
        {
            VanBanDens vanBan = _context.VanBanDens.Find(model.SoDen);
            if (vanBan != null)
            {
                return VanBanDenConstant.EXIST_SODEN;
            }
            else
            {
                try
                {
                    _context.VanBanDens.Add(vanBan);
                    _context.SaveChanges();
                    return VanBanDenConstant.ADD_SUCCESS;
                }
                catch (Exception ex)
                {
                    return VanBanDenConstant.ADD_FAIL;
                }

            }
        }
    }
}
