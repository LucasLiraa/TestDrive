namespace Backend.Utils
{
    public class ClienteConversor
    {
        public Models.TbCliente ParaTabela(Models.Request.ClienteRequest req)
        {
            return new Models.TbCliente {
               NmCliente =  req.Nome,
               NrCelular = req.Celular,
               DtNascimento = req.Nascimento,
               NrCnh = req.CNH,
               NrCpf = req.CPF,
               BtDeficiente = req.Deficiencia,
               DsEndereco = req.Endereço,
            };
        }

        public Models.Response.ClienteResponse ParaResponse(Models.TbCliente tb)
        {
            return new Models.Response.ClienteResponse {
                Id = tb.IdCliente,
                Nome = tb.NmCliente,
                Celular = tb.NrCelular,
                Nascimento = tb.DtNascimento,
                CNH = tb.NrCnh,
                CPF = tb.NrCpf,
                Deficiencia = tb.BtDeficiente,
                Endereço = tb.DsEndereco,
            };
        }
    }
}