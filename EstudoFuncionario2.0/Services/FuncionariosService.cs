using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using EstudoFuncionario2._0.Repositories;

namespace EstudoFuncionario2._0.Services
{
    public class FuncionariosService : IFuncionariosService
    {
        FuncionariosRepository _repository;
        RetornaIdadeService _idade;
        ConverterCargoCargoIdService _cargoId;
        ConverterGrauGrauIdService _grauId;


        public FuncionariosService(FuncionariosRepository repository, RetornaIdadeService retornaIdadeService, ConverterCargoCargoIdService cargoid, ConverterGrauGrauIdService grauId)
        {
            _repository = repository;
            _idade = retornaIdadeService;
            _cargoId = cargoid;
            _grauId = grauId;
        }

        public string AdicionarFuncionario(FuncionarioAddModel model)
        {
            Funcionario entity = new Funcionario();

            entity.Nome = model.NomeFuncionario;
            entity.DataNascimento = model.DataNascimentoFuncionario;
            entity.DataContratacao = model.DataContratacaoFuncionario;
            entity.DataCriacao = DateTime.Today;
            DateTime hoje = DateTime.Today;
            entity.CargoId = _cargoId.AtribuirCargoId(model.Cargo);
            entity.GrauId = _grauId.AtribuirGrauId(model.Grau);
            entity.Idade = _idade.CalcularIdade(model.DataNascimentoFuncionario);

            _repository.InserirFuncionario(entity);
            return "Funcionario adicionado.";
        }
    }
}
