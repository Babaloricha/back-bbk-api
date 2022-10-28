
using System;

namespace Dominio.Models
{
    public class PratoModel
    {
        public Guid id { get; set; }
        public string Nome { get; set; }
        public string Ingredientes { get; set; }
        public decimal Preco { get; set; }
    }
}
