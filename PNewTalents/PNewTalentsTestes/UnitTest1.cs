using PNewTalents;
using System;
using Xunit;

namespace PNewTalentsTestes
{
    public class UnitTest1
    {
        public Calculadora construtorCalc()
        {
            string data = "09/10/2024";
            Calculadora calc = Calculadora("09/10/2024");
            return calc;
        }

        [Theory]
        [InlineData(2,5,7)]
        public void TesteSomar(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = construtorCalc();

            // Act
            int resultadoCalculadora = calc.Somar(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(10, 100, 1000)]
        public void TesteMultiplicar(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = construtorCalc();

            // Act
            int resultadoCalculadora = calc.Multiplicar(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(100, 10, 90)]
        public void TesteSubtrair(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = construtorCalc();

            // Act
            int resultadoCalculadora = calc.Subtrair(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }


        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(100, 10, 10)]
        public void TesteDividir(int num1, int num2, int resultado)
        {
            // Arrange
            Calculadora calc = construtorCalc();

            // Act
            int resultadoCalculadora = calc.Dividir(num1, num2);

            // Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construtorCalc();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
        }

        [Fact]
        public void TestarHistorico()
        {
            // Arrange
            Calculadora calc = construtorCalc();

            // Act
            calc.Somar(1, 5);
            calc.Somar(2, 7);
            calc.Somar(3, 2);
            calc.Somar(4, 5);
            calc.Somar(5, 5);

            var lista = calc.Historico();

            // Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}