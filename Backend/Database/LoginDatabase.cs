using System;
using System.Linq;

namespace Backend.Database
{
    public class LoginDatabase
    {
        Models.teste_drive_bdContext ctx = new Models.teste_drive_bdContext();
        public Models.TbLogin Consultar (Models.TbLogin tb)
        {
           return ctx.TbLogin.FirstOrDefault(x => x.DsEmail == tb.DsEmail &&
                                                  x.DsSenha == tb.DsSenha);
        }

        public Models.TbLogin ConsultarEmail(string email)
        {
            return ctx.TbLogin.FirstOrDefault(x => x.DsEmail == email);
        }
        
        public Models.TbLogin RedefinirSenha(int id, string senha)
        {
            Models.TbLogin login = ctx.TbLogin.FirstOrDefault(x => x.IdLogin == id);
            login.DsSenha = senha;
            ctx.SaveChanges();

            return login;
        }

    }
}