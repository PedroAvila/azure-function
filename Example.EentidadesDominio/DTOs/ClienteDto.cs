namespace Example.EntidadesDominio
{
    public class ClienteDto
    {
        public int ClienteId { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public DateTime FechaAlta { get; set; }
        public int Estado { get; set; }
    }
}
