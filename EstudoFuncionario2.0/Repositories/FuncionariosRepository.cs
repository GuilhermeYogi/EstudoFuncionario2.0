using Dapper;
using EstudoFuncionario2._0.Entities;
using System.Data.SqlClient;

namespace EstudoFuncionario2._0.Repositories
{
    public class FuncionariosRepository
    {
        IConfiguration _config;

        public FuncionariosRepository(IConfiguration config)
        {
            _config = config;
        }
        public string GetConnectionString()
        {
            return _config.GetSection("DBContext").GetSection("Connections").GetSection("ConnectionString").Value;
        }
        public void InserirFuncionario(Funcionario entity)
        {
            using (var con = new SqlConnection(GetConnectionString()))
            {

                con.Open();
                var parameters = new { Nome = entity.Nome, Idade = entity.Idade, DataNascimento = entity.DataNascimento, DataContratacao = entity.DataContratacao, DataCriacao = entity.DataCriacao, CargoId = entity.CargoId , GrauId = entity.GrauId };
                string query = "INSERT INTO Funcionario (Nome, Idade, DataNascimento, DataContratacao, DataCriacao, CargoId, GrauId) VALUES(@Nome, @Idade, @DataNascimento, @DataContratacao, @DataCriacao, @CargoId, @GrauId)";
                con.Query(query, parameters);
                con.Close();
            }
        }

    }
}
