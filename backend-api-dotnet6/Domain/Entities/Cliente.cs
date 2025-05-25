namespace BackendApi.Domain.Entities
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
