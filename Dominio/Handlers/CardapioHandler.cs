using Dominio.Commands.Requests;
using Dominio.Commands.Responses;


namespace Dominio.Handlers
{
    public class CardapioHandler : ICardapioHandler
    {
        public ObtemCardapioResponse Handle(ObtemCardapioRequest request)
        {
            //obtem o cardapio
            var lista = new List<PratoResponseModel>();
            var prato1 = new PratoResponseModel("PQN", "Pao,carne,queijo");
            var prato2 = new PratoResponseModel("Super Carne", "Pao, 1kg de amburger angus bbq");
            lista.Add(prato1);
            lista.Add(prato2);
            var response = new ObtemCardapioResponse();
            response.Pratos = lista;

            return response;
        }
    }
}
