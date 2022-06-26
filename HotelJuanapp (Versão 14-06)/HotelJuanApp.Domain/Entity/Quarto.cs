using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Domain.Entity
{
    public class Quarto : Entity
    {
        public int Numero { get; set; }
        public int QtdPessoas { get; set; }
        public string Classificacao { get; set; }
        public double ValorDiaria { get; set; }
    }
}
