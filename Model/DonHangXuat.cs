//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonHangXuat
    {
        public string ID_DHX { get; set; }
        public string NguoiNhan { get; set; }
        public string EmailNguoiNhan { get; set; }
        public string PhoneNguoiNhan { get; set; }
        public string DiaChiNguoiNhan { get; set; }
        public string GhiChuKH { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public string ID_KH { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
    }
}
