using Dapper;
using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Models;
using System.Data.SqlClient;

namespace EstudoFuncionario2._0.Repositories
{
    public class VisualizaFuncionarioRepository
    {
        IConfiguration _config;

        public VisualizaFuncionarioRepository(IConfiguration config)
        {
            _config = config;
        }
        public string GetConnectionString()
        {
            return _config.GetSection("DBContext").GetSection("Connections").GetSection("ConnectionString").Value;
        }
        public Funcionario BuscarFuncionario(int id)
        {
            var entity = new Funcionario();

            using (var con = new SqlConnection(GetConnectionString()))
            {
                con.Open();
                var parameters = new { Id = id };
                string query = "SELECT * FROM Funcionario WHERE Id= @Id";
                entity = con.Query<Funcionario>(query,parameters).Single();           
                con.Close();
                
            }
            
            return entity;
        }

    }
}
