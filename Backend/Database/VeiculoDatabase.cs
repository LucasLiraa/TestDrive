using System;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Database
{
    public class VeiculoDatabase
    {
        Models.teste_drive_bdContext ctx = new Models.teste_drive_bdContext();
        public List<Models.TbVeiculo> Consultar(bool Disponivel)
        {
            return ctx.TbVeiculo.Where(x => x.BtDisponivel == true &&
                                            x.BtCarroDisponivelTd == Disponivel).ToList();
        }
    }
}
