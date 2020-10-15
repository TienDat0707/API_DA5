using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL.Interfaces;
using Model;

namespace BLL
{
    public class TintucBusiness : ItintucBusiness
    {
        private readonly ItintucRespo _Respo;
        public TintucBusiness(ItintucRespo respo)
        {
            _Respo = respo;
        }
        public List<TintucModel> Get_ALL_Tintuc()
        {
            return _Respo.Get_ALL_Tintuc();
        }

        public TintucModel Get_Tintuc_By_ID()
        {
            throw new NotImplementedException();
        }

        public List<TintucModel> Get_tintuc_new()
        {
            return _Respo.Get_Tintuc_New();
        }
    }
}
