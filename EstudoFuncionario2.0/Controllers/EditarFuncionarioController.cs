using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstudoFuncionario2._0.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EditarFuncionarioController
    {
        IEditarFuncionarioService _service;
        public EditarFuncionarioController(IEditarFuncionarioService service)
        {
            _service = service;
        }

        [HttpPut]
        public string Edit(EditarFuncionarioModel model)
        {
            string retorno = _service.AlterarDadosFuncionario(model);
            return retorno;
        }
    }
}
