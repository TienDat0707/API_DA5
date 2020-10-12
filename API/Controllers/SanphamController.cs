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
    }
}
