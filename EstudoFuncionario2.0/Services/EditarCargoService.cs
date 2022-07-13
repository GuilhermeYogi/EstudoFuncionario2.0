using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using EstudoFuncionario2._0.Repositories;

namespace EstudoFuncionario2._0.Services
{
    public class EditarCargoService : IEditarCargoService
    {
        EditarCargoRepository _repository;
        ConverterCargoCargoIdService _cargo;
        ConverterGrauGrauIdService _grau;
        public EditarCargoService(EditarCargoRepository repository, ConverterCargoCargoIdService cargo, ConverterGrauGrauIdService grau)
        {
            _repository = repository;
            _cargo = cargo;
            _grau = grau;
        }

        public string AlterarCargo (EditarCargoModel model)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = model.Nome;
            funcionario.CargoId = _cargo.AtribuirCargoId(model.NovoCargo);
            funcionario.GrauId = _grau.AtribuirGrauId(model.NovoGrau);
            _repository.AtualizaCargo(funcionario);

            return "Cargo Alterado";
        }
    }
}
