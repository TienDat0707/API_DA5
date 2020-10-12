using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace BLL.Interfaces
{
   public interface IloaisanphamBusiness
    {
        List<LoaisanphamModel> Get_ALL_Loaisanpham();
       LoaisanphamModel Get_Loaisanpham_By_ID();

    }
}
