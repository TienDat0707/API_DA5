using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class danhmucController : ControllerBase
    {
        private readonly IdanhmucBusiness _Business;
        public danhmucController(IdanhmucBusiness business)
        {
            _Business = business;
        }
        [HttpGet]
        [Route("Get_All_Danh_Muc")]
        public List<DanhmucModel> Get_All_Danh_Muc()
        {
            return _Business.Get_All_Danh_Muc();
        }
    }
}
