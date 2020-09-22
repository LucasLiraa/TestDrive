using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {
        Business.VeiculoBusiness buss = new Business.VeiculoBusiness();
        Backend.Utils.VeiculoConversor conv = new Backend.Utils.VeiculoConversor();

        [HttpPost]
        public ActionResult<List<Backend.Models.Response.VeiculoResponse>> Consultar(bool pcd)
        {
            try
            {
                return  conv.ParaListaResponse(buss.Consultar(pcd));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message,404)
                );
            }
        }

        [HttpGet("ping")]
        public string ping()
        {
            return "ping";
        }
    }
}