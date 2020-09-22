using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Utils
{
    public class NotificaçaoConversor
    {
        public Models.TbNotificacao ParaTabela (Models.Request.NotificaçaoRequest req)
        {
            return new Models.TbNotificacao {
                DsMensagem = req.Mensagem,
                IdLogin = req.login,
                DtEnvio = DateTime.Now,
                DsStatus = "Lido"
            };
        }

        public Models.Response.NotificacaoResponse ParaResponse(Models.TbNotificacao tb)
        {
            return new Models.Response.NotificacaoResponse {
                Id = tb.IdNotificacao,
                Login = tb.IdLogin,
                Mensagem = tb.DsMensagem,
                Envio = new DateTime(tb.DtEnvio.Year,tb.DtEnvio.Month,tb.DtEnvio.Day),
                Leitura = tb.DsStatus
            };
        }  

        public List<Models.Response.NotificacaoResponse> ParaListaResponse(List<Models.TbNotificacao> tbs)
        {
            return tbs.Select(x => this.ParaResponse(x)).ToList();
        }      
    }
}
        