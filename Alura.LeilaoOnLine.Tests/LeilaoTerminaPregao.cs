using Alura.LeilaoOnline.Core;
using System;
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
            var maria = new Interessada("Maria", leilao);

            leilao.IniciaPregao();
            for (int i = 0; i < ofertas.Length; i++)
            {
                var valor = ofertas[i];
                if ((i % 2) == 0)
                {
                    leilao.RecebeLance(fulano, valor);
                }
                else
                {
                    leilao.RecebeLance(maria, valor);
                }
            }

            // Act - método sob teste
            leilao.TerminaPregao();

            // Assert
            var valorObtido = leilao.Ganhador.Valor;
            Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        private void DisparaInvalidOperationExceptionDadodPregaoNaoIniciado()
        {
            //Arrange - cenário do teste
            var leilao = new Leilao("Van Gogh");

            // Assert
            var excecaoObtida = Assert.Throws<InvalidOperationException>(
                // Act - método sob teste
                () => leilao.TerminaPregao()
            );

            var mesangemEsperada = "Não é possível terminar o pregão sem que tenha começado. Para isso utilize o método inicia pregão.";
            Assert.Equal(mesangemEsperada, excecaoObtida.Message);
        }

        [Fact]
        private void RetornaZeroDadoLeilaoSemLances()
        {
            //Arrange - cenário do teste
            var leilao = new Leilao("Van Gogh");
            leilao.IniciaPregao();

            // Act - método sob teste
            leilao.TerminaPregao();

            // Assert
            var valorEsperado = 0;
            var valorObtido = leilao.Ganhador.Valor;

            Assert.Equal(valorEsperado, valorObtido);
        }
    }
}