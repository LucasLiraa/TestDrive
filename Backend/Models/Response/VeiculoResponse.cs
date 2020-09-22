using System;

namespace Backend.Models.Response
{
    public class VeiculoResponse
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime Ano { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public string[] Adaptacao { get; set; }
        public decimal Valor { get; set; }
        public string Imagem { get; set; }
        public bool Disponivel { get; set; }
        public string Combustivel { get; set; }
    }
}