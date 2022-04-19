using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola01.Application.ViewModel
{
    public class AlunoCreateViewModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }

        public AlunoCreateViewModel(string Nome, string Cpf, string Email, string Cep)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
            this.Cep = Cep;
        }

    }
}
