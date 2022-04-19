using AppEscola01.Application.AppService;
using AppEscola01.Application.ViewModel;
using AppEscola01.Domain.Entities;
using AppEscola01.Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AppEscola01.Teste.Application
{
    public class AlunoTest
    {
        [Fact]
        public void AlunoTestCreateAppService()
        {
            // Arrange
            AlunoCreateViewModel alunoIn = new AlunoCreateViewModel("jose da silva", 
                "34567891055", "ze@gmail.com", "20587120");
            Aluno aluno = new Aluno("jose da silva","34567891055", 
                                    "ze@gmail.com", "20587120");
            Mock<IAlunoService> mockAlunoService = new Mock<IAlunoService>();
           // Mock<IAlunoService> mockAlunoService = new Mock<IAlunoService>();
            mockAlunoService.Setup(m => m.Create(aluno)).Returns(true);

            AlunoAppService _alunoAppService = new AlunoAppService(mockAlunoService.Object);
            string resultEsperado = "20221123456";

            // Act
            var result = _alunoAppService.Create(alunoIn);

            // Assert
            Assert.Equal(resultEsperado, result.Matricula);
            Assert.Equal("34567891055", result.Cpf);
        }

    }
}
