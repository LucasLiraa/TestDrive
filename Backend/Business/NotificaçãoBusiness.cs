using System;
using System.Collections.Generic;

namespace backend.Business
{
    public class NotificacaoBusiness
    {
        Backend.Database.NotificacaoDatabase db = new Backend.Database.NotificacaoDatabase();
        public Backend.Models.TbNotificacao Cadastrar(Backend.Models.TbNotificacao tb)
        {
            if(tb.DsMensagem.Length > 100) throw new ArgumentException("Mensagem muito grande");

            if(db.ConsultarLogin(tb.IdLogin) == null) throw new ArgumentException("Login não existe");

            return db.Cadastrar(tb);
        }

        public List<Backend.Models.TbNotificacao> Consultar(int id)
        {
            if(db.ConsultarLogin(id) == null) throw new ArgumentException("Login não existe");

            return db.Consultar(id);
        }

        public Backend.Models.TbNotificacao Deletar(int id)
        {
            Backend.Models.TbNotificacao nit = db.ConsultarNit(id);
            if(nit == null) throw new ArgumentException("Registro não existe");

            return db.Deletar(nit);
        }

        public List<Backend.Models.TbNotificacao> DeletarLista(List<int> ids)
        {
            List<Backend.Models.TbNotificacao> noexcluir = new List<Backend.Models.TbNotificacao>();

            foreach(int id in ids)
            {
                Backend.Models.TbNotificacao nit = db.ConsultarNit(id);
                if(nit != null) db.Deletar(nit);

                else noexcluir.Add(nit);
            }

            if(noexcluir.Count != 0) throw new ArgumentException("Teve registros que não foram excluidos");

            return noexcluir;
        }

        public void AlterarStatus()
        {
            db.AlterarStatus();
        }
    }
}