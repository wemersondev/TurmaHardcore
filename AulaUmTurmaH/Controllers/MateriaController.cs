using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AulaUmTurmaH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriaController : ControllerBase
    {
        private readonly IMateriaApplication _materiaApplication;
        public MateriaController(IMateriaApplication materiaApplication)
        {
            _materiaApplication = materiaApplication;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            return Ok(_materiaApplication.GetAll());
        }

        [HttpPost]
        public IActionResult Insert()
        {
            return Ok(_materiaApplication.GetAll());
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok(_materiaApplication.GetAll());
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok(_materiaApplication.GetAll());
        }


    }
}