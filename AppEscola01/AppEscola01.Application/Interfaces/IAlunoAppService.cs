using AppEscola01.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscola01.Application.Interfaces
{
    public interface IAlunoAppService
    {
        public AlunoResultViewModel Create(AlunoCreateViewModel aluno);
    }
}
