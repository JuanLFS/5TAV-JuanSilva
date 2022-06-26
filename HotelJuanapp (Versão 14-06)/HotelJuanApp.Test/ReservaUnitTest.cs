using HotelJuanApp.Aplication;
using HotelJuanApp.Application.ViewModel;
using System;
using System.Collections.Generic;
using Xunit;

namespace HotelJuanApp.Test
{
    public class ReservaUnitTest
    {
        [Fact]
        public void Test1()
        {
            // Arrenge
            ConsultaPeriodoViewModel consulta = new ConsultaPeriodoViewModel(DateTime.Now.AddDays(2), DateTime.Now.AddDays(6), 2);
            ReservaAppService reservaApp = new ReservaAppService();

            // Act
            List<QuartoViewModel> x = reservaApp.GetQuartosDisponiveis(consulta);

            // Assert
            Assert.True(x.Count > 0);
        }
    }
}
