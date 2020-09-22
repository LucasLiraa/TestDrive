using System;
using System.Linq;
using System.Collections.Generic;

namespace Backend.Database
{
    public class NotificacaoDatabase
    {
        Models.teste_drive_bdContext ctx = new Models.teste_drive_bdContext();

        public Models.TbLogin ConsultarLogin(int id)
        {
            return ctx.TbLogin.FirstOrDefault(x => x.IdLogin == id);
        }

        public Models.TbNotificacao Cadastrar(Models.TbNotificacao tb)
        {
            ctx.TbNotificacao.Add(tb);
            ctx.SaveChanges();
            return tb;
        }

        public Models.TbNotificacao ConsultarNit(int id)
        {
            return ctx.TbNotificacao.FirstOrDefault(x => x.IdNotificacao == id);
        }

        public List<Models.TbNotificacao> Consultar(int id)
        {
            return ctx.TbNotificacao.Where(x => x.IdLogin == id).ToList();
        }

        public Models.TbNotificacao Deletar(Models.TbNotificacao tb)
        {
            ctx.TbNotificacao.Remove(tb);
            ctx.SaveChanges();
            return tb;
        }

        public void AlterarStatus()
        {
           foreach(Models.TbNotificacao tb in ctx.TbNotificacao.ToList())
           {
               tb.DsStatus = "lido";
           }
           ctx.SaveChanges();
        }
    }
}