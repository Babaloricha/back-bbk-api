using Dominio.Commands.Requests;
using Dominio.Commands.Responses;

namespace Dominio.Handlers
{
    public interface ICardapioHandler
    {
        ObtemCardapioResponse Handle(ObtemCardapioRequest request);
    }
}
