using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using EstudoFuncionario2._0.Repositories;

namespace EstudoFuncionario2._0.Services
{
    public class SalarioService : ISalarioService
    {
        VerificarHorasTrabalhadasService _horas;
        VisualizaFuncionarioRepository _busca;
        TabelaSalarioRepository _tabelaSalario;

        public SalarioService(VerificarHorasTrabalhadasService horas, VisualizaFuncionarioRepository busca, TabelaSalarioRepository tabelaSalario)
        {
            _horas = horas;
            _busca = busca;
            _tabelaSalario = tabelaSalario;
        }

        public string CalcularSalario(SalarioModel model)
        {           
            var funcionario = new Funcionario();
            funcionario = _busca.BuscarFuncionario(model.Id);
            var salarioCargo = _tabelaSalario.VerificarSalario(funcionario); 
            var horasTrabalhadas = _horas.CalcularHorasTrabalhadas(model);

            var salarioRecebido = (salarioCargo * horasTrabalhadas.TotalHours) / 200;

            return "Funcionario: " + funcionario.Nome + "\nSalario Recebido no mês " + model.Mes.ToString() + " de " + model.Ano.ToString() + ": R$" + salarioRecebido.ToString();
        }
    }
}
