using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnLine.Tests
{
    public class LeilaoTerminaPregao
    {
        [Theory]
        [InlineData(1000, new double[] { 800, 900, 1000, 990 })]
        [InlineData(1000, new double[] { 800, 900, 990, 1000 })]
        [InlineData(800, new double[] { 800 })]
        private void RetornaMaiorValorDadoLeilaoComPeloMenosUmLance(double valorEsperado, double[] ofertas)
        {
            //Arrange - cenário do teste
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);

            leilao.IniciaPregao();
            foreach(var valor in ofertas)
            {
                leilao.RecebeLance(fulano, valor);
            }

            // Act - método sob teste
            leilao.TerminaPregao();

            // Assert
            var valorObtido = leilao.Ganhador.Valor;
            Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        private void RetornaZeroDadoLeilaoSemLances()
        {
            //Arrange - cenário do teste
            var leilao = new Leilao("Van Gogh");

            // Act - método sob teste
            leilao.TerminaPregao();

            // Assert
            var valorEsperado = 0;
            var valorObtido = leilao.Ganhador.Valor;

            Assert.Equal(valorEsperado, valorObtido);
        }
    }
}