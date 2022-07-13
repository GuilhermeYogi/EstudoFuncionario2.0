using EstudoFuncionario2._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFuncionario2._0.Teste
{
    public class ConverterGrauGrauIdServiceTeste
    {
        ConverterGrauGrauIdService service;
        public ConverterGrauGrauIdServiceTeste()
        {
            service = new ConverterGrauGrauIdService();
        }

        [Theory]
        [InlineData(1,"Junior")]
        [InlineData(2,"Pleno")]
        [InlineData(3,"Senior")]
        public void ParaGrauIdXGrauDeveSerY(int grauId, string grauEsperado)
        {
            var grau = service.AtribuirGrau(grauId);
            Assert.Equal(grauEsperado, grau);
        }
    }
}
