using AutoMapper;
using HotelJuanApp.Aplication;
using HotelJuanApp.Application.ViewModel;
using HotelJuanApp.Domain.Entity;
using HotelJuanApp.Domain.Interfaces.Service;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace HotelJuanApp.Test
{
    public class ReservaUnitTest
    {
        IReservaService _reservaApp;
        IConfigurationProvider _provid;

        public ReservaUnitTest(IReservaService reservaApp, IConfigurationProvider provid)
        {
            _reservaApp = reservaApp;
            _provid = provid;
        }

        [Fact]
        public void Test1()
        {
            // Arrenge
            ConsultaPeriodoViewModel consulta = new ConsultaPeriodoViewModel(DateTime.Now.AddDays(2), DateTime.Now.AddDays(6), 2);

            List<Quarto> lstQuartos = new List<Quarto>();
            Quarto qt = new Quarto(304, 2, "standart", 202.00);
            lstQuartos.Add(qt);

            qt = new Quarto(307, 2, "standart", 212.00);
            lstQuartos.Add(qt);

            Mock<IReservaService> mock = new Mock<IReservaService>();
            mock.Setup(m => m.GetQuartoDisponiveis(DateTime.Now.AddDays(2), DateTime.Now.AddDays(4), 2)).Returns(lstQuartos);

            AutoMapper.IMapper autoMapper = new Mapper(_provid);
            ReservaAppService reservaApp = new ReservaAppService(mock.Object, autoMapper);
            S
            // Act
            List<QuartoViewModel> x = reservaApp.GetQuartosDisponiveis(consulta);

            // Assert
            Assert.True(x.Count == 2);
        }
    }
}
