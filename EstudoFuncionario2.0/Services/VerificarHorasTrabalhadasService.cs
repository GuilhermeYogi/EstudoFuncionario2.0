using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Models;
using EstudoFuncionario2._0.Repositories;

namespace EstudoFuncionario2._0.Services
{
    public class VerificarHorasTrabalhadasService
    {
        SalarioRepository _repository;

        public VerificarHorasTrabalhadasService(SalarioRepository repository)
        {
            _repository = repository;
        }

        public TimeSpan CalcularHorasTrabalhadas(SalarioModel model)
        {
            TimeSpan horasTrabalhadas, horasTotais = new TimeSpan();
            List<HistoricoHorasTrabalhadas> pontos = _repository.BuscarPontos(model);
            for (int i = 0; i < pontos.Count(); i++)
            {

                horasTrabalhadas = pontos[i].datahorasaida - pontos[i].datahoraentrada;
                horasTotais = horasTotais + horasTrabalhadas;
            }
            return horasTotais;
        }
    }
}
