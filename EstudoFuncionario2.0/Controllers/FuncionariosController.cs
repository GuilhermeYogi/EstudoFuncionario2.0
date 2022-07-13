using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstudoFuncionario2._0.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class FuncionariosController : ControllerBase
    {
        IFuncionariosService _service;
        public FuncionariosController(IFuncionariosService service)
        {
            _service = service;
        }

        [HttpPost]
        public string Add(FuncionarioAddModel model)
        {
            string retorno = _service.AdicionarFuncionario(model);
            return retorno;
        }
    }
}
