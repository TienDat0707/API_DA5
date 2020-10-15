using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL.Interfaces
{
   public interface IhoadonRespo
    {
        List<HoadonModel> Get_ALL_Hoadon();
       HoadonModel Get_Hoadon_By_ID();
    }
}
