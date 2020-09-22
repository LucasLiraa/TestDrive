using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Agendamento : ControllerBase
    {
        Backend.Business.AgendamentoBusiness buss = new Backend.Business.AgendamentoBusiness();
        Backend.Utils.AgendamentoConversor conv = new Backend.Utils.AgendamentoConversor();

        [HttpPost("status")]
        public ActionResult<List<Backend.Models.Response.AgendamentoResponse>> Consultar(int id, string status)
        {
            try
            {
                Console.WriteLine("Controller");
               return conv.ParaListaResponse(buss.Consultar(id,status));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message,400)
                );
            }
        }
        [HttpPut("Status")]
        public ActionResult<Backend.Models.Response.AgendamentoResponse> AlterarStatus(int id, string status)
        {
            try
            {
                return conv.ParaResponse(buss.AlterarStatus(id,status));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message,400)
                );
            }
        }
        [HttpPut("Avafeed")] // Avaliação e Feedback
        public ActionResult<Backend.Models.Response.AgendamentoResponse> AlterarAvaFeed(int id, int avaliacao,string feedback)
        {
            try
            {
                return conv.ParaResponse(buss.AlterarAvaFeed(id,avaliacao,feedback));
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message, 400)
                );
            }
        }

        [HttpPost]
        public ActionResult<Backend.Models.Response.AgendamentoResponse> Cadastrar(Backend.Models.Request.AgendamentoRequest req)
        {
            try
            {    
                Backend.Models.TbAgendamento ag = conv.ParaTabela(req);
                return conv.ParaResponse(buss.Cadastrar(req.Login,ag));
            }
            catch (Exception ex)
            {
               return new BadRequestObjectResult(
                   new Backend.Models.Response.ErroResponse(ex.Message,400)
               );
            }
        }

        [HttpGet]
        public ActionResult<List<DateTime>> ConsultarHorarios(DateTime dia)
        {
            try
            {
                return buss.ConsultarHorarios(dia);
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(
                    new Backend.Models.Response.ErroResponse(ex.Message,400)
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