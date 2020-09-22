using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NotificacaoController : ControllerBase
    {
        Backend.Utils.NotificaçaoConversor conv = new Backend.Utils.NotificaçaoConversor();
        Business.NotificacaoBusiness buss = new Business.NotificacaoBusiness();

        [HttpPost]
        public ActionResult<Backend.Models.Response.NotificacaoResponse> Cadastrar(Backend.Models.Request.NotificaçaoRequest req)
        {
            try
            {
                Backend.Models.TbNotificacao notifi = conv.ParaTabela(req);
                return conv.ParaResponse(buss.Cadastrar(notifi));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message,400)
                );
            }
        }

        [HttpGet]
        public ActionResult<List<Backend.Models.Response.NotificacaoResponse>> Consultar(int id)
        {
            try
            {
                return conv.ParaListaResponse(buss.Consultar(id));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message,500)
                );
            }
        }

        [HttpDelete]
        public ActionResult<Backend.Models.Response.NotificacaoResponse> Deletar(int id)
        {
            try
            {
                return conv.ParaResponse(buss.Deletar(id));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message,404)
                );
            }
        }
        
        [HttpDelete("Lista")]
        public ActionResult<List<Backend.Models.Response.NotificacaoResponse>> DeletarLista(List<int> ids)
        {
            try
            {
                Console.WriteLine("Controller");
                return conv.ParaListaResponse(buss.DeletarLista(ids));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message,404)
                );
            }
        }

        [HttpPut]
        public void AlterarStatus()
        {
            try
            {
                buss.AlterarStatus();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [HttpGet("ping")]
        public string ping()
        {
            return "ping";
        }
    }
}