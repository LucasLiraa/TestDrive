using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class VeiculoBusiness
    {
        Backend.Database.VeiculoDatabase db = new Backend.Database.VeiculoDatabase();
        public List<Backend.Models.TbVeiculo> Consultar(bool Disponivel)
        {
           List<Backend.Models.TbVeiculo> ret = db.Consultar(Disponivel);
           Console.WriteLine($"{ret[0]}");
           if(ret == null) throw new ArgumentException("Nenhum carro encontrado");
           return ret;
        }
    }
}