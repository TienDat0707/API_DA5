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
    public class HoadonController : ControllerBase
    {
        private readonly IhoadonBusiness _IBusiness;
        public HoadonController(IhoadonBusiness _IBusine)
        {
            _IBusiness = _IBusine;
        }
        [Route("get_hoa_don")]
        [HttpGet]
        public List<HoadonModel> GET_ALL_HOA_DON()
        {
            return _IBusiness.Get_ALL_Hoadon();
        }
        
    }
}
