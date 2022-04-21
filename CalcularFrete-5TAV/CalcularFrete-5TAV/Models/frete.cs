using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalcularFrete_5TAV.Models
{
    public class Frete
    {
        public int Cep { get; set; }
        public double Peso { get; set; }

        private ICorreioService correioService;

        public Frete(ICorreioService _correioService)
        {
            correioService = _correioService;
        }

        public double CalcularFrete()
        {
            return correioService.CalcularFrete();
        }
    }
}
