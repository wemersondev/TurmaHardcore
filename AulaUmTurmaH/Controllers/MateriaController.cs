using AulaUmTumaH.Domain.Entities;
using AulaUmTurmaH.Application.DTOs;
using AulaUmTurmaH.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AulaUmTurmaH.Controllers
{
    [Authorize]
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
        public IActionResult Insert(MateriaDTO materiaDTO)
        {
            _materiaApplication.Insert(materiaDTO);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(MateriaDTO materiaDTO)
        {
            _materiaApplication.Update(materiaDTO);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _materiaApplication.Delete(id);
            return Ok();
        }


    }
}