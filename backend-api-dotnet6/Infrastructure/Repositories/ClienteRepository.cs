using BackendApi.Domain.Entities;

namespace BackendApi.Infrastructure.Repositories
{
    public class ClienteRepository
    {
        private static readonly List<Cliente> _clientes = new();

        public IEnumerable<Cliente> GetAll() => _clientes;

        public void Add(Cliente cliente) => _clientes.Add(cliente);
    }
}
