using System.Collections.Generic;
using System.Threading.Tasks;
using BLL;
using BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaisanphamController: ControllerBase
    {
        private readonly IloaisanphamBusiness _IBusiness;
        public LoaisanphamController(IloaisanphamBusiness _IBusine)
        {
            _IBusiness = _IBusine;
        }
        [Route("get_loai_san_pham")]
        [HttpGet]
        public List<LoaisanphamModel> GET_ALL_LOAI_SAN_PHAM()
        {
            return _IBusiness.Get_ALL_Loaisanpham();
        }
    }
}
