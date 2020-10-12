using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL.Interfaces
{
   public interface IloaisanphamRespo
    {
        List<LoaisanphamModel> Get_ALL_Loaisanpham();
        LoaisanphamModel Get_Loaisanpham_By_ID();
    }
}
