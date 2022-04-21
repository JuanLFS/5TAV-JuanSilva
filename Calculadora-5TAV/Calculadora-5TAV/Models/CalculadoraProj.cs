using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class CalculadoraProj
    {
        public InterfaceCalculadora interfaceCalculadora;

        public int parcelaA { get; set; }

        public int parcelaB { get; set; }


        public CalculadoraProj() { }

        public CalculadoraProj( InterfaceCalculadora _interfacecalculadora)
        {
            interfaceCalculadora = _interfacecalculadora;
        }

        public int soma()
        {
            return interfaceCalculadora.soma();
        }

        public int subtracao()
        {
            return interfaceCalculadora.subtracao();
        }

        public int multiplicacao()
        {
            return interfaceCalculadora.multiplicacao();
        }

        public int divisao()
        {
            return interfaceCalculadora.divisao();
        }
    }
}
