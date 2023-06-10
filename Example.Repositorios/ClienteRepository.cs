using Dapper;
using Example.ContratoRepositorio;
using Example.EntidadesDominio;
using MySql.Data.MySqlClient;

namespace Example.Repositorios
{
    public class ClienteRepository : IClienteRepository
    {
        private string _connectionString = string.Empty;
        public ClienteRepository(string connectionString)
        {
            _connectionString = connectionString.Replace("\"", "");
        }

        public Task<IEnumerable<Cliente>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Cliente> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Cliente entity)
        {
            

            entity.FechaAlta = DateTime.Now;
            var sql = "INSERT INTO clientes(nombre, direccion, fecha_alta, estado) VALUES(@nombre, @direccion, @fecha_alta, @estado)";
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                await connection.ExecuteAsync(sql, new
                {
                    entity.Nombre,
                    entity.Direccion,
                    fecha_alta = entity.FechaAlta,
                    entity.Estado
                });
            }
        }

        public Task UpdateAsync(Cliente entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
