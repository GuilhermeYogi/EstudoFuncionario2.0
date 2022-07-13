using Dapper;
using EstudoFuncionario2._0.Entities;
using System.Data.SqlClient;

namespace EstudoFuncionario2._0.Repositories
{
    public class EditarFuncionarioRepository
    {
        IConfiguration _config;

        public EditarFuncionarioRepository(IConfiguration config)
        {
            _config = config;
        }
        public string GetConnectionString()
        {
            return _config.GetSection("DBContext").GetSection("Connections").GetSection("ConnectionString").Value;
        }
        public void AtualizarDadosFuncionario(string nomeBusca ,Funcionario entity)
        {
            using (var con = new SqlConnection(GetConnectionString()))
            {
                con.Open();
                var parameters = new { NomeAtual = nomeBusca,  NovoNome = entity.Nome, Idade = entity.Idade, DataNascimento = entity.DataNascimento.ToString("yyyy-MM-dd"), DataContratacao = entity.DataContratacao.ToString("yyyy-MM-dd") };
                string query = "UPDATE Funcionario  SET Nome = @NovoNome, Idade = @Idade, DataNascimento = @DataNascimento, DataContratacao = @DataContratacao WHERE Nome = @NomeAtual";
                con.Query(query, parameters);
                con.Close();
            }
        }
    }
}
