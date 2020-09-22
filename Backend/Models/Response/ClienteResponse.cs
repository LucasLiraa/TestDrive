using System;

namespace Backend.Models.Response
{
    public class ClienteResponse
    {
        public int Id {get; set;}
        public int Login {get; set;}
        public string Nome {get; set;}
        public string CPF {get; set;}
        public DateTime? Nascimento {get; set;}
        public string Endereço {get; set;}
        public string Celular {get; set;}
        public bool Deficiencia {get; set;}
        public string CNH {get; set;}
        public string Imagem {get; set;}
    }
}