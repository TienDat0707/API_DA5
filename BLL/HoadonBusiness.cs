using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL.Interfaces;
using Model;

namespace BLL
{
    public class HoadonBusiness : IhoadonBusiness
    {
        private readonly IhoadonRespo _Respo;
        public HoadonBusiness(IhoadonRespo respo)
        {
            _Respo = respo;
        }
        public List<HoadonModel> Get_ALL_Hoadon()
        {
            return _Respo.Get_ALL_Hoadon();
        }

        public HoadonModel Get_Hoadon_By_ID()
        {
            throw new NotImplementedException();
        }
    }
}
