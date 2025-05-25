using Xunit;
using BackendApi.Application.Services;
using BackendApi.Application.DTOs;
using BackendApi.Infrastructure.Repositories;

public class ClienteServiceTests
{
    [Fact]
    public void Deve_Adicionar_Cliente()
    {
        var repo = new ClienteRepository();
        var service = new ClienteService(repo);

        var dto = new ClienteDto("Maria");
        service.Criar(dto);

        var resultado = service.Listar();
        Assert.Contains(resultado, c => c.Nome == "Maria");
    }
}
