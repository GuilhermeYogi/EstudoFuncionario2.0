using Dapper;
using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Models;
using System.Data.SqlClient;

namespace EstudoFuncionario2._0.Repositories
{
    public class EditarCargoRepository
    {
        IConfiguration _config;

        public EditarCargoRepository(IConfiguration config)
        {
            _config = config;
        }
        public string GetConnectionString()
        {
            return _config.GetSection("DBContext").GetSection("Connections").GetSection("ConnectionString").Value;
        }
        public void AtualizaCargo(Funcionario entity)
        {
            using (var con = new SqlConnection(GetConnectionString()))
            {
                con.Open();
                var parameters = new { Nome = entity.Nome, CargoId= entity.CargoId, GrauId = entity.GrauId };
                string query = "UPDATE Funcionario  SET CargoId = @CargoId, GrauId = @GrauId WHERE Nome = @Nome";
                con.Query(query, parameters);
                con.Close();
            }
        }
    }
}
