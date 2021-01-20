using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Alura.LeilaoOnline.Core;
using System.Linq;

namespace Alura.LeilaoOnLine.Tests
{
    public class LeilaoRecebeOferta
    {
        [Fact]
        private void NaoAceitaProximoLanceDadoMEsmoClienteRealizouUltimoLance()
        {
            //Arrange - cenário do teste
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh", modalidade);
            var fulano = new Interessada("Fulano", leilao);
            leilao.IniciaPregao();
            leilao.RecebeLance(fulano, 800);

            // Act - método sob teste
            leilao.RecebeLance(fulano, 1000);

            // Assert
            var quantidadeEsperada = 1;
            var quantidadeObtidade = leilao.Lances.Count();
            Assert.Equal(quantidadeEsperada, quantidadeObtidade);
        }

        [Theory]
        [InlineData(4, new double[] { 1000, 1200, 1440, 15000 })]
        [InlineData(2, new double[] { 800, 900})]
        private void NaoPermiteNovosLancesDadoLeilaoFinalizado(int quantidadeEsperada, double[] ofertas)
        {
            //Arrange - cenário do teste
            var modalidade = new MaiorValor();
            var leilao = new Leilao("Van Gogh", modalidade);
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.IniciaPregao();
            for (int i = 0; i < ofertas.Length; i++)
            {
                var valor = ofertas[i];
                if ((i%2) == 0)
                {
                    leilao.RecebeLance(fulano, valor);
                }
                else
                {
                    leilao.RecebeLance(maria, valor);
                }
            }
            leilao.TerminaPregao();

            // Act - método sob teste
            leilao.RecebeLance(fulano, 1000);

            // Assert
            var quantidadeObtidade = leilao.Lances.Count();

            Assert.Equal(quantidadeEsperada, quantidadeObtidade);
        }
    }
}
