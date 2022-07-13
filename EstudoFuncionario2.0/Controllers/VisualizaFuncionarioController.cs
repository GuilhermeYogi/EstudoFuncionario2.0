using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstudoFuncionario2._0.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class VisualizaFuncionarioController : ControllerBase
    {
        IVisualizaFuncionarioService _service;
        public VisualizaFuncionarioController(IVisualizaFuncionarioService service)
        {
            _service = service;
        }

        [HttpGet("/{id}")]
        public string View(int id)
        {
            string retorno = _service.ChecarFuncionario(id);
            return retorno;
        }
    }


}
