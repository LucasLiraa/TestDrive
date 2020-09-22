using System;

namespace Backend.Models.Response
{
    public class NotificacaoResponse
    {
        public int Id { get; set; }
        public int Login { get; set; }
        public DateTime Envio { get; set; }
        public string Mensagem { get; set; }
        public string Leitura { get; set; }
    }
}