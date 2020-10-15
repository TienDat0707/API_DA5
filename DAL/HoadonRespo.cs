using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Helper;
using DAL.Interfaces;
using Model;

namespace DAL
{
    public class HoadonRespo : IhoadonRespo
    {
        private readonly IDatabaseHelper _dbHelper;
        public HoadonRespo(IDatabaseHelper databaseHelper)
        {
            _dbHelper = databaseHelper;
        }
        public List<HoadonModel> Get_ALL_Hoadon()
        {
            string msgError = "";
            try
            {
                var dt = _dbHelper.ExecuteSProcedureReturnDataTable(out msgError, "sp_hoadon_all");
                if (!string.IsNullOrEmpty(msgError))
                    throw new Exception(msgError);
                return dt.ConvertTo<HoadonModel>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public HoadonModel Get_Hoadon_By_ID()
        {
            throw new NotImplementedException();
        }
    }
}
