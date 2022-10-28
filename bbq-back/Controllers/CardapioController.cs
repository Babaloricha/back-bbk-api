using Dominio.Commands.Requests;
using Dominio.Commands.Responses;
using Dominio.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace bbq_back.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardapioController :ControllerBase
    {
        [HttpGet(Name = "GetCardapio")]
        public ObtemCardapioResponse Get([FromServices] ICardapioHandler handler, [FromQuery]ObtemCardapioRequest command)
        {
            return handler.Handle(command);
        }
    }
}
