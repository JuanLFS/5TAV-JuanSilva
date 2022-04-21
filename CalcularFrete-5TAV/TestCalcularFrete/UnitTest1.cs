using CalcularFrete_5TAV.Models;
using Moq;
using System;
using Xunit;

namespace TestCalcularFrete
{
    public class UnitTest1
    {
        [Fact]
        public void TestFrete()
        {

            //Arrange
            Mock<ICorreioService> mock = new Mock<ICorreioService>();
            mock.Setup(m => m.CalcularFrete()).Returns(7.52);
            Frete frete = new Frete(mock.Object)
            {
                Cep = 21857818,
                Peso = 5
            };
            //Act
            double resultado = frete.CalcularFrete();
            //Assert
            Assert.Equal(7.52, resultado);
        }
    }
}
