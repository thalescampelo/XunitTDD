using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnLine.Tests
{
    public class LeilaoTestes
    {
        [Fact]
        private void LeilaoComTresClientes()
        {
            //Arrange - cenário do teste
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);
            var beltrano = new Interessada("Beltrano", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(maria, 990);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(beltrano, 1400);

            // Act - método sob teste
            leilao.TerminaPregao();

            // Assert
            var valorEsperado = 1400;
            var valorObtido = leilao.Ganhador.Valor;
            Assert.Equal(valorEsperado, valorObtido);
            Assert.Equal(beltrano, leilao.Ganhador.Cliente);
        }

        [Fact]
        private void LeilaoComLancesOrdenadosPorValor()
        {
            //Arrange - cenário do teste
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(maria, 990);
            leilao.RecebeLance(fulano, 1000);

            // Act - método sob teste
            leilao.TerminaPregao();

            // Assert
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;

            Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        private void LeilaoComVariosLances()
        {
            //Arrange - cenário do teste
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);
            leilao.RecebeLance(maria, 900);
            leilao.RecebeLance(fulano, 1000);
            leilao.RecebeLance(maria, 990);

            // Act - método sob teste
            leilao.TerminaPregao();

            // Assert
            var valorEsperado = 1000;
            var valorObtido = leilao.Ganhador.Valor;

            Assert.Equal(valorEsperado, valorObtido);
        }

        [Fact]
        private void LeilaoComApenasUmLance()
        {
            //Arrange - cenário do teste
            var leilao = new Leilao("Van Gogh");
            var fulano = new Interessada("Fulano", leilao);
            var maria = new Interessada("Maria", leilao);

            leilao.RecebeLance(fulano, 800);

            // Act - método sob teste
            leilao.TerminaPregao();

            // Assert
            var valorEsperado = 800;
            var valorObtido = leilao.Ganhador.Valor;

            Assert.Equal(valorEsperado, valorObtido);
        }
    }
}