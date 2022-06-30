using AulaUmTurmaH.Application.DTOs;
using AulaUmTurmaH.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AulaUmTurmaH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoApplication _alunoApplication;
        public AlunoController(IAlunoApplication alunoApplication)
        {
            _alunoApplication = alunoApplication;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_alunoApplication.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(AlunoDTO alunoDTO)
        {
            _alunoApplication.Insert(alunoDTO);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(AlunoDTO alunoDTO)
        {
            _alunoApplication.Update(alunoDTO);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _alunoApplication.Delete(id);
            return Ok();
        }


    }
}