using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL.Interfaces;
using WebApplication1.Models;

namespace BLL
{
    public class sanphamBusiness : IsanphamBusiness
    {
        private readonly IsanphamRespo _Respo;
        public sanphamBusiness(IsanphamRespo respo)
        {
            _Respo = respo;
        }
        public List<SanPham> Get_ALL_Sanpham()
        {
            return _Respo.Get_ALL_Sanpham();
        }

       

        public SanPham Get_Sanpham_By_ID(int id)
        {
            return _Respo.Get_Sanpham_By_ID(id);
        }

        public List<SanPham> Get_Sanpham_lq(int id)
        {
            return _Respo.Get_Sanpham_lq(id);
        }

        public List<SanPham> Get_Sanpham_New()
        {
            return _Respo.Get_Sanpham_New();
        }

        public List<SanPham> get_san_pham_by_iddm(int id)
        {
            return _Respo.get_san_pham_by_iddm(id);
        }
    }
}
