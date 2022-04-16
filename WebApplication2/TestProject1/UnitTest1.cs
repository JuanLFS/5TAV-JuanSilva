using System;
using Xunit;
using WebApplication2;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestSomaDoisInteiros()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Soma(5, 3);
            int esperado = 8;

            // Assert
            Assert.Equal(esperado, result);
        }
        [Fact]
        public void TestSomaDoisFloats()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Soma(5.854, 3.369);
            double esperado = 9.223;

            // Assert
            Assert.Equal(esperado, result);
        }
        [Fact]
        public void TestSomaUmNegativo()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Soma(5.854, -3.369);
            double esperado = 2.485;

            // Assert
            Assert.Equal(esperado, result);
        }

        [Fact]
        public void TestDivisaoDoisFloats()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Divisao(5.854, 3.369);
            double esperado = 1.738;

            // Assert
            Assert.Equal(esperado, result, 3);
        }
        [Fact]
        public void TestDivisaoPorNegativo()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Divisao(5.854, -3.369);
            double esperado = -1.738;

            // Assert
            Assert.Equal(esperado, result, 3);
        }
        [Fact]
        public void TestDivisaoPorZero()
        {
            // Arrange
            Calculadora calc = new Calculadora();

            // Act
            var result = calc.Divisao(5.854, 0);
            string esperado = "500";

            // Assert
            Assert.Throws<Exception>(result);
        }
    }
}
