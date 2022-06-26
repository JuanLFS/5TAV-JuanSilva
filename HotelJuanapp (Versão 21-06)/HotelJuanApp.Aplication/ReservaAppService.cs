using AutoMapper;
using HotelJuanApp.Application.Interface;
using HotelJuanApp.Application.ViewModel;
using HotelJuanApp.Domain.Entity;
using HotelJuanApp.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace HotelJuanApp.Aplication
{
    public class ReservaAppService : IReservaAppService
    {
        IReservaService _reservaService;
        IMapper _mapper;

        public ReservaAppService()
        {
        }

        public ReservaAppService(IReservaService reservaService, IMapper mapper)
        {
            _reservaService = reservaService;
            _mapper = mapper;
        }

        public List<QuartoViewModel> GetQuartosDisponiveis(ConsultaPeriodoViewModel consulta)
        {
            List<Quarto> quartos = _reservaService.GetQuartoDisponiveis(consulta.Checkin, consulta.Checkout, consulta.QtdPessoas);
            
            //var quartoVm = _mapper.Map<QuartoViewModel>(quartos.GetRange(0, 1));

            List<QuartoViewModel> lstquartos = _mapper.Map<List<Quarto>, List<QuartoViewModel>>(quartos);

            return lstquartos;
        }
    }
}
