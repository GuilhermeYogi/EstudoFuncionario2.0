using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using EstudoFuncionario2._0.Repositories;

namespace EstudoFuncionario2._0.Services
{
    public class BaterPontoService : IBaterPontoService
    {
        BaterPontoRepository _repository;
        VisualizaFuncionarioRepository _repositoryFuncionario;

        public BaterPontoService(VisualizaFuncionarioRepository repositoryFuncionario, BaterPontoRepository repository)
        {
            _repositoryFuncionario = repositoryFuncionario;
            _repository = repository;
        }

        public string InserirPontoDeHoras(BaterPontoModel model)
        {
            Funcionario funcionario = new Funcionario();
            HistoricoHorasTrabalhadas entity = new HistoricoHorasTrabalhadas();

            funcionario = _repositoryFuncionario.BuscarFuncionario(model.FuncionarioId);
            entity.funcionarioid = model.FuncionarioId;
            entity.datahoraentrada = model.HorarioDeEntrada;
            entity.datahorasaida = model.HorarioDeSaida;

            if (entity.datahorasaida.Date != entity.datahoraentrada.Date)
            {
                return "Datas diferentes. Formato invalido, ponto não adicionado.";
            }

            _repository.AdicionaEntradaSaida(entity);

            return "Ponto de horas adicionado para: " + funcionario.Nome + "\nData:" + entity.datahoraentrada.ToShortDateString() + "\nHorario de Entrada: " + entity.datahoraentrada.ToShortTimeString() + " - Horario de Saida: " + entity.datahorasaida.ToShortTimeString();
        }
    }
}
