using BackendApi.Application.DTOs;
using BackendApi.Application.Interfaces;
using BackendApi.Domain.Entities;
using BackendApi.Infrastructure.Repositories;

namespace BackendApi.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly ClienteRepository _repo;

        public ClienteService(ClienteRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<ClienteDto> Listar()
        {
            return _repo.GetAll().Select(c => new ClienteDto(c.Nome));
        }

        public void Criar(ClienteDto dto)
        {
            var cliente = new Cliente
            {
                Id = Guid.NewGuid(),
                Nome = dto.Nome,
                CriadoEm = DateTime.UtcNow
            };

            _repo.Add(cliente);
        }
    }
}
