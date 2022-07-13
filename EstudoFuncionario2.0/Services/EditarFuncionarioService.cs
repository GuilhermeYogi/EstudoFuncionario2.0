using EstudoFuncionario2._0.Entities;
using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using EstudoFuncionario2._0.Repositories;

namespace EstudoFuncionario2._0.Services
{
    public class EditarFuncionarioService : IEditarFuncionarioService
    {
        EditarFuncionarioRepository _repository;
        RetornaIdadeService _retornaIdade;

        public EditarFuncionarioService(EditarFuncionarioRepository repository, RetornaIdadeService retornaIdade)
        {
            _repository = repository;
            _retornaIdade = retornaIdade;
        }

        public string AlterarDadosFuncionario (EditarFuncionarioModel model)
        {
            Funcionario entity = new Funcionario();

            entity.Nome = model.NovoNome;
            entity.Idade = _retornaIdade.CalcularIdade(model.DataNascimentoAtualizada);
            entity.DataNascimento = model.DataNascimentoAtualizada;
            entity.DataContratacao = model.DataContratacaoAtualizada;
 
            _repository.AtualizarDadosFuncionario(model.NomeAtual, entity);

            return "Dados Funcionario Atualizados";
        }

    }
}
