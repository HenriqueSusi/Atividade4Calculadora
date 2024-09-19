using AtividadeFuncionario.Models;

namespace TesteCalculoCustoFunc
{
    public class Calculadora
    {
        [Fact]
        public void TestarCalculo()
        {
            var f = new Funcionario()
            {
                SalarioClt = 1000,
                Desconto = 150,
                Beneficio = 10
            };

            Assert.Equal(860, AtividadeFuncionario.Controllers.FuncionarioController.CalcularCustoFuncionario(f));
        }
    }
}