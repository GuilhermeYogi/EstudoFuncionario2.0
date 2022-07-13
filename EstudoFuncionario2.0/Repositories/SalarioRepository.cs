//using Dapper;
//using EstudoFuncionario2._0.Entities;
//using EstudoFuncionario2._0.Models;
//using System.Data.SqlClient;

using Dapper;
using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Models;
using System.Data.SqlClient;

namespace EstudoFuncionario2._0.Repositories
{
    public class SalarioRepository
    {
        IConfiguration _config;

        public SalarioRepository(IConfiguration config)
        {
            _config = config;
        }
        public string GetConnectionString()
        {
            return _config.GetSection("DBContext").GetSection("Connections").GetSection("ConnectionString").Value;
        }
        public List<HistoricoHorasTrabalhadas> BuscarPontos(SalarioModel model)
        {
            var pontos = new List<HistoricoHorasTrabalhadas>();
            using (var con = new SqlConnection(GetConnectionString()))
            {
                
                con.Open();
                var parameters = new { Id = model.Id , Mes = model.Mes, Ano = model.Ano };
                string query = "SELECT DataHoraEntrada, DataHoraSaida, FuncionarioId FROM HistoricoHorasTrabalhadas WHERE MONTH (DataHoraEntrada) = @Mes AND YEAR (DataHoraEntrada) = @Ano AND FuncionarioId = @Id";
                pontos = con.Query<HistoricoHorasTrabalhadas>(query, parameters).ToList();
                con.Close();
            }

            return pontos;
        }
    }
}
