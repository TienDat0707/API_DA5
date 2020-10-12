using System;
using System.Collections.Generic;
using System.Text;
using DAL.Interfaces;
using Model;
using DAL.Helper;
using System.Linq;


namespace DAL
{
   public class loaisanphamRespo : IloaisanphamRespo
    {
        private readonly IDatabaseHelper _dbHelper;
        public loaisanphamRespo(IDatabaseHelper databaseHelper)
        {
            _dbHelper = databaseHelper;
        }

        public List<LoaisanphamModel> Get_ALL_Loaisanpham()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_loaisanpham_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<LoaisanphamModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public LoaisanphamModel Get_Loaisanpham_By_ID()
        {
            throw new NotImplementedException();
        }
    }
}
