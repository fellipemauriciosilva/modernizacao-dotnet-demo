using System.Net.Http;
using System.Net.Http.Json;

namespace bff_gateway.Services
{
    public class ClienteBffService
    {
        private readonly HttpClient _http;

        public ClienteBffService()
        {
            _http = new HttpClient
            {
                BaseAddress = new Uri("https://legacy-api-url/api/clientes") // ajuste a URL real
            };
        }

        public async Task<IEnumerable<object>> BuscarClientesDoLegado()
        {
            var resposta = await _http.GetFromJsonAsync<List<ClienteLegado>>("listagem");
            return resposta.Select(c => new { nome = c.Nome });
        }
    }

    public class ClienteLegado
    {
        public string Nome { get; set; }
        public string CodigoInterno { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
