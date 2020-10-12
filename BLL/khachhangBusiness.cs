using BLL.Interfaces;
using DAL.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class khachhangBusiness : IkhachhangBusiness
    {
        private readonly IkhachhangRespo _Respo;
        public khachhangBusiness(IkhachhangRespo respo)
        {
            _Respo = respo;
        }
        public List<KhachhangModel> Get_ALL_Khachhang()
        {
            return _Respo.Get_ALL_Khachhang();
        }

        public KhachhangModel Get_Khachhang_By_ID()
        {
            throw new NotImplementedException();
        }
    }
}
