using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstudoFuncionario2._0.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SalarioController : ControllerBase
    {
        ISalarioService _service;
        public SalarioController(ISalarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public string View([FromQuery]SalarioModel model)
        {
            string retorno = _service.CalcularSalario(model);
            return retorno;
        }
    }
}
