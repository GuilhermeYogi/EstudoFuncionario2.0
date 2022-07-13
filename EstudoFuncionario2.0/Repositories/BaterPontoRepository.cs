using Dapper;
using EstudoFuncionario2._0.Entities;
using System.Data.SqlClient;

namespace EstudoFuncionario2._0.Repositories
{
    public class BaterPontoRepository
    {
        IConfiguration _config;

        public BaterPontoRepository(IConfiguration config)
        {
            _config = config;
        }
        public string GetConnectionString()
        {
            return _config.GetSection("DBContext").GetSection("Connections").GetSection("ConnectionString").Value;
        }
        public void AdicionaEntradaSaida(HistoricoHorasTrabalhadas entity)
        {
            using (var con = new SqlConnection(GetConnectionString()))
            {

                con.Open();
                var parameters = new { FuncionarioId = entity.funcionarioid, Entrada = entity.datahoraentrada, Saida = entity.datahorasaida };
                string query = "INSERT INTO HistoricoHorasTrabalhadas (DataHoraEntrada, DataHoraSaida, FuncionarioId) VALUES(@Entrada, @Saida, @FuncionarioId)";
                con.Query(query, parameters);
                con.Close();
            }
        }
    }
}
