using System;
using System.Collections.Generic;
using System.Text;

using WebApplication1.Models;

namespace DAL.Interfaces
{
    public interface IsanphamRespo
    {
        List<SanPham> Get_ALL_Sanpham();
        SanPham Get_Sanpham_By_ID(int id);
        List<SanPham> Get_Sanpham_New();
        List<SanPham> Get_Sanpham_lq(int id);
        List<SanPham> get_san_pham_by_iddm(int id);
    }
}
