using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL.Interfaces;
using Model;

namespace BLL
{
    public class sanphamBusiness : IsanphamBusiness
    {
        private readonly IsanphamRespo _Respo;
        public sanphamBusiness(IsanphamRespo respo)
        {
            _Respo = respo;
        }
        public List<SanphamModel> Get_ALL_Sanpham()
        {
            return _Respo.Get_ALL_Sanpham();
        }

        public SanphamModel Get_Sanpham_By_ID()
        {
            throw new NotImplementedException();
        }
    }
}
