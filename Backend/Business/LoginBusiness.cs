using System;

namespace backend.Business
{
    public class LoginBusiness
    {
        Backend.Database.LoginDatabase db = new Backend.Database.LoginDatabase();
        public Backend.Models.TbLogin Consultar (Backend.Models.TbLogin tb)
        {
            Backend.Models.TbLogin login =  db.Consultar(tb);
            if(login == null) throw new ArgumentException("Email ou senha incorretos");
            return login;
        }    

        public Backend.Models.TbLogin Alterar(int id, int cod, string senha)
        {
             Func<string, bool> senhaForte = (s) => {
                int esp = 0, num = 0;
                foreach(char letra in s)
                {
                    if(char.GetNumericValue(letra) > 0) num += 1;
                    else if(((int)letra < 97 && (int)letra > 122)) esp += 1; 
                }
                return s.Length >= 8 && esp >= 2 && num >= 2;
            };

            if(senhaForte(senha)) throw new ArgumentException("Senha fraca. Tente outra senha");

            return db.RedefinirSenha(id,senha);
        }
    }
}