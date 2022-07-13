using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Models;
using EstudoFuncionario2._0.Repositories;
using Microsoft.Extensions.Configuration;

namespace EstudoFuncionario2._0.Teste
{
    public class VisualizaFuncionarioRepositoryTeste
    {
        Funcionario funcionario;
        public VisualizaFuncionarioRepositoryTeste()
        {
            funcionario = SelecionarFuncionario();
        }

        [Fact]
        public void ParaId1IdadeDeveSer29()
        {
            Assert.Equal(29, funcionario.Idade);

        }

        [Fact]
        public void ParaId1NomeDeveSerGuilherme()
        {

            Assert.Equal("Guilherme Inocente Yogi", funcionario.Nome);
        }


        private static Funcionario SelecionarFuncionario()
        {
            var myConfiguration = new Dictionary<string, string>
                    {
                        {"DBContext:Connections:ConnectionString", "server=Localhost;database=Funcionario;Trusted_Connection=True;Min Pool Size=5;Max Pool Size=250; Connect Timeout=60"},
                    };

            var configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(myConfiguration)
                .Build();

            var model = new VisualizaFuncionarioModel();
            model.Id = 1;

            var repo = new VisualizaFuncionarioRepository(configuration);
            var funcionario = repo.BuscarFuncionario(model);
            return funcionario;
        }
    }
}