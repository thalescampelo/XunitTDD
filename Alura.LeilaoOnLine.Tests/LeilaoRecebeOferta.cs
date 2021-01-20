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
        [Theory]
        [InlineData(4, new double[] { 1000, 1200, 1440, 15000 })]
        [InlineData(2, new double[] { 800, 900})]
        private void NaoPermiteNovosLancesDadoLeilaoFinalizado(int quantidadeEsperada, double[] ofertas)
        {
            //Arrange - cenário do teste
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            
            foreach(var valor in ofertas)
            {
                leilao.RecebeLance(fulano, valor);
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
