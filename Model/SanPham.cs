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
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.CTDonHangXuats = new HashSet<CTDonHangXuat>();
            this.SanPhamKhoes = new HashSet<SanPhamKho>();
        }
    
        public string ID_SP { get; set; }
        public string Ten_SP { get; set; }
        public string Anh_SP { get; set; }
        public Nullable<int> Gia { get; set; }
        public string GioiThieu { get; set; }
        public string NamSanXuat { get; set; }
        public string XuatXu { get; set; }
        public string NoiSanXuat { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public string ID_NCC { get; set; }
        public string ID_NSX { get; set; }
        public string ID_LSP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTDonHangXuat> CTDonHangXuats { get; set; }
        public virtual LoaiSanPham LoaiSanPham { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual NhaSanXuat NhaSanXuat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SanPhamKho> SanPhamKhoes { get; set; }
    }
}
