using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using DAL.Helper;
using DAL.Interfaces;
using Model;

namespace DAL
{
    public class danhmucRespo : IdanhmucRespo
    {
        private readonly IDatabaseHelper _dbHelper;
        public danhmucRespo(IDatabaseHelper ihelper)
        {
            _dbHelper = ihelper;
        }
        public List<DanhmucModel> Get_All_Danh_Muc()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_danhmuc_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<DanhmucModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
