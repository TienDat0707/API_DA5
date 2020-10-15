using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanphamController : ControllerBase
    {
        private readonly IsanphamBusiness _IBusiness;
        public SanphamController(IsanphamBusiness _IBusine)
        {
            _IBusiness = _IBusine;
        }
        [Route("get_san_pham")]
        [HttpGet]
        public List<SanphamModel> GET_ALL_SAN_PHAM()
        {
            return _IBusiness.Get_ALL_Sanpham();
        }
        [Route("Get_Sanpham_new")]
        [HttpGet]
        public List<SanphamModel> Get_Sanpham()
        {
            return _IBusiness.Get_Sanpham_New();
        }
        [Route("get-by-id/{id}")]
        [HttpGet]
        public SanphamModel Get_Sanpham_By_ID(int id)
        {
            return _IBusiness.Get_Sanpham_By_ID(id);
        }
        [Route("Get_Sanpham_lq/{id}")]
        [HttpGet]
        public List<SanphamModel> Get_Sanpham_lq(int id)
        {
            return _IBusiness.Get_Sanpham_lq(id);
        }
        [Route("get_san_pham_by_iddm/{id}")]
        [HttpGet]
        public List<SanphamModel> get_san_pham_by_iddm(int id)
        {
            return _IBusiness.get_san_pham_by_iddm(id);
        }
    }
}
