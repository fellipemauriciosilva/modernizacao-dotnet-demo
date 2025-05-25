using Microsoft.AspNetCore.Mvc;
using BackendApi.Application.Interfaces;
using BackendApi.Application.DTOs;

namespace BackendApi.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _service;

        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_service.Listar());

        [HttpPost]
        public IActionResult Post([FromBody] ClienteDto dto)
        {
            _service.Criar(dto);
            return Created("", null);
        }
    }
}
