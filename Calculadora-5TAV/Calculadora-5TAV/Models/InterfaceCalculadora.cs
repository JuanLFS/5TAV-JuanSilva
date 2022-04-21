using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public interface InterfaceCalculadora
    {
        public int soma();

        public int subtracao();

        public int multiplicacao();

        public int divisao();
    }
}
