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
        public String Classificacao { get; set; }
        public Double ValorDiaria { get; set; }

        public Quarto(int numero, int qtd, string classificacao, double valor)
        {
            Numero = numero;
            QtdPessoas = qtd;
            Classificacao = classificacao;
            ValorDiaria = valor;
        }

    }
}
