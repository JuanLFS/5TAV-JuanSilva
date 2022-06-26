using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Application.ViewModel
{
    public class ConsultaPeriodoViewModel
    {
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }
        public int QtdPessoas { get; set; }

        public ConsultaPeriodoViewModel(DateTime dateTime1, DateTime dateTime2, int qtd)
        {
            this.Checkin = dateTime1;
            this.Checkout = dateTime2;
            this.QtdPessoas = qtd;
        }
    }
}
