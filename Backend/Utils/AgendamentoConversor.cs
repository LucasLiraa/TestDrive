using System;
using System.Linq;
using System.Collections.Generic;

namespace Backend.Utils
{
    public class AgendamentoConversor
    {
        public Models.Response.AgendamentoResponse ParaResponse(Models.TbAgendamento tb)
        {
            return new Models.Response.AgendamentoResponse {
                Id = tb.IdAgendamento,
                Cliente = tb.IdCliente,
                Veiculo = tb.IdVeiculo,
                Data = tb.DtAgendamento,
                Inicial = tb.DsRotaInicial,
                Final = tb.DsRotaFinal,
                HoraFinal = tb.HrFinal,
                Status = tb.DsStatus,
                Avaliacao = tb.NrAvaliacao,
                Feedback = tb.DsFeedback
            };
        }
        
        public Models.TbAgendamento ParaTabela(Models.Request.AgendamentoRequest req)
        {
            return new Models.TbAgendamento {
              DsRotaInicial = "Av. Rio Bonito - Socorro ",
              DsRotaFinal = "Av. Prof Papini - Cidade Dutra",
              DsStatus = "Concluido",
              DtAgendamento = req.Data,
              DsAcompanhante = req.Acompanhante,
              IdVeiculo = req.Veiculo,
              HrFinal = TimeSpan.Parse(req.Data.AddMinutes(45).ToLongTimeString()),        
            };
        }
        public List<Models.Response.AgendamentoResponse> ParaListaResponse(List<Models.TbAgendamento> tbs)
        {
            return tbs.Select(x => this.ParaResponse(x)).ToList();
        }
    }
}    
    