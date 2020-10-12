using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL.Interfaces
{
    public interface IsanphamRespo
    {
        List<SanphamModel> Get_ALL_Sanpham();
        SanphamModel Get_Sanpham_By_ID();
    }
}
