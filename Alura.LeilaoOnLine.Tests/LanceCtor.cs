using System;
using System.Collections.Generic;
using System.Text;
using Alura.LeilaoOnline.Core;
using Xunit;

namespace Alura.LeilaoOnLine.Tests
{
    public class LanceCtor
    {
        [Fact]
        private void LancaArgumentExeceptionDadoValorNegativo()
        {
            // Arrange
            var valorNegativo = -100;

            // Assert
            Assert.Throws<ArgumentException>(
                // Act
                ()=> new Lance(null, valorNegativo)
            );
        }
    }
}
