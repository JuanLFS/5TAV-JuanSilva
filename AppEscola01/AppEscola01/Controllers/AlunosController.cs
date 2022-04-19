using AppEscola01.Application.AppService;
using AppEscola01.Application.Interfaces;
using AppEscola01.Application.ViewModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppEscola01.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunosController : ControllerBase
    {
        private IAlunoAppService _alunoAppService;
        //AlunosController(IAlunoAppService alunoAppService)
        //{
        //    _alunoAppService = alunoAppService;
        //}
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [EnableCors]
        [HttpPost]
        public void Post(AlunoCreateViewModel aluno)
        {
            
            AlunoAppService alunoAppService = new AlunoAppService();
            var alunoVM = alunoAppService.Create(aluno);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
