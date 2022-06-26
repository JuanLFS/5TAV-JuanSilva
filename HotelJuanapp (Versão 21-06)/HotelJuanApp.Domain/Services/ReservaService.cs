using HotelJuanApp.Domain.Entity;
using HotelJuanApp.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Domain.Services
{
    public class ReservaService : IReservaService
    {
        public List<Quarto> GetQuartoDisponiveis(DateTime dtinicio, DateTime dtfinal, int qtd)
        {
            throw new NotImplementedException();
        }
    }
}
