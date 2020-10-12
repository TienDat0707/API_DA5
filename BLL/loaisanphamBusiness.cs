using System;
using System.Collections.Generic;
using System.Text;
using BLL.Interfaces;
using DAL.Interfaces;
using Model;

namespace BLL
{
    public class loaisanphamBusiness : IloaisanphamBusiness
    {
        private readonly IloaisanphamRespo _Respo;
        public loaisanphamBusiness(IloaisanphamRespo respo)
        {
            _Respo = respo;
        }
        public List<LoaisanphamModel> Get_ALL_Loaisanpham()
        {
            return _Respo.Get_ALL_Loaisanpham();
        }

        public LoaisanphamModel Get_Loaisanpham_By_ID()
        {
            throw new NotImplementedException();
        }
    }
}
