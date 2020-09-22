using System;
using Microsoft.AspNetCore.Mvc;


namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        Backend.Utils.ClienteConversor conv = new Backend.Utils.ClienteConversor();
        Backend.Business.ClienteBusiness buss = new  Backend.Business.ClienteBusiness();

        [HttpGet("{id}")]
        public ActionResult<Backend.Models.Response.ClienteResponse> Consultar(int id)
        {
            try
            {
                return conv.ParaResponse(buss.Consultar(id));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message,400)
                );
            }
        }

        [HttpPost("ping")]
        public string ping()
        {
            return "ping";
        }
    }
}