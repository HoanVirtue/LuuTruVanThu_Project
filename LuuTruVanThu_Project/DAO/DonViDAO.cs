using LuuTruVanThu_Project.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuuTruVanThu_Project.DAO
{
    class DonViDAO
    {
        private static VanThuDBEntities _context = new VanThuDBEntities();
        public static List<DonVis> GetData()
        {
            return _context.DonVis.ToList();
        }
        public bool CheckLogin(DonVis model, int Nam)
        {
            //DonVis donVi = _context.DonVis.SingleOrDefault(model => model.)
            return false;
        }
    }
}
