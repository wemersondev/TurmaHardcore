using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Application.DTOs;
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
        public IActionResult Insert(ProfessorDTO professorDTO)
        {
            _professorApplication.Insert(professorDTO);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(ProfessorDTO professorDTO)
        {
            _professorApplication.Update(professorDTO);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _professorApplication.Delete(id);
            return Ok();
        }


    }
}