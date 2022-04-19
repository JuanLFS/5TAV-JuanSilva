using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola01.Application.ViewModel
{
    public class AlunoResultViewModel
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public bool ResultValidation { get; set; }
        public AlunoResultViewModel(int Id, string Matricula, string Nome,
                                        string Cpf, string Email, string Cep)
        {
            this.Id = Id;
            this.Matricula = Matricula;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
            this.Cep = Cep;
        }
        public void SetResultValidation(bool certo)
        {
            this.ResultValidation = certo;
        }
    }
}
