using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstudoFuncionario2._0.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EditarCargoController
    {
        IEditarCargoService _service;
        public EditarCargoController(IEditarCargoService service)
        {
            _service = service;
        }
        
        [HttpPut]
        public string Edit(EditarCargoModel model)
        {
            string retorno = _service.AlterarCargo(model);
            return retorno;
        }
    }
}
