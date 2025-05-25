using BackendApi.Application.DTOs;

namespace BackendApi.Application.Interfaces
{
    public interface IClienteService
    {
        IEnumerable<ClienteDto> Listar();
        void Criar(ClienteDto dto);
    }
}
