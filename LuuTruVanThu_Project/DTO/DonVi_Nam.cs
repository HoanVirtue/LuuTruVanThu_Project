//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LuuTruVanThu_Project.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonVi_Nam
    {
        public int Id { get; set; }
        public int MaDonVi { get; set; }
        public Nullable<int> Nam { get; set; }
    
        public virtual DonVis DonVis { get; set; }
        public virtual Nams Nams { get; set; }
    }
}
