using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Commands.Responses
{
    public class ObtemCardapioResponse
    {
        public IEnumerable<PratoResponseModel> Pratos { get; set; }
    }

    public class PratoResponseModel
    {
        public string Nome { get; set; }
        public string Ingredientes { get; set; }

        public PratoResponseModel(string nome, string ingredientes)
        {
            Nome = nome;
            Ingredientes = ingredientes;
        }
    }
}
