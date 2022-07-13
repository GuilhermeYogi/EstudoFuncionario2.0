using EstudoFuncionario2._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace EstudoFuncionario2._0.Teste
{
    public class ConverterCargoCargoIdServiceTeste
    {
        ConverterCargoCargoIdService service;
        public ConverterCargoCargoIdServiceTeste()
        {
            service = new ConverterCargoCargoIdService();
        }

        [Fact]
        public void ParaCargoId8CargoDeveSerAnalista()
        {
            var cargo = service.AtribuirCargo(8);
            
            Assert.Equal("Analista", cargo);
        }

        [Fact]
        public void ParaCargoId9CargoDeveSerGestor()
        {
            var cargo = service.AtribuirCargo(9);
            Assert.Equal("Gestor", cargo);
        }

        [Fact]
        public void ParaCargoId10CargoDeveSerEncarregadoDaLimpeza()
        {
            var cargo = service.AtribuirCargo(10);
            Assert.Equal("Encarregado da Limpeza", cargo);
        }

        [Fact]
        public void ParaOutrosCargoIdCargoDeveSerInexistente()
        {
            var cargo = service.AtribuirCargo(12);
            Assert.Equal("Cargo Inexistente", cargo);
        }
    }
}
