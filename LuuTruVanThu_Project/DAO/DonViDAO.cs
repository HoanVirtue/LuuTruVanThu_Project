using LuuTruVanThu_Project.Data;
using LuuTruVanThu_Project.DTO;
using System.Collections.Generic;
using System.Linq;

namespace LuuTruVanThu_Project.DAO
{
    class DonViDAO
    {
        private static DonViDAO instance;
        private VanThuDBEntities _context = new VanThuDBEntities();

        internal static DonViDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonViDAO();
                return instance;
            }
            private set => instance = value;
        }
        private DonViDAO() { }

        public List<DonVis> GetData()
        {
            return _context.DonVis.ToList();
        }
        public bool CheckLogin(DonVis model, int nam)
        {
            DonVi_Nam donVi = _context.DonVi_Nam.SingleOrDefault(m => m.MaDonVi == model.MaDonVi && m.Nam == nam);
            if (donVi != null)
            {
                DonViNamData.donVi = donVi;
                return true;
            }
            return false;
        }
        public DonVis GetDataById(int donVi)
        {
            return _context.DonVis.Find(donVi);
        }
    }
}
