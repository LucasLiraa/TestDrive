using System;
using Microsoft.AspNetCore.Http;

namespace Backend.Models.Request
{
    public class ClienteRequest
    {
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        public string Endereço {get; set;}
        public string Celular {get; set;}
        public string CPF {get; set;}
        public DateTime Nascimento {get; set;}
        public bool Deficiencia {get; set;}
        public string CNH {get; set;}
        public IFormFile Imagem {get; set;}
    }
}