using Calculadora.Models;
using Moq;
using System;
using Xunit;

namespace TesteCalculadora
{
    public class UnitTest1
    {
        [Fact]
        public void TestSoma()
        {
            //arrange
            Mock<InterfaceCalculadora> mock = new Mock<InterfaceCalculadora>(); //Aluno aluno = new Aluno();
            mock.Setup(m => m.soma()).Returns(2);


            //act
            CalculadoraProj calculadoraproj = new CalculadoraProj(mock.Object)
            {
                parcelaA = 2,
                parcelaB = 0
            };

            int result = calculadoraproj.soma();

            //assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void TesteSubtracao()
        {
            //arrange
            Mock<InterfaceCalculadora> mock = new Mock<InterfaceCalculadora>(); //Aluno aluno = new Aluno();
            mock.Setup(m => m.subtracao()).Returns(4);


            //act
            CalculadoraProj calculadoraproj = new CalculadoraProj(mock.Object)
            {
                parcelaA = 4,
                parcelaB = 0
            };

            int result = calculadoraproj.subtracao();

            //assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void TesteMultiplicao()
        {
            //arrange
            Mock<InterfaceCalculadora> mock = new Mock<InterfaceCalculadora>(); //Aluno aluno = new Aluno();
            mock.Setup(m => m.multiplicacao()).Returns(6);


            //act
            CalculadoraProj calculadoraproj = new CalculadoraProj(mock.Object)
            {
                parcelaA = 6,
                parcelaB = 0
            };

            int result = calculadoraproj.multiplicacao();

            //assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void TesteDivisao()
        {
            //arrange
            Mock<InterfaceCalculadora> mock = new Mock<InterfaceCalculadora>(); //Aluno aluno = new Aluno();
            mock.Setup(m => m.divisao()).Returns(8);


            //act
            CalculadoraProj calculadoraproj = new CalculadoraProj(mock.Object)
            {
                parcelaA = 8,
                parcelaB = 0
            };

            int result = calculadoraproj.divisao();

            //assert
            Assert.Equal(8, result);
        }
    }
}
