using HotelJuanApp.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Application.Interface
{
    public interface IReservaAppService
    {
        List<QuartoViewModel> GetQuartosDisponiveis(ConsultaPeriodoViewModel consulta);
    }
}
