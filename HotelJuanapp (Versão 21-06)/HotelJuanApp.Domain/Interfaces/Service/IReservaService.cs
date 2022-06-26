﻿using HotelJuanApp.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Domain.Interfaces.Service
{
    public interface IReservaService
    {
        public List<Quarto> GetQuartoDisponiveis(DateTime dtinicio, DateTime dtfinal, int qtd);
    }
}
