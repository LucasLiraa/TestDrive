using System;

namespace Backend.Models.Request
{
    public class AgendamentoRequest
    {
        public int Login {get; set;}
        public int Veiculo {get; set;}
        public DateTime Data {get; set;}
        public string Acompanhante {get; set;}
    }
}