using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using EstudoFuncionario2._0.Repositories;

namespace EstudoFuncionario2._0.Services
{
    public class VisualizaFuncionarioService : IVisualizaFuncionarioService
    {
        VisualizaFuncionarioRepository _repository;
        ConverterCargoCargoIdService _atribuiCargoService;
        ConverterGrauGrauIdService _atribuiGrauService;

        public VisualizaFuncionarioService(VisualizaFuncionarioRepository repository, ConverterCargoCargoIdService atribuiCargoService, ConverterGrauGrauIdService atribuiGrauService)
        {
            _repository = repository;
            _atribuiCargoService = atribuiCargoService;
            _atribuiGrauService = atribuiGrauService;
        }



        public string ChecarFuncionario (int id)
        {
            var entity = _repository.BuscarFuncionario(id);
            string cargo = _atribuiCargoService.AtribuirCargo(entity.CargoId);
            string grau = _atribuiGrauService.AtribuirGrau(entity.GrauId);
            
            return "Nome:" + entity.Nome + "\nCargo:"  + cargo + " " +grau;

        }

    }
}
