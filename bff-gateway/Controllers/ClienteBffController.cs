using Microsoft.AspNetCore.Mvc;
using bff_gateway.Services;

namespace bff_gateway.Controllers
{
    [ApiController]
    [Route("api/bff/clientes")]
    public class ClienteBffController : ControllerBase
    {
        private readonly ClienteBffService _service;

        public ClienteBffController(ClienteBffService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var dados = await _service.BuscarClientesDoLegado();
            return Ok(dados);
        }
    }
}
