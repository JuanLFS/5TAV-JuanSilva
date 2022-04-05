using System;
using Xunit;
using FreteApp02;
using Moq;

namespace TestFrete1
{
    public class UnitTest1
    {
        [Fact]
        public void TestCalcularFrete()
        {
            // Arrange
            Mock<ICorreioService> mock = new Mock<ICorreioService>();
            mock.Setup(m => m.CalculaFrete()).Returns(7.52);
            Frete frete = new Frete(mock.Object)
            {
                Cep = 21857010,
                Peso = 5,
            };

            // Act
            double resultado = frete.CalcularFrete();

            // Assert
            Assert.Equal(7.52, resultado);

        }
		
		[Fact]
        public void TestTaxa()
        {
            // Arrange
            Mock<ICorreioService> mock = new Mock<ICorreioService>();
            mock.Setup(m => m.CalculaFrete()).Returns(10.52);
            Frete frete = new Frete(mock.Object)
            {
                Cep = 21857010,
                Peso = 8,
            };

            // Act
            double resultado = frete.CalcularFrete();

            // Assert
            Assert.Equal(10.52, resultado);

        }
    }
}
