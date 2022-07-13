using EstudoFuncionario2._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoFuncionario2._0.Teste
{
    public class RetornaIdadeServiceTeste
    {
        RetornaIdadeService _idade;

        
        public RetornaIdadeServiceTeste()
        {
            _idade = new RetornaIdadeService();     
        }        

        [Theory]
        [InlineData("29/06/2022",0)]
        [InlineData("12/07/1993", 28)]
        [InlineData("12/05/1993", 29)]
        [InlineData("30/06/2022", -1)]
        public void ParaNascimentoXIdadeY (string textoNascimento, int idadeesperada)
        {
            DateTime nascimento = Convert.ToDateTime(textoNascimento);
            int idade = _idade.CalcularIdade(nascimento);
            Assert.Equal(idadeesperada, idade);
        }

    }
}
