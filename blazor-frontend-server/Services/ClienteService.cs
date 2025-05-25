using System.Net.Http.Json;

public class ClienteService
{
    private readonly HttpClient _http;

    public ClienteService(HttpClient http)
    {
        _http = http;
    }

    public async Task<List<ClienteDto>> ListarAsync()
    {
        return await _http.GetFromJsonAsync<List<ClienteDto>>("api/clientes") ?? new();
    }

    public async Task<bool> SalvarAsync(ClienteDto cliente)
    {
        var response = await _http.PostAsJsonAsync("api/clientes", cliente);
        return response.IsSuccessStatusCode;
    }
}

public class ClienteDto
{
    public string Nome { get; set; } = string.Empty;
}
