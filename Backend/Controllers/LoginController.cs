using System;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        Business.LoginBusiness buss = new Business.LoginBusiness();
        Backend.Utils.LoginConversor conv = new Backend.Utils.LoginConversor();

        [HttpGet]
        public ActionResult<Backend.Models.Response.LoginResponse> Consultar(Backend.Models.Request.LoginRequest req)
        {
            try
            {
                Backend.Models.TbLogin login = conv.ParaTabela(req);
                return conv.ParaResponse(buss.Consultar(login));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message,400)
                );
            }
        }

        [HttpPut]
        public ActionResult<Backend.Models.Response.LoginResponse> AlterarSenha(int id, int code, string senha)
        {
            try
            {
                return conv.ParaResponse(buss.Alterar(id,code,senha));
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