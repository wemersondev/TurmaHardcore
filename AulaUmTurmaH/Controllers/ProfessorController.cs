using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AulaUmTurmaH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly IProfessorApplication _professorApplication;
        public ProfessorController(IProfessorApplication professorApplication)
        {
            _professorApplication = professorApplication;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_professorApplication.GetAll());
        }

        [HttpPost]
        public IActionResult Insert()
        {
            return Ok(_professorApplication.GetAll());
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok(_professorApplication.GetAll());
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok(_professorApplication.GetAll());
        }


    }
}