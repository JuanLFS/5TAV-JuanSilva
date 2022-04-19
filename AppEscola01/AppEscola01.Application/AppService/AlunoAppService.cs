using AppEscola01.Application.Interfaces;
using AppEscola01.Application.ViewModel;
using AppEscola01.Domain.Entities;
using AppEscola01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola01.Application.AppService
{
    public class AlunoAppService : IAlunoAppService
    {
        IAlunoService _alunoService;
        public AlunoAppService(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }
        public AlunoResultViewModel Create(AlunoCreateViewModel aluno) 
        {
            Aluno _aluno = new Aluno(aluno.Nome, aluno.Cpf, aluno.Email, aluno.Cep);
            _aluno.CriaMatricula();

            var retorno = _alunoService.Create(_aluno);
            if (retorno)
            {
                AlunoResultViewModel result = new AlunoResultViewModel(1, 
                _aluno.Matricula, _aluno.Nome, _aluno.Cpf, _aluno.Email, _aluno.Cep);

            return result;
            } 

            return null;
            
            //Aluno alunoNew = new Aluno(aluno.Nome, aluno.Cpf, aluno.Email, aluno.Cep);

            //AlunoResultViewModel alunoResult = new AlunoResultViewModel(1, 
            //   "2022123456","jose da silva", "AB345678910", "ze@gmail.com", "20587120");
            //alunoResult.SetResultValidation(false);

            //return alunoResult;
        }

    }
}
