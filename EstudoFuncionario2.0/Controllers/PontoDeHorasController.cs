using EstudoFuncionario2._0.Interfaces;
using EstudoFuncionario2._0.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstudoFuncionario2._0.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PontoDeHorasController
    {
        IBaterPontoService _service;
        public PontoDeHorasController(IBaterPontoService service)
        {
            _service = service;
        }

        [HttpPost]
        public string Edit(BaterPontoModel model)
        {
            string retorno = _service.InserirPontoDeHoras(model);
            return retorno;
        }
    }
}
