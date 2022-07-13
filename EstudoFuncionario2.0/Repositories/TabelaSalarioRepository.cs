using Dapper;
using EstudoFuncionario2._0.Entities;
using System.Data.SqlClient;

namespace EstudoFuncionario2._0.Repositories
{
    public class TabelaSalarioRepository
    {
        IConfiguration _config;

        public TabelaSalarioRepository(IConfiguration config)
        {
            _config = config;
        }
        public string GetConnectionString()
        {
            return _config.GetSection("DBContext").GetSection("Connections").GetSection("ConnectionString").Value;
        }
        public int VerificarSalario(Funcionario funcionario)
        {

            using (var con = new SqlConnection(GetConnectionString()))
            {
                con.Open();
                var parameters = new { CargoId = funcionario.CargoId , GrauId = funcionario.GrauId };
                string query = "SELECT Valor FROM Salario WHERE CargoId = @CargoId AND GrauId = @GrauId";
                var salario = con.Query<int>(query, parameters).Single();
                con.Close();
                return salario;

            }
        }
    }
}
