using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola01.Domain.Entities
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public Aluno(string Nome,string Cpf, string Email, string Cep)
        {
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Email = Email;
            this.Cep = Cep;
        }

        public void CriaMatricula()
        {
            this.Matricula = "20221123456";
        }

        //public Aluno(AlunoCreateViewModel aluno)
        //{
        //    this.Nome = Nome;
        //    this.Cpf = Cpf;
        //    this.Email = Email;
        //    this.Cep = Cep;
        //}

        public void CalculaMatricula(string mat)
        {
            this.Matricula = mat;
        }
    }
}
