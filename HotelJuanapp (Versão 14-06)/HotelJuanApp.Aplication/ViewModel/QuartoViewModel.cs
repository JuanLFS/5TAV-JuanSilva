using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelJuanApp.Application.ViewModel
{
    public class QuartoViewModel
    {
       
        public int Numero { get; set; }
        public int QtdPessoas { get; set; }
        public String Classificacao { get; set; }
        public Double ValorDiaria { get; set; }
       

        public QuartoViewModel(int numero, int qtdPessoas, string classificacao, double valorDiaria)
        {
            Numero = numero;
            QtdPessoas = qtdPessoas;
            Classificacao = classificacao;
            ValorDiaria = valorDiaria;
        }
    }
}
