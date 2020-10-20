using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL.Interfaces;
using Model;
namespace BLL
{
    public class danhmucBusiness : IdanhmucBusiness
    {
        private readonly IdanhmucRespo _Respo;
        public danhmucBusiness(IdanhmucRespo respo)
        {
            _Respo = respo;
        }
        public List<DanhMuc> Get_All_Danh_Muc()
        {
            return _Respo.Get_All_Danh_Muc();
        }
    }
}
