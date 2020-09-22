namespace Backend.Models.Response
{
    public class ErroResponse
    {
        public int Código {get; set;}
        public string Erro {get; set;}
        public ErroResponse(string e,int c)
        {
            this.Código = c;
            this.Erro = e;
        }
    }
}