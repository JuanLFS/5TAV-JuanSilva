using HotelJuanApp.Application.Interface;
using HotelJuanApp.Application.ViewModel;
using HotelJuanApp.Domain.Entity;
using System;
using System.Collections.Generic;

namespace HotelJuanApp.Aplication
{
    public class ReservaAppService : IReservaAppService
    {
        public List<QuartoViewModel> GetQuartosDisponiveis(ConsultaPeriodoViewModel consulta)
        {
            List <QuartoViewModel> lstQuartos= new List<QuartoViewModel>();

            QuartoViewModel qt = new QuartoViewModel(304, 2, "standart", 202.00);
            qt.QtdPessoas=2;
            lstQuartos.Add(qt);

            return lstQuartos;
        }
    }
}
